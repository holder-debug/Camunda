using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Var
{
    [JsonProperty("value")] public string Value { get; set; }

    [JsonProperty("local")] public bool Local { get; set; }

    [JsonProperty("type")] public string Type { get; set; }
}