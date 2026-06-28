using Camunda.Infra.Model;

namespace Camunda.Infra.Interfaces;

public interface IAuthService
{
    Task<AuthResponse> GenerateTokenAsync(CancellationToken ct = default);
    Task<List<string>> GetTokensAsync(CancellationToken ct = default);
}