using System.Net;
using System.Net.Http.Json;
using Camunda.Infra.Interfaces;
using Camunda.Infra.Model;
using Newtonsoft.Json;

namespace Camunda.Infra.Services;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AuthResponse> GenerateTokenAsync(CancellationToken ct = default)
    {
        var model = new Model.Model
        {
            Type = 0,
            GroupId = null,
            ResourceId = "*",
            ResourceType = 1,
            UserId = "*",
            Permissions = new[] { "CREATE", "READ" }
        };

        var response = await _httpClient.PostAsJsonAsync("authorization/create", model, ct);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync(ct);
            return JsonConvert.DeserializeObject<AuthResponse>(content)
                   ?? throw new Exception("پاسخ دریافتی خالی است");
        }

        if (response.StatusCode == HttpStatusCode.InternalServerError)
            throw new Exception("توکن وجود دارد");

        throw new Exception($"HTTP error: {response.StatusCode}");
    }

    public async Task<List<string>> GetTokensAsync(CancellationToken ct = default)
    {
        var response = await _httpClient.GetStringAsync("authorization?type=0", ct);
        var tokens = JsonConvert.DeserializeObject<List<GetTokenResponse>>(response)
                     ?? new List<GetTokenResponse>();


        return tokens.Select(item =>
        {
            var permissions = string.Join(" ", item.Permissions);
            return $"Id {item.Id} | GroupId {item.GroupId} | Type {item.Type} | " +
                   $"UserId {item.UserId} | ResourceType {item.ResourceType} | " +
                   $"ResourceId {item.ResourceId} | Permissions {permissions}";
        }).ToList();
    }
}