using Camunda.Infra.Interfaces;
using Camunda.Infra.Model;
using Newtonsoft.Json;

namespace Camunda.Infra.Services;

public class WorkflowService : IWorkflowService
{
    private readonly HttpClient _httpClient;

    public WorkflowService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<string>> GetAllWorkflowListAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync("process-definition", ct);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(ct);
        var workFlows = JsonConvert.DeserializeObject<List<WorkFlow>>(content)
                        ?? throw new Exception("پاسخ دریافتی خالی است");


        return workFlows
            .Select(w => $"flow id is {w.Id} key is {w.Key} name is {w.Name}")
            .ToList();
    }
}