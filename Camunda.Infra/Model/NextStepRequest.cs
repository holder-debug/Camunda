using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class NextStepRequest
{
    [JsonProperty("skipCustomListeners")] public bool SkipCustomListeners { get; set; }

    [JsonProperty("skipIoMappings")] public bool SkipIoMappings { get; set; }

    [JsonProperty("instructions")] public Instruction[] Instructions { get; set; }

    [JsonProperty("annotation")] public string Annotation { get; set; }

    [JsonProperty("transitionId")] public string TransitionId { get; set; }
}