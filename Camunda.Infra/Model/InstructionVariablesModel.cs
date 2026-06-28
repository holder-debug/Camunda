using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class InstructionVariablesModel
{
    [JsonProperty("var")] public Var Name { get; set; }

    [JsonProperty("varLocal")] public Var Mobile { get; set; }
}