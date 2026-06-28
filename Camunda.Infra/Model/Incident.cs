using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Incident
{
    [JsonProperty("id")] public Guid Id { get; set; }

    [JsonProperty("activityId")] public string ActivityId { get; set; }
}