using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Instruction
{
    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("activityId", NullValueHandling = NullValueHandling.Ignore)]
    public string ActivityId { get; set; }

    [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
    public InstructionVariablesModel Variables { get; set; }

    [JsonProperty("activityInstanceId", NullValueHandling = NullValueHandling.Ignore)]
    public string ActivityInstanceId { get; set; }
}