using System.Net.Http.Headers;
using System.Net.Http.Json;
using Camunda.Infra.Models;
using Newtonsoft.Json;

namespace Camunda.Infra.Services;

public class CamundaService
{
    private const string ProcessKey = "order-process";
    private readonly HttpClient _httpClient;

    public CamundaService(string baseUrl)
    {
        // Camunda 8 REST API - /v2
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUrl.TrimEnd('/') + "/"),
            Timeout = TimeSpan.FromSeconds(30)
        };
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // ─── Start Process ─────────────────────────────────────────────────────────
    public async Task<StartProcessResponse> StartProcessAsync(
        string orderId, string customerName, string customerEmail, int quantity)
    {
        var request = new
        {
            processDefinitionId = ProcessKey,
            businessId = orderId,
            variables = new Dictionary<string, object>
            {
                ["orderId"] = new { value = orderId },
                ["customerName"] = new { value = customerName },
                ["customerEmail"] = new { value = customerEmail },
                ["quantity"] = new { value = quantity },
                ["valid"] = new { value = false },
                ["inventorySufficient"] = new { value = false }
            }
        };

        var response = await _httpClient.PostAsJsonAsync("process-instances", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در شروع پروسه: {content}");

        return JsonConvert.DeserializeObject<StartProcessResponse>(content)!;
    }

    // ─── Get Numeric Process Definition Key ───────────────────────────────────
    private async Task<long?> GetProcessDefinitionKeyAsync()
    {
        var request = new
        {
            filter = new { processDefinitionId = ProcessKey },
            page = new { from = 0, limit = 1 }
        };

        var response = await _httpClient.PostAsJsonAsync("process-definitions/search", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode) return null;

        var result = JsonConvert.DeserializeObject<ProcessDefinitionSearchResponse>(content);
        return result?.Items?.FirstOrDefault()?.Key;
    }

    // ─── Get Process Instances ─────────────────────────────────────────────────
    public async Task<List<ProcessInstance>> GetActiveProcessesAsync()
    {
        var request = new
        {
            filter = new { processDefinitionId = ProcessKey },
            sort = new[] { new { field = "startDate", order = "DESC" } },
            page = new { from = 0, limit = 50 }
        };

        var response = await _httpClient.PostAsJsonAsync("process-instances/search", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در دریافت پروسه‌ها: {content}");

        var www = content; // موقت اضافه کن

        var result = JsonConvert.DeserializeObject<ProcessInstanceSearchResponse>(content);
        return result?.Items ?? new List<ProcessInstance>();
    }

    // ─── Get Current Activity (Flownode) ──────────────────────────────────────
    public async Task<ActivityInstance> GetActivityInstanceAsync(string processInstanceId)
    {
        var request = new
        {
            filter = new { processInstanceKey = processInstanceId },
            page = new { from = 0, limit = 10 }
        };

        var response = await _httpClient.PostAsJsonAsync("element-instances/search", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در دریافت activity: {content}");


        var ww = content;


        var result = JsonConvert.DeserializeObject<FlownodeSearchResponse>(content);
        var items = result?.Items ?? new List<FlownodeInstance>();

        // فقط ACTIVE node ها رو برگردون
        var activeNode = items.FirstOrDefault(x => x.State == "ACTIVE");

        return new ActivityInstance
        {
            Id = processInstanceId,
            ActivityId = activeNode?.FlownodeId ?? "",
            ActivityName = activeNode?.FlownodeName ?? "",
            ChildActivityInstances = activeNode != null
                ? new List<ActivityInstance>
                {
                    new()
                    {
                        ActivityId = activeNode.FlownodeId,
                        ActivityName = activeNode.FlownodeName ?? activeNode.FlownodeId
                    }
                }
                : new List<ActivityInstance>()
        };
    }

    // ─── Get Variables ─────────────────────────────────────────────────────────
    public async Task<Dictionary<string, object?>> GetProcessVariablesAsync(string processInstanceId)
    {
        var request = new
        {
            filter = new { processInstanceKey =(processInstanceId) },
            page = new { from = 0, limit = 100 }
        };

        var response = await _httpClient.PostAsJsonAsync("variables/search", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در دریافت variables: {content}");

        var result = JsonConvert.DeserializeObject<VariableSearchResponse>(content);
        return result?.Items?.ToDictionary(v => v.Name, v => v.Value) ?? new Dictionary<string, object?>();
    }

    // ─── Fetch & Complete Job ──────────────────────────────────────────────────
    public async Task<List<Job>> FetchJobsAsync(string jobType)
    {
        var request = new
        {
            filter = new
            {
                processInstanceKey = (string?)null,
                type = jobType,
                state = "CREATED"
            },
            page = new { from = 0, limit = 10 }
        };

        var response = await _httpClient.PostAsJsonAsync("jobs/search", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در دریافت jobs: {content}");

        var result = JsonConvert.DeserializeObject<JobSearchResponse>(content);
        return result?.Items ?? new List<Job>();
    }

    public async Task CompleteJobAsync(string jobKey, Dictionary<string, VariableValue> variables)
    {
        var request = new
        {
            variables = variables.ToDictionary(
                k => k.Key,
                v => new { value = v.Value.Value }
            )
        };

        var response = await _httpClient.PostAsJsonAsync($"jobs/{jobKey}/completion", request);
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            throw new Exception($"خطا در complete job: {content}");
    }
}