using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class GetTokenResponse
{
    [JsonProperty("id")] public Guid Id { get; set; }

    [JsonProperty("type")] public long Type { get; set; }

    [JsonProperty("permissions")] public string[] Permissions { get; set; }

    [JsonProperty("userId")] public string UserId { get; set; }

    [JsonProperty("groupId")] public object GroupId { get; set; }

    [JsonProperty("resourceType")] public long ResourceType { get; set; }

    [JsonProperty("resourceId")] public string ResourceId { get; set; }

    [JsonProperty("removalTime")] public object RemovalTime { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public object RootProcessInstanceId { get; set; }
}