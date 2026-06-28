using Camunda.Infra.Model;

namespace Camunda.Infra.Interfaces;

public interface IStepService
{
    Task<NextStepResponse> StepAAsync(string processInstanceId, GetActivityInstanceResponse processInfo,
        CancellationToken ct = default);
}