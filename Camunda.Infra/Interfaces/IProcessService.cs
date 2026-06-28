using Camunda.Infra.Model;

namespace Camunda.Infra.Interfaces;

public interface IProcessService
{
    Task<List<string>> GetAllProcessesAsync(CancellationToken ct = default);
    Task<GetActivityInstanceResponse> GetProcessInfoAsync(string processInstanceId, CancellationToken ct = default);
    Task StartProcessAsync(CancellationToken ct = default);
    Task DeleteProcessAsync(string processDefinitionId, CancellationToken ct = default);
}