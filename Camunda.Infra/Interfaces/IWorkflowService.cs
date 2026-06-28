namespace Camunda.Infra.Interfaces;

public interface IWorkflowService
{
    Task<List<string>> GetAllWorkflowListAsync(CancellationToken ct = default);
}