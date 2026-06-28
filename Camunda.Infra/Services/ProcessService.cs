using System.Net.Http.Json;
using Camunda.Infra.Interfaces;
using Camunda.Infra.Model;
using Newtonsoft.Json;

namespace Camunda.Infra.Services;

public class ProcessService : IProcessService
{
    private readonly HttpClient _httpClient;

    public ProcessService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<string>> GetAllProcessesAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync(
            "history/process-instance?sortBy=startTime&sortOrder=desc", ct);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(ct);
        var processes = JsonConvert.DeserializeObject<List<ProcessInfoData>>(content)
                        ?? new List<ProcessInfoData>();


        var result = new List<string> { $"Item Count = {processes.Count}" };
        result.AddRange(processes.Select(p => $"{p.Id}__*__{p.ProcessDefinitionId}"));
        return result;
    }

    public async Task<GetActivityInstanceResponse> GetProcessInfoAsync(string processInstanceId,
        CancellationToken ct = default)
    {
        var response = await _httpClient.GetAsync(
            $"process-instance/{processInstanceId}/activity-instances", ct);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(ct);
        return JsonConvert.DeserializeObject<GetActivityInstanceResponse>(content)
               ?? throw new Exception("اطلاعات پروسه یافت نشد");
    }

    public async Task StartProcessAsync(CancellationToken ct = default)
    {
        var start = new StartProcessInstanceModel
        {
            BusinessKey = "default",
            Variables = new StartProcessInstanceVariableModel
            {
                Name = new Name { Type = "long", Value = "0935" },
                Mobile = new Mobile { Type = "string", Value = "aliiiiii" }
            }
        };

        var response = await _httpClient.PostAsJsonAsync(
            "process-definition/key/TaskModelUniqueBpmnId/tenant-id/MyTenant/start", start, ct);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(ct);
        JsonConvert.DeserializeObject<NextStepResponse>(content);
    }

    public async Task DeleteProcessAsync(string processDefinitionId, CancellationToken ct = default)
    {
        var response = await _httpClient.DeleteAsync(
            $"process-definition/{processDefinitionId}?cascade=true&skipCustomListeners=true&skipIoMappings=true",
            ct);
        response.EnsureSuccessStatusCode();
    }
}