 

//// ============================================================
////  Camunda 8.9 – Orchestration Cluster REST API
////  Response Models for C#
////  Generated based on official OpenAPI spec (8.9)
////  Namespace: Camunda.Api.Models
//// ============================================================

//using System.Text.Json.Serialization;

using System.Text.Json.Serialization;

namespace Camunda.Infra.Models
{
//    // ─────────────────────────────────────────────
//    // ENUMS
//    // ─────────────────────────────────────────────

    [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProcessInstanceState
    {
        ACTIVE,
        COMPLETED,
        CANCELED,
        INCIDENT
    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum UserTaskState
    //    {
    //        CREATED,
    //        COMPLETED,
    //        CANCELED,
    //        FAILED
    //    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JobState
    {
        ACTIVATABLE,
        ACTIVE,
        FAILED,
        ERROR_THROWN,
        COMPLETED,
        CANCELED
    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum IncidentState
    //    {
    //        ACTIVE,
    //        RESOLVED,
    //        MIGRATED,
    //        PENDING
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum IncidentErrorType
    //    {
    //        UNSPECIFIED,
    //        UNKNOWN,
    //        IO_MAPPING_ERROR,
    //        JOB_NO_RETRIES,
    //        EXECUTION_LISTENER_NO_RETRIES,
    //        CONDITION_ERROR,
    //        EXTRACT_VALUE_ERROR,
    //        CALLED_ELEMENT_ERROR,
    //        UNHANDLED_ERROR_EVENT,
    //        MESSAGE_SIZE_EXCEEDED,
    //        CALLED_DECISION_ERROR,
    //        DECISION_EVALUATION_ERROR,
    //        FORM_NOT_FOUND
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum FlowNodeInstanceState
    //    {
    //        ACTIVE,
    //        COMPLETED,
    //        TERMINATED,
    //        FAILED
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum FlowNodeType
    //    {
    //        UNSPECIFIED,
    //        PROCESS,
    //        SUB_PROCESS,
    //        EVENT_SUB_PROCESS,
    //        START_EVENT,
    //        INTERMEDIATE_CATCH_EVENT,
    //        INTERMEDIATE_THROW_EVENT,
    //        BOUNDARY_EVENT,
    //        END_EVENT,
    //        SERVICE_TASK,
    //        RECEIVE_TASK,
    //        USER_TASK,
    //        MANUAL_TASK,
    //        TASK,
    //        EXCLUSIVE_GATEWAY,
    //        INCLUSIVE_GATEWAY,
    //        PARALLEL_GATEWAY,
    //        EVENT_BASED_GATEWAY,
    //        SEQUENCE_FLOW,
    //        MULTI_INSTANCE_BODY,
    //        CALL_ACTIVITY,
    //        BUSINESS_RULE_TASK,
    //        SCRIPT_TASK,
    //        SEND_TASK,
    //        UNKNOWN
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum VariableValueType
    //    {
    //        String,
    //        Number,
    //        Boolean,
    //        Object,
    //        Array,
    //        Null
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum BatchOperationState
    //    {
    //        CREATED,
    //        ACTIVE,
    //        COMPLETED,
    //        FAILED,
    //        CANCELED
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum BatchOperationType
    //    {
    //        CANCEL_PROCESS_INSTANCE,
    //        DELETE_PROCESS_INSTANCE,
    //        MIGRATE_PROCESS_INSTANCE,
    //        MODIFY_PROCESS_INSTANCE,
    //        RESOLVE_INCIDENT
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum MessageCorrelationResultType
    //    {
    //        MessageCorrelated,
    //        AlreadyCorrelated,
    //        NotCorrelated
    //    }

    //    [JsonConverter(typeof(JsonStringEnumConverter))]
    //    public enum SortOrder
    //    {
    //        ASC,
    //        DESC
    //    }


    //    // ─────────────────────────────────────────────
    //    // COMMON / SHARED
    //    // ─────────────────────────────────────────────

    //    /// <summary>
    //    /// خطای استاندارد API – برگشت می‌دهد وقتی درخواست موفق نیست
    //    /// </summary>
    //    public class ProblemDetail
    //    {
    //        [JsonPropertyName("status")]
    //        public int? Status { get; set; }

    //        [JsonPropertyName("title")]
    //        public string? Title { get; set; }

    //        [JsonPropertyName("detail")]
    //        public string? Detail { get; set; }

    //        [JsonPropertyName("instance")]
    //        public string? Instance { get; set; }

    //        [JsonPropertyName("type")]
    //        public string? Type { get; set; }
    //    }

    //    /// <summary>
    //    /// اطلاعات صفحه‌بندی در پاسخ‌های جستجو
    //    /// </summary>
    //    public class SearchQueryPageResponse
    //    {
    //        [JsonPropertyName("totalItems")]
    //        public long? TotalItems { get; set; }

    //        [JsonPropertyName("firstSortValues")]
    //        public List<object>? FirstSortValues { get; set; }

    //        [JsonPropertyName("lastSortValues")]
    //        public List<object>? LastSortValues { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // TOPOLOGY
    //    // ─────────────────────────────────────────────

    //    public class TopologyResponse
    //    {
    //        [JsonPropertyName("brokers")]
    //        public List<BrokerInfo>? Brokers { get; set; }

    //        [JsonPropertyName("clusterSize")]
    //        public int? ClusterSize { get; set; }

    //        [JsonPropertyName("partitionsCount")]
    //        public int? PartitionsCount { get; set; }

    //        [JsonPropertyName("replicationFactor")]
    //        public int? ReplicationFactor { get; set; }

    //        [JsonPropertyName("gatewayVersion")]
    //        public string? GatewayVersion { get; set; }
    //    }

    //    public class BrokerInfo
    //    {
    //        [JsonPropertyName("nodeId")]
    //        public int? NodeId { get; set; }

    //        [JsonPropertyName("host")]
    //        public string? Host { get; set; }

    //        [JsonPropertyName("port")]
    //        public int? Port { get; set; }

    //        [JsonPropertyName("partitions")]
    //        public List<PartitionInfo>? Partitions { get; set; }

    //        [JsonPropertyName("version")]
    //        public string? Version { get; set; }
    //    }

    //    public class PartitionInfo
    //    {
    //        [JsonPropertyName("partitionId")]
    //        public int? PartitionId { get; set; }

    //        [JsonPropertyName("role")]
    //        public string? Role { get; set; }

    //        [JsonPropertyName("health")]
    //        public string? Health { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // PROCESS DEFINITION
    //    // ─────────────────────────────────────────────

    //    public class ProcessDefinitionResult
    //    {
    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("version")]
    //        public int? Version { get; set; }

    //        [JsonPropertyName("versionTag")]
    //        public string? VersionTag { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("resourceName")]
    //        public string? ResourceName { get; set; }
    //    }

    //    public class ProcessDefinitionSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<ProcessDefinitionResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // DEPLOYMENT
    //    // ─────────────────────────────────────────────

    //    public class DeploymentResponse
    //    {
    //        [JsonPropertyName("deploymentKey")]
    //        public string? DeploymentKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("deployments")]
    //        public List<DeployedResourceResult>? Deployments { get; set; }
    //    }

    //    public class DeployedResourceResult
    //    {
    //        [JsonPropertyName("processDefinition")]
    //        public ProcessDefinitionResult? ProcessDefinition { get; set; }

    //        [JsonPropertyName("decision")]
    //        public DecisionDefinitionResult? Decision { get; set; }

    //        [JsonPropertyName("decisionRequirements")]
    //        public DecisionRequirementsResult? DecisionRequirements { get; set; }

    //        [JsonPropertyName("form")]
    //        public FormResult? Form { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // PROCESS INSTANCE
    //    // ─────────────────────────────────────────────

    public class ProcessInstanceResult
    {
        [JsonPropertyName("processInstanceKey")]
        public string? ProcessInstanceKey { get; set; }

        [JsonPropertyName("processDefinitionKey")]
        public string? ProcessDefinitionKey { get; set; }

        [JsonPropertyName("processDefinitionId")]
        public string? ProcessDefinitionId { get; set; }

        [JsonPropertyName("processDefinitionVersion")]
        public int? ProcessDefinitionVersion { get; set; }

        [JsonPropertyName("processDefinitionVersionTag")]
        public string? ProcessDefinitionVersionTag { get; set; }

        [JsonPropertyName("processDefinitionName")]
        public string? ProcessDefinitionName { get; set; }

        [JsonPropertyName("rootProcessInstanceKey")]
        public string? RootProcessInstanceKey { get; set; }

        [JsonPropertyName("parentProcessInstanceKey")]
        public string? ParentProcessInstanceKey { get; set; }

        [JsonPropertyName("parentFlowNodeInstanceKey")]
        public string? ParentFlowNodeInstanceKey { get; set; }

        [JsonPropertyName("startDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonPropertyName("state")]
        public ProcessInstanceState? State { get; set; }

        [JsonPropertyName("hasIncident")]
        public bool? HasIncident { get; set; }

        [JsonPropertyName("tenantId")]
        public string? TenantId { get; set; }
    }

    //    public class CreateProcessInstanceResponse
    //    {
    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processDefinitionVersion")]
    //        public int? ProcessDefinitionVersion { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class ProcessInstanceSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<ProcessInstanceResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // FLOW NODE INSTANCE
    //    // ─────────────────────────────────────────────

    //    public class FlowNodeInstanceResult
    //    {
    //        [JsonPropertyName("flowNodeInstanceKey")]
    //        public string? FlowNodeInstanceKey { get; set; }

    //        [JsonPropertyName("flowNodeId")]
    //        public string? FlowNodeId { get; set; }

    //        [JsonPropertyName("flowNodeName")]
    //        public string? FlowNodeName { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("startDate")]
    //        public DateTimeOffset? StartDate { get; set; }

    //        [JsonPropertyName("endDate")]
    //        public DateTimeOffset? EndDate { get; set; }

    //        [JsonPropertyName("state")]
    //        public FlowNodeInstanceState? State { get; set; }

    //        [JsonPropertyName("type")]
    //        public FlowNodeType? Type { get; set; }

    //        [JsonPropertyName("incidentKey")]
    //        public string? IncidentKey { get; set; }

    //        [JsonPropertyName("hasIncident")]
    //        public bool? HasIncident { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("treePath")]
    //        public string? TreePath { get; set; }
    //    }

    //    public class FlowNodeInstanceSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<FlowNodeInstanceResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // USER TASK
    //    // ─────────────────────────────────────────────

    //    public class UserTaskResult
    //    {
    //        [JsonPropertyName("userTaskKey")]
    //        public string? UserTaskKey { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("elementId")]
    //        public string? ElementId { get; set; }

    //        [JsonPropertyName("elementInstanceKey")]
    //        public string? ElementInstanceKey { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processDefinitionVersion")]
    //        public int? ProcessDefinitionVersion { get; set; }

    //        [JsonPropertyName("formKey")]
    //        public string? FormKey { get; set; }

    //        [JsonPropertyName("state")]
    //        public UserTaskState? State { get; set; }

    //        [JsonPropertyName("assignee")]
    //        public string? Assignee { get; set; }

    //        [JsonPropertyName("candidateGroups")]
    //        public List<string>? CandidateGroups { get; set; }

    //        [JsonPropertyName("candidateUsers")]
    //        public List<string>? CandidateUsers { get; set; }

    //        [JsonPropertyName("dueDate")]
    //        public DateTimeOffset? DueDate { get; set; }

    //        [JsonPropertyName("followUpDate")]
    //        public DateTimeOffset? FollowUpDate { get; set; }

    //        [JsonPropertyName("creationDate")]
    //        public DateTimeOffset? CreationDate { get; set; }

    //        [JsonPropertyName("completionDate")]
    //        public DateTimeOffset? CompletionDate { get; set; }

    //        [JsonPropertyName("priority")]
    //        public int? Priority { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("externalFormReference")]
    //        public string? ExternalFormReference { get; set; }

    //        [JsonPropertyName("customHeaders")]
    //        public Dictionary<string, string>? CustomHeaders { get; set; }

    //        [JsonPropertyName("changedAttributes")]
    //        public List<string>? ChangedAttributes { get; set; }
    //    }

    //    public class UserTaskSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<UserTaskResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // VARIABLE
    //    // ─────────────────────────────────────────────

    //    public class VariableResult
    //    {
    //        [JsonPropertyName("variableKey")]
    //        public string? VariableKey { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("value")]
    //        public string? Value { get; set; }

    //        [JsonPropertyName("isPreview")]
    //        public bool? IsPreview { get; set; }

    //        [JsonPropertyName("fullValue")]
    //        public string? FullValue { get; set; }

    //        [JsonPropertyName("scopeKey")]
    //        public string? ScopeKey { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class VariableSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<VariableResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // JOB
    //    // ─────────────────────────────────────────────

    //    public class JobResult
    //    {
    //        [JsonPropertyName("jobKey")]
    //        public string? JobKey { get; set; }

    //        [JsonPropertyName("type")]
    //        public string? Type { get; set; }

    //        [JsonPropertyName("jobKind")]
    //        public string? JobKind { get; set; }

    //        [JsonPropertyName("listenerEventType")]
    //        public string? ListenerEventType { get; set; }

    //        [JsonPropertyName("state")]
    //        public JobState? State { get; set; }

    //        [JsonPropertyName("retries")]
    //        public int? Retries { get; set; }

    //        [JsonPropertyName("isDenied")]
    //        public bool? IsDenied { get; set; }

    //        [JsonPropertyName("deniedReason")]
    //        public string? DeniedReason { get; set; }

    //        [JsonPropertyName("worker")]
    //        public string? Worker { get; set; }

    //        [JsonPropertyName("deadline")]
    //        public DateTimeOffset? Deadline { get; set; }

    //        [JsonPropertyName("endDate")]
    //        public DateTimeOffset? EndDate { get; set; }

    //        [JsonPropertyName("errorMessage")]
    //        public string? ErrorMessage { get; set; }

    //        [JsonPropertyName("errorCode")]
    //        public string? ErrorCode { get; set; }

    //        [JsonPropertyName("customHeaders")]
    //        public Dictionary<string, string>? CustomHeaders { get; set; }

    //        [JsonPropertyName("elementId")]
    //        public string? ElementId { get; set; }

    //        [JsonPropertyName("elementInstanceKey")]
    //        public string? ElementInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processDefinitionVersion")]
    //        public int? ProcessDefinitionVersion { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class JobActivationResult
    //    {
    //        [JsonPropertyName("jobs")]
    //        public List<ActivatedJobResult>? Jobs { get; set; }
    //    }

    //    public class ActivatedJobResult
    //    {
    //        [JsonPropertyName("jobKey")]
    //        public string? JobKey { get; set; }

    //        [JsonPropertyName("type")]
    //        public string? Type { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("elementId")]
    //        public string? ElementId { get; set; }

    //        [JsonPropertyName("elementInstanceKey")]
    //        public string? ElementInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processDefinitionVersion")]
    //        public int? ProcessDefinitionVersion { get; set; }

    //        [JsonPropertyName("retries")]
    //        public int? Retries { get; set; }

    //        [JsonPropertyName("deadline")]
    //        public long? Deadline { get; set; }

    //        [JsonPropertyName("worker")]
    //        public string? Worker { get; set; }

    //        [JsonPropertyName("customHeaders")]
    //        public Dictionary<string, string>? CustomHeaders { get; set; }

    //        [JsonPropertyName("variables")]
    //        public Dictionary<string, object>? Variables { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class JobSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<JobResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // INCIDENT
    //    // ─────────────────────────────────────────────

    //    public class IncidentResult
    //    {
    //        [JsonPropertyName("incidentKey")]
    //        public string? IncidentKey { get; set; }

    //        [JsonPropertyName("errorType")]
    //        public IncidentErrorType? ErrorType { get; set; }

    //        [JsonPropertyName("errorMessage")]
    //        public string? ErrorMessage { get; set; }

    //        [JsonPropertyName("state")]
    //        public IncidentState? State { get; set; }

    //        [JsonPropertyName("flowNodeId")]
    //        public string? FlowNodeId { get; set; }

    //        [JsonPropertyName("flowNodeInstanceKey")]
    //        public string? FlowNodeInstanceKey { get; set; }

    //        [JsonPropertyName("jobKey")]
    //        public string? JobKey { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("creationDate")]
    //        public DateTimeOffset? CreationDate { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class IncidentSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<IncidentResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // MESSAGE CORRELATION
    //    // ─────────────────────────────────────────────

    //    public class CorrelateMessageResponse
    //    {
    //        [JsonPropertyName("messageKey")]
    //        public string? MessageKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class MessageCorrelationResult
    //    {
    //        [JsonPropertyName("correlationResultType")]
    //        public MessageCorrelationResultType? CorrelationResultType { get; set; }

    //        [JsonPropertyName("processInstance")]
    //        public ProcessInstanceResult? ProcessInstance { get; set; }
    //    }

    //    public class MessageSubscriptionResult
    //    {
    //        [JsonPropertyName("messageSubscriptionKey")]
    //        public string? MessageSubscriptionKey { get; set; }

    //        [JsonPropertyName("messageName")]
    //        public string? MessageName { get; set; }

    //        [JsonPropertyName("correlationKey")]
    //        public string? CorrelationKey { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("elementId")]
    //        public string? ElementId { get; set; }

    //        [JsonPropertyName("elementInstanceKey")]
    //        public string? ElementInstanceKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("messageKey")]
    //        public string? MessageKey { get; set; }
    //    }

    //    public class MessageSubscriptionSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<MessageSubscriptionResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // SIGNAL
    //    // ─────────────────────────────────────────────

    //    public class BroadcastSignalResponse
    //    {
    //        [JsonPropertyName("signalKey")]
    //        public string? SignalKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // DECISION DEFINITION
    //    // ─────────────────────────────────────────────

    //    public class DecisionDefinitionResult
    //    {
    //        [JsonPropertyName("decisionDefinitionKey")]
    //        public string? DecisionDefinitionKey { get; set; }

    //        [JsonPropertyName("decisionDefinitionId")]
    //        public string? DecisionDefinitionId { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("version")]
    //        public int? Version { get; set; }

    //        [JsonPropertyName("versionTag")]
    //        public string? VersionTag { get; set; }

    //        [JsonPropertyName("decisionRequirementsKey")]
    //        public string? DecisionRequirementsKey { get; set; }

    //        [JsonPropertyName("decisionRequirementsId")]
    //        public string? DecisionRequirementsId { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class DecisionDefinitionSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<DecisionDefinitionResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }

    //    public class DecisionRequirementsResult
    //    {
    //        [JsonPropertyName("decisionRequirementsKey")]
    //        public string? DecisionRequirementsKey { get; set; }

    //        [JsonPropertyName("decisionRequirementsId")]
    //        public string? DecisionRequirementsId { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("version")]
    //        public int? Version { get; set; }

    //        [JsonPropertyName("resourceName")]
    //        public string? ResourceName { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class DecisionRequirementsSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<DecisionRequirementsResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // DECISION INSTANCE (Evaluate)
    //    // ─────────────────────────────────────────────

    //    public class EvaluateDecisionResponse
    //    {
    //        [JsonPropertyName("decisionDefinitionKey")]
    //        public string? DecisionDefinitionKey { get; set; }

    //        [JsonPropertyName("decisionDefinitionId")]
    //        public string? DecisionDefinitionId { get; set; }

    //        [JsonPropertyName("decisionDefinitionName")]
    //        public string? DecisionDefinitionName { get; set; }

    //        [JsonPropertyName("decisionDefinitionVersion")]
    //        public int? DecisionDefinitionVersion { get; set; }

    //        [JsonPropertyName("decisionRequirementsKey")]
    //        public string? DecisionRequirementsKey { get; set; }

    //        [JsonPropertyName("decisionRequirementsId")]
    //        public string? DecisionRequirementsId { get; set; }

    //        [JsonPropertyName("decisionInstanceKey")]
    //        public string? DecisionInstanceKey { get; set; }

    //        [JsonPropertyName("output")]
    //        public string? Output { get; set; }

    //        [JsonPropertyName("evaluatedDecisions")]
    //        public List<EvaluatedDecision>? EvaluatedDecisions { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("failedDecisionDefinitionId")]
    //        public string? FailedDecisionDefinitionId { get; set; }

    //        [JsonPropertyName("failureMessage")]
    //        public string? FailureMessage { get; set; }
    //    }

    //    public class EvaluatedDecision
    //    {
    //        [JsonPropertyName("decisionDefinitionKey")]
    //        public string? DecisionDefinitionKey { get; set; }

    //        [JsonPropertyName("decisionDefinitionId")]
    //        public string? DecisionDefinitionId { get; set; }

    //        [JsonPropertyName("decisionDefinitionName")]
    //        public string? DecisionDefinitionName { get; set; }

    //        [JsonPropertyName("decisionDefinitionVersion")]
    //        public int? DecisionDefinitionVersion { get; set; }

    //        [JsonPropertyName("decisionDefinitionType")]
    //        public string? DecisionDefinitionType { get; set; }

    //        [JsonPropertyName("output")]
    //        public string? Output { get; set; }

    //        [JsonPropertyName("matchedRules")]
    //        public List<MatchedDecisionRule>? MatchedRules { get; set; }

    //        [JsonPropertyName("evaluatedInputs")]
    //        public List<EvaluatedDecisionInput>? EvaluatedInputs { get; set; }
    //    }

    //    public class MatchedDecisionRule
    //    {
    //        [JsonPropertyName("ruleId")]
    //        public string? RuleId { get; set; }

    //        [JsonPropertyName("ruleIndex")]
    //        public int? RuleIndex { get; set; }

    //        [JsonPropertyName("evaluatedOutputs")]
    //        public List<EvaluatedDecisionOutput>? EvaluatedOutputs { get; set; }
    //    }

    //    public class EvaluatedDecisionInput
    //    {
    //        [JsonPropertyName("inputId")]
    //        public string? InputId { get; set; }

    //        [JsonPropertyName("inputName")]
    //        public string? InputName { get; set; }

    //        [JsonPropertyName("inputValue")]
    //        public string? InputValue { get; set; }
    //    }

    //    public class EvaluatedDecisionOutput
    //    {
    //        [JsonPropertyName("outputId")]
    //        public string? OutputId { get; set; }

    //        [JsonPropertyName("outputName")]
    //        public string? OutputName { get; set; }

    //        [JsonPropertyName("outputValue")]
    //        public string? OutputValue { get; set; }
    //    }

    //    public class DecisionInstanceResult
    //    {
    //        [JsonPropertyName("decisionInstanceKey")]
    //        public string? DecisionInstanceKey { get; set; }

    //        [JsonPropertyName("decisionInstanceId")]
    //        public string? DecisionInstanceId { get; set; }

    //        [JsonPropertyName("state")]
    //        public string? State { get; set; }

    //        [JsonPropertyName("evaluationDate")]
    //        public DateTimeOffset? EvaluationDate { get; set; }

    //        [JsonPropertyName("evaluationFailure")]
    //        public string? EvaluationFailure { get; set; }

    //        [JsonPropertyName("decisionDefinitionKey")]
    //        public string? DecisionDefinitionKey { get; set; }

    //        [JsonPropertyName("decisionDefinitionId")]
    //        public string? DecisionDefinitionId { get; set; }

    //        [JsonPropertyName("decisionDefinitionName")]
    //        public string? DecisionDefinitionName { get; set; }

    //        [JsonPropertyName("decisionDefinitionVersion")]
    //        public int? DecisionDefinitionVersion { get; set; }

    //        [JsonPropertyName("decisionDefinitionType")]
    //        public string? DecisionDefinitionType { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("elementInstanceKey")]
    //        public string? ElementInstanceKey { get; set; }

    //        [JsonPropertyName("result")]
    //        public string? Result { get; set; }

    //        [JsonPropertyName("evaluatedInputs")]
    //        public List<EvaluatedDecisionInput>? EvaluatedInputs { get; set; }

    //        [JsonPropertyName("matchedRules")]
    //        public List<MatchedDecisionRule>? MatchedRules { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }
    //    }

    //    public class DecisionInstanceSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<DecisionInstanceResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // BATCH OPERATION
    //    // ─────────────────────────────────────────────

    //    public class BatchOperationResult
    //    {
    //        [JsonPropertyName("batchOperationKey")]
    //        public string? BatchOperationKey { get; set; }

    //        [JsonPropertyName("type")]
    //        public BatchOperationType? Type { get; set; }

    //        [JsonPropertyName("state")]
    //        public BatchOperationState? State { get; set; }

    //        [JsonPropertyName("startDate")]
    //        public DateTimeOffset? StartDate { get; set; }

    //        [JsonPropertyName("endDate")]
    //        public DateTimeOffset? EndDate { get; set; }

    //        [JsonPropertyName("operationsTotalCount")]
    //        public int? OperationsTotalCount { get; set; }

    //        [JsonPropertyName("operationsFinishedCount")]
    //        public int? OperationsFinishedCount { get; set; }
    //    }

    //    public class BatchOperationSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<BatchOperationResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // DOCUMENT
    //    // ─────────────────────────────────────────────

    //    public class DocumentReferenceResponse
    //    {
    //        [JsonPropertyName("documentId")]
    //        public string? DocumentId { get; set; }

    //        [JsonPropertyName("storeId")]
    //        public string? StoreId { get; set; }

    //        [JsonPropertyName("contentHash")]
    //        public string? ContentHash { get; set; }

    //        [JsonPropertyName("metadata")]
    //        public DocumentMetadataResponse? Metadata { get; set; }
    //    }

    //    public class DocumentMetadataResponse
    //    {
    //        [JsonPropertyName("contentType")]
    //        public string? ContentType { get; set; }

    //        [JsonPropertyName("fileName")]
    //        public string? FileName { get; set; }

    //        [JsonPropertyName("expiresAt")]
    //        public DateTimeOffset? ExpiresAt { get; set; }

    //        [JsonPropertyName("size")]
    //        public long? Size { get; set; }

    //        [JsonPropertyName("processDefinitionId")]
    //        public string? ProcessDefinitionId { get; set; }

    //        [JsonPropertyName("processInstanceKey")]
    //        public string? ProcessInstanceKey { get; set; }

    //        [JsonPropertyName("customProperties")]
    //        public Dictionary<string, object>? CustomProperties { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // FORM
    //    // ─────────────────────────────────────────────

    //    public class FormResult
    //    {
    //        [JsonPropertyName("formKey")]
    //        public string? FormKey { get; set; }

    //        [JsonPropertyName("formId")]
    //        public string? FormId { get; set; }

    //        [JsonPropertyName("version")]
    //        public long? Version { get; set; }

    //        [JsonPropertyName("schema")]
    //        public string? Schema { get; set; }

    //        [JsonPropertyName("processDefinitionKey")]
    //        public string? ProcessDefinitionKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("isDeleted")]
    //        public bool? IsDeleted { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // USER / AUTHORIZATION
    //    // ─────────────────────────────────────────────

    //    public class UserResult
    //    {
    //        [JsonPropertyName("userKey")]
    //        public string? UserKey { get; set; }

    //        [JsonPropertyName("username")]
    //        public string? Username { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("email")]
    //        public string? Email { get; set; }
    //    }

    //    public class UserSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<UserResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }

    //    public class AuthorizationResult
    //    {
    //        [JsonPropertyName("authorizationKey")]
    //        public string? AuthorizationKey { get; set; }

    //        [JsonPropertyName("ownerType")]
    //        public string? OwnerType { get; set; }

    //        [JsonPropertyName("ownerKey")]
    //        public string? OwnerKey { get; set; }

    //        [JsonPropertyName("resourceType")]
    //        public string? ResourceType { get; set; }

    //        [JsonPropertyName("resourceIds")]
    //        public List<string>? ResourceIds { get; set; }

    //        [JsonPropertyName("permissions")]
    //        public List<string>? Permissions { get; set; }
    //    }

    //    public class AuthorizationSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<AuthorizationResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // GROUP / ROLE / TENANT / MAPPING RULE
    //    // ─────────────────────────────────────────────

    //    public class GroupResult
    //    {
    //        [JsonPropertyName("groupKey")]
    //        public string? GroupKey { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("description")]
    //        public string? Description { get; set; }
    //    }

    //    public class GroupSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<GroupResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }

    //    public class RoleResult
    //    {
    //        [JsonPropertyName("roleKey")]
    //        public string? RoleKey { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("description")]
    //        public string? Description { get; set; }
    //    }

    //    public class RoleSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<RoleResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }

    //    public class TenantResult
    //    {
    //        [JsonPropertyName("tenantKey")]
    //        public string? TenantKey { get; set; }

    //        [JsonPropertyName("tenantId")]
    //        public string? TenantId { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("description")]
    //        public string? Description { get; set; }
    //    }

    //    public class TenantSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<TenantResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }

    //    public class MappingRuleResult
    //    {
    //        [JsonPropertyName("mappingRuleKey")]
    //        public string? MappingRuleKey { get; set; }

    //        [JsonPropertyName("name")]
    //        public string? Name { get; set; }

    //        [JsonPropertyName("claimName")]
    //        public string? ClaimName { get; set; }

    //        [JsonPropertyName("claimValue")]
    //        public string? ClaimValue { get; set; }
    //    }

    //    public class MappingRuleSearchQueryResponse
    //    {
    //        [JsonPropertyName("items")]
    //        public List<MappingRuleResult>? Items { get; set; }

    //        [JsonPropertyName("page")]
    //        public SearchQueryPageResponse? Page { get; set; }
    //    }


    //    // ─────────────────────────────────────────────
    //    // CLOCK (برای محیط‌های test/dev)
    //    // ─────────────────────────────────────────────

    //    public class ClockPinResponse
    //    {
    //        [JsonPropertyName("instant")]
    //        public DateTimeOffset? Instant { get; set; }
    //    }
}