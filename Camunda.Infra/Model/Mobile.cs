using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Mobile
{
    [JsonProperty("value")] public string Value { get; set; }

    [JsonProperty("type")] public string Type { get; set; }
}