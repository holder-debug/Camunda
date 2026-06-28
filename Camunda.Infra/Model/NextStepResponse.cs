using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class NextStepResponse
{
    [JsonProperty("type")] public string? Type { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("code")] public int? Code { get; set; }
}