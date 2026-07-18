using Camunda.Appp;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class CamundaService
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;

    public CamundaService(string baseUrl = "http://localhost:8080")
    {
        _baseUrl = baseUrl;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
    }

    // ===================== متدهای موجود =====================

    public async Task<ProcessInstanceResponse> StartProcessInstanceAsync(string processDefinitionId, Dictionary<string, object> variables = null)
    {
        var request = new
        {
            processDefinitionId,
            variables = variables ?? new Dictionary<string, object>()
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/process-instances", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to start process: {responseString}");

        return JsonSerializer.Deserialize<ProcessInstanceResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<ProcessInstanceListResponse> GetProcessInstancesAsync(string processDefinitionId = null, string state = null)
    {
        var url = $"{_baseUrl}/v2/process-instances/search";

        var body = new Dictionary<string, object>();

        if (!string.IsNullOrEmpty(processDefinitionId) || !string.IsNullOrEmpty(state))
        {
            var filter = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(processDefinitionId))
                filter["processDefinitionId"] = processDefinitionId;

            if (!string.IsNullOrEmpty(state))
                filter["state"] = state;

            body["filter"] = filter;
        }

        var json = JsonSerializer.Serialize(body);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed: {responseString}");

        return JsonSerializer.Deserialize<ProcessInstanceListResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<VariableListResponse> GetVariablesAsync(string processInstanceKey)
    {
        var url = $"{_baseUrl}/v2/variables/search";

        var requestBody = new
        {
            filter = new
            {
                processInstanceKey = processInstanceKey
            }
        };

        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get variables: {responseString}");

        return JsonSerializer.Deserialize<VariableListResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task<JobListResponse> ActivateJobsAsync(string jobType, int maxJobs = 100)
    {
        var request = new
        {
            type = jobType,
            worker = "ManagerFormWorker",
            timeout = 10000,
            maxJobsToActivate = maxJobs
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/jobs/activation", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to activate jobs: {responseString}");

        return JsonSerializer.Deserialize<JobListResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task CompleteJobAsync(string jobKey, Dictionary<string, object> variables = null)
    {
        var request = new
        {
            variables = variables ?? new Dictionary<string, object>()
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/jobs/{jobKey}/completion", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to complete job: {responseString}");
    }

    // ===================== متدهای جدید =====================

    /// <summary>
    /// دریافت اطلاعات یک Process Instance خاص
    /// </summary>
    public async Task<ProcessInstance> GetProcessInstanceAsync(string processInstanceKey)
    {
        var url = $"{_baseUrl}/v2/process-instances/{processInstanceKey}";

        var response = await _httpClient.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get process instance: {responseString}");

        return JsonSerializer.Deserialize<ProcessInstance>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    /// <summary>
    /// لغو/پایان دادن یک Process Instance
    /// </summary>
    public async Task CancelProcessInstanceAsync(string processInstanceKey, string reason = null)
    {
        var request = new
        {
            reason = reason ?? "Cancelled by user"
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/process-instances/{processInstanceKey}/cancel", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to cancel process: {responseString}");
    }

    /// <summary>
    /// دریافت تاریخچه فعالیت‌های یک Process Instance
    /// </summary>
    public async Task<List<Activity>> GetProcessActivitiesAsync(string processInstanceKey)
    {
        var url = $"{_baseUrl}/v2/process-instances/{processInstanceKey}/activities";

        var response = await _httpClient.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get activities: {responseString}");

        return JsonSerializer.Deserialize<List<Activity>>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    /// <summary>
    /// ارسال سیگنال به یک Process Instance
    /// </summary>
    public async Task SendSignalAsync(string signalName, Dictionary<string, object> variables = null)
    {
        var request = new
        {
            signalName = signalName,
            variables = variables ?? new Dictionary<string, object>()
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/signals", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to send signal: {responseString}");
    }

    /// <summary>
    /// دریافت لیست Job های یک Process Instance
    /// </summary>
    public async Task<JobListResponse> GetProcessJobsAsync(string processInstanceKey, string jobType = null)
    {
        var url = $"{_baseUrl}/v2/jobs/search";

        var filter = new Dictionary<string, object>
        {
            ["processInstanceKey"] = processInstanceKey
        };

        if (!string.IsNullOrEmpty(jobType))
            filter["type"] = jobType;

        var requestBody = new
        {
            filter = filter
        };

        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get jobs: {responseString}");

        return JsonSerializer.Deserialize<JobListResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    /// <summary>
    /// Fail کردن یک Job (با امکان Retry)
    /// </summary>
    public async Task FailJobAsync(string jobKey, string errorMessage, int retries = 0)
    {
        var request = new
        {
            errorMessage = errorMessage,
            retries = retries
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/jobs/{jobKey}/fail", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to fail job: {responseString}");
    }

    /// <summary>
    /// دریافت متغیر خاص از یک Process Instance
    /// </summary>
    public async Task<Variable> GetVariableAsync(string processInstanceKey, string variableName)
    {
        var url = $"{_baseUrl}/v2/variables/search";

        var requestBody = new
        {
            filter = new
            {
                processInstanceKey = processInstanceKey,
                name = variableName
            }
        };

        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get variable: {responseString}");

        var result = JsonSerializer.Deserialize<VariableListResponse>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return result?.Items?.FirstOrDefault();
    }

    /// <summary>
    /// به‌روزرسانی متغیرهای یک Process Instance
    /// </summary>
    public async Task UpdateVariablesAsync(string processInstanceKey, Dictionary<string, object> variables)
    {
        var request = new
        {
            variables = variables
        };

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{_baseUrl}/v2/process-instances/{processInstanceKey}/variables", content);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to update variables: {responseString}");
    }

    /// <summary>
    /// دریافت لیست Process Definition ها
    /// </summary>
    public async Task<List<ProcessDefinition>> GetProcessDefinitionsAsync()
    {
        var url = $"{_baseUrl}/v2/process-definitions";

        var response = await _httpClient.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get process definitions: {responseString}");

        return JsonSerializer.Deserialize<List<ProcessDefinition>>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    /// <summary>
    /// دریافت یک Process Definition خاص
    /// </summary>
    public async Task<ProcessDefinition> GetProcessDefinitionAsync(string processDefinitionId)
    {
        var url = $"{_baseUrl}/v2/process-definitions/{processDefinitionId}";

        var response = await _httpClient.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Failed to get process definition: {responseString}");

        return JsonSerializer.Deserialize<ProcessDefinition>(responseString,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    /// <summary>
    /// منتظر ماندن برای تکمیل یک Job (Polling)
    /// </summary>
    public async Task WaitForJobCompletionAsync(string jobKey, int timeoutSeconds = 30)
    {
        var startTime = DateTime.Now;
        var timeout = TimeSpan.FromSeconds(timeoutSeconds);

        while (DateTime.Now - startTime < timeout)
        {
            try
            {
                // بررسی وضعیت Job
                var jobs = await GetProcessJobsAsync(jobKey);
                if (jobs?.Jobs == null || !jobs.Jobs.Any())
                {
                    await Task.Delay(1000);
                    continue;
                }

                var job = jobs.Jobs.FirstOrDefault();
                if (job == null)
                {
                    await Task.Delay(1000);
                    continue;
                }

                // اگر Job کامل شده باشد
                return;
            }
            catch
            {
                await Task.Delay(1000);
            }
        }

        throw new TimeoutException($"Job {jobKey} not completed within {timeoutSeconds} seconds");
    }
}

// ===================== مدل‌های جدید =====================

