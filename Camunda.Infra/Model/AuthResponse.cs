using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class AuthResponse
{
    [JsonProperty("id")] public string? Id { get; set; }

    [JsonProperty("type")] public int? Type { get; set; }

    [JsonProperty("permissions")] public string?[] Permissions { get; set; }

    [JsonProperty("userId")] public string? UserId { get; set; }

    [JsonProperty("groupId")] public string? GroupId { get; set; }

    [JsonProperty("resourceType")] public int? ResourceType { get; set; }

    [JsonProperty("resourceId")] public string? ResourceId { get; set; }

    [JsonProperty("removalTime")] public string? RemovalTime { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public string? RootProcessInstanceId { get; set; }

    [JsonProperty("links")] public Link[] Links { get; set; }
}