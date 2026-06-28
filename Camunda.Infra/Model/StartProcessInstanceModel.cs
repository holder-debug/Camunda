using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class StartProcessInstanceModel
{
    [JsonProperty("variables")] public StartProcessInstanceVariableModel Variables { get; set; }

    [JsonProperty("businessKey")] public string BusinessKey { get; set; }
}