using Newtonsoft.Json;

namespace Camunda.Infra.Model;

public class ProcessInfoData
{
    [JsonProperty("id")] public Guid Id { get; set; }

    [JsonProperty("businessKey")] public object BusinessKey { get; set; }

    [JsonProperty("processDefinitionId")] public string ProcessDefinitionId { get; set; }

    [JsonProperty("processDefinitionKey")] public string ProcessDefinitionKey { get; set; }

    [JsonProperty("processDefinitionName")]
    public string ProcessDefinitionName { get; set; }

    [JsonProperty("processDefinitionVersion")]
    public long ProcessDefinitionVersion { get; set; }

    [JsonProperty("startTime")] public string StartTime { get; set; }

    [JsonProperty("endTime")] public object EndTime { get; set; }

    [JsonProperty("removalTime")] public object RemovalTime { get; set; }

    [JsonProperty("durationInMillis")] public object DurationInMillis { get; set; }

    [JsonProperty("startUserId")] public object StartUserId { get; set; }

    [JsonProperty("startActivityId")] public string StartActivityId { get; set; }

    [JsonProperty("deleteReason")] public object DeleteReason { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public Guid RootProcessInstanceId { get; set; }

    [JsonProperty("superProcessInstanceId")]
    public object SuperProcessInstanceId { get; set; }

    [JsonProperty("superCaseInstanceId")] public object SuperCaseInstanceId { get; set; }

    [JsonProperty("caseInstanceId")] public object CaseInstanceId { get; set; }

    [JsonProperty("tenantId")] public object TenantId { get; set; }

    [JsonProperty("state")] public string State { get; set; }
}