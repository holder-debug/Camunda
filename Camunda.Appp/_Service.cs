using System.Text;
using System.Text.Json;

namespace Camunda.Appp;

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

        // ساخت body ساده
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
}
