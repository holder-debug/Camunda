using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Model
{
    [JsonProperty("type")] public int? Type { get; set; }

    [JsonProperty("permissions")] public string?[] Permissions { get; set; }

    [JsonProperty("userId")] public string? UserId { get; set; }

    [JsonProperty("groupId")] public string? GroupId { get; set; }

    [JsonProperty("resourceType")] public int? ResourceType { get; set; }

    [JsonProperty("resourceId")] public string? ResourceId { get; set; }
}