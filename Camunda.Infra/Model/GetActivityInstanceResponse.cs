using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class GetActivityInstanceResponse
{
    [JsonProperty("id")] public string Id { get; set; }

    [JsonProperty("parentActivityInstanceId")]
    public Guid? ParentActivityInstanceId { get; set; }

    [JsonProperty("activityId")] public string ActivityId { get; set; }

    [JsonProperty("activityType")] public string ActivityType { get; set; }

    [JsonProperty("processInstanceId")] public Guid ProcessInstanceId { get; set; }

    [JsonProperty("processDefinitionId")] public string ProcessDefinitionId { get; set; }

    [JsonProperty("childActivityInstances")]
    public GetActivityInstanceResponse[] ChildActivityInstances { get; set; }

    [JsonProperty("childTransitionInstances")]
    public object[] ChildTransitionInstances { get; set; }

    [JsonProperty("executionIds")] public Guid[] ExecutionIds { get; set; }

    [JsonProperty("activityName")] public string ActivityName { get; set; }

    [JsonProperty("incidentIds")] public Guid[] IncidentIds { get; set; }

    [JsonProperty("incidents")] public Incident[] Incidents { get; set; }

    [JsonProperty("name")] public string Name { get; set; }
}