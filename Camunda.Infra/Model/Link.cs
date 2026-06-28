using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class Link
{
    [JsonProperty("method")] public string Method { get; set; }

    [JsonProperty("href\"")] public Uri Href { get; set; }

    [JsonProperty("rel")] public string Rel { get; set; }
}