using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class StartProcessInstanceVariableModel
{
    [JsonProperty("aVariable")] public Mobile Mobile { get; set; }

    [JsonProperty("anotherVariable")] public Name Name { get; set; }
}