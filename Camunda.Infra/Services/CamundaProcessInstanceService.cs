// ============================================================
//  Camunda 8.9 – Process Instance Service
//  شامل متدهای Cancel (لغو/توقف) و Delete (حذف کامل تاریخچه)
// ============================================================

using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Camunda.Infra.Endpoints;
using Camunda.Infra.Models;

namespace Camunda.Infra.Services
{
    public class CamundaAuthOptions
    {
        public string BaseUrl { get; set; } = string.Empty;

        // Basic Auth
        public string? Username { get; set; }
        public string? Password { get; set; }

        // Bearer Token
        public string? BearerToken { get; set; }

        public bool UseBearerToken => !string.IsNullOrEmpty(BearerToken);
    }

    public class CamundaProcessInstanceService
    {
        private readonly HttpClient _httpClient;
        private readonly CamundaAuthOptions _options;
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public CamundaProcessInstanceService(HttpClient httpClient, CamundaAuthOptions options)
        {
            _httpClient = httpClient;
            _options = options;
            _httpClient.BaseAddress = new Uri(options.BaseUrl.TrimEnd('/') + "/");
            ApplyAuthHeader();
        }

        private void ApplyAuthHeader()
        {
            if (_options.UseBearerToken)
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _options.BearerToken);
            }
            else if (!string.IsNullOrEmpty(_options.Username))
            {
                var raw = $"{_options.Username}:{_options.Password}";
                var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(raw));
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Basic", encoded);
            }
        }

        /// <summary>
        /// دریافت اطلاعات کامل یک process instance (برای چک کردن وضعیت قبل از حذف)
        /// </summary>
        public async Task<ProcessInstanceResult?> GetByKeyAsync(string processInstanceKey, CancellationToken ct = default)
        {
            var url = string.Format(CamundaApi.ProcessInstanceByKey, processInstanceKey);
            var response = await _httpClient.GetAsync(url, ct);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync(ct);
            return JsonSerializer.Deserialize<ProcessInstanceResult>(json, JsonOptions);
        }

        /// <summary>
        /// لغو/توقف یک process instance که در حال اجراست (ACTIVE).
        /// این عملیات instance رو متوقف می‌کنه ولی تاریخچه‌اش در Operate باقی می‌مونه.
        /// معادل "Deactivate" یا "Cancel" در Operate.
        /// </summary>
        public async Task CancelAsync(string processInstanceKey, CancellationToken ct = default)
        {
            var url = string.Format(CamundaApi.ProcessInstanceCancel, processInstanceKey);
            var content = new StringContent("{}", Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content, ct);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync(ct);
                throw new CamundaApiException(
                    $"خطا در لغو process instance با کلید {processInstanceKey}: {response.StatusCode}",
                    response.StatusCode,
                    error);
            }
        }

        /// <summary>
        /// حذف کامل و دائمی یک process instance از تاریخچه (Elasticsearch/secondary storage).
        /// فقط روی instance هایی کار می‌کنه که در وضعیت COMPLETED یا TERMINATED باشن.
        /// اگر instance هنوز ACTIVE باشه، خطای 409 برمی‌گردونه — اول باید Cancel بشه.
        /// این عملیات غیرقابل بازگشته (Irreversible).
        /// </summary>
        public async Task DeleteAsync(string processInstanceKey, CancellationToken ct = default)
        {
            var url = string.Format(CamundaApi.ProcessInstanceDelete, processInstanceKey);
            var response = await _httpClient.DeleteAsync(url, ct);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync(ct);

                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    throw new CamundaApiException(
                        $"امکان حذف وجود ندارد: instance با کلید {processInstanceKey} هنوز فعال (ACTIVE) است. " +
                        "ابتدا باید آن را Cancel کنید.",
                        response.StatusCode,
                        error);
                }

                throw new CamundaApiException(
                    $"خطا در حذف process instance با کلید {processInstanceKey}: {response.StatusCode}",
                    response.StatusCode,
                    error);
            }
        }

        /// <summary>
        /// حذف دسته‌جمعی چند process instance بر اساس فیلتر.
        /// این عملیات async است و یک batchOperationKey برمی‌گردونه که می‌تونید پیشرفتش را پیگیری کنید.
        /// </summary>
        public async Task<string> DeleteBatchAsync(List<string> processInstanceKeys, CancellationToken ct = default)
        {
            var payload = new
            {
                filter = new
                {
                    processInstanceKey = new
                    {
                        @in = processInstanceKeys
                    }
                }
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(CamundaApi.ProcessInstanceDeleteBatch, content, ct);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync(ct);
                throw new CamundaApiException(
                    "خطا در حذف دسته‌جمعی process instance ها",
                    response.StatusCode,
                    error);
            }

            var responseJson = await response.Content.ReadAsStringAsync(ct);
            using var doc = JsonDocument.Parse(responseJson);
            return doc.RootElement.GetProperty("batchOperationKey").GetString() ?? string.Empty;
        }

        /// <summary>
        /// متد ترکیبی هوشمند: اگه instance فعاله اول cancel می‌کنه، بعد delete.
        /// اگه از قبل completed/terminated باشه مستقیم delete می‌کنه.
        /// </summary>
        public async Task CancelThenDeleteAsync(string processInstanceKey, CancellationToken ct = default)
        {
            var instance = await GetByKeyAsync(processInstanceKey, ct);

            if (instance == null)
                throw new CamundaApiException($"Process instance با کلید {processInstanceKey} یافت نشد.",
                    System.Net.HttpStatusCode.NotFound, string.Empty);

            if (instance.State == ProcessInstanceState.ACTIVE)
            {
                await CancelAsync(processInstanceKey, ct);

                // کمی صبر برای پردازش async توسط Zeebe
                await Task.Delay(1000, ct);
            }

            await DeleteAsync(processInstanceKey, ct);
        }
    }

    public class CamundaApiException : Exception
    {
        public System.Net.HttpStatusCode StatusCode { get; }
        public string ResponseBody { get; }

        public CamundaApiException(string message, System.Net.HttpStatusCode statusCode, string responseBody)
            : base(message)
        {
            StatusCode = statusCode;
            ResponseBody = responseBody;
        }
    }
}