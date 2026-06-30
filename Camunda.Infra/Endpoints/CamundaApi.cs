// ============================================================
//  Camunda 8.9 – Orchestration Cluster REST API
//  Endpoint Constants
// ============================================================

namespace Camunda.Infra.Endpoints
{
    public static class CamundaApi
    {
        // ── Topology ─────────────────────────────────────────
        public const string Topology = "v2/topology";

        // ── Process Definitions ───────────────────────────────
        public const string ProcessDefinitions = "v2/process-definitions";
        public const string ProcessDefinitionByKey = "v2/process-definitions/{0}";
        public const string ProcessDefinitionXml = "v2/process-definitions/{0}/xml";
        public const string ProcessDefinitionSearch = "v2/process-definitions/search";

        // ── Deployments ───────────────────────────────────────
        public const string Deployments = "v2/deployments";
        public const string DeploymentByKey = "v2/deployments/{0}";
        public const string DeploymentDelete = "v2/deployments/{0}";

        // ── Process Instances ─────────────────────────────────
        public const string ProcessInstances = "v2/process-instances";
        public const string ProcessInstanceByKey = "v2/process-instances/{0}";
        public const string ProcessInstanceSearch = "v2/process-instances/search";
        public const string ProcessInstanceCancel = "v2/process-instances/{0}/cancellation";
        public const string ProcessInstanceMigrate = "v2/process-instances/{0}/migration";
        public const string ProcessInstanceModify = "v2/process-instances/{0}/modification";
        public const string ProcessInstanceVariables = "v2/process-instances/{0}/variables";
        public const string ProcessInstanceVariableSearch = "v2/process-instances/{0}/variables/search";
        public const string ProcessInstanceFlowNodeInstances = "v2/process-instances/{0}/flow-node-instances";
        public const string ProcessInstanceFlowNodeSearch = "v2/process-instances/{0}/flow-node-instances/search";
        public const string ProcessInstanceIncidents = "v2/process-instances/{0}/incidents";
        public const string ProcessInstanceIncidentSearch = "v2/process-instances/{0}/incidents/search";
        public const string ProcessInstanceResolveIncidents = "v2/process-instances/{0}/incidents/resolution";
        public const string ProcessInstanceDelete = "v2/process-instances/{0}";
        public const string ProcessInstanceDeleteBatch = "v2/process-instances/deletion";

        // ── Flow Node Instances ───────────────────────────────
        public const string FlowNodeInstances = "v2/flow-node-instances";
        public const string FlowNodeInstanceByKey = "v2/flow-node-instances/{0}";
        public const string FlowNodeInstanceSearch = "v2/flow-node-instances/search";

        // ── User Tasks ────────────────────────────────────────
        public const string UserTasks = "v2/user-tasks";
        public const string UserTaskByKey = "v2/user-tasks/{0}";
        public const string UserTaskSearch = "v2/user-tasks/search";
        public const string UserTaskAssign = "v2/user-tasks/{0}/assignment";
        public const string UserTaskUnassign = "v2/user-tasks/{0}/assignee";
        public const string UserTaskComplete = "v2/user-tasks/{0}/completion";
        public const string UserTaskUpdate = "v2/user-tasks/{0}";
        public const string UserTaskVariables = "v2/user-tasks/{0}/variables";
        public const string UserTaskVariableSearch = "v2/user-tasks/{0}/variables/search";
        public const string UserTaskForm = "v2/user-tasks/{0}/form";

        // ── Variables ─────────────────────────────────────────
        public const string Variables = "v2/variables";
        public const string VariableByKey = "v2/variables/{0}";
        public const string VariableSearch = "v2/variables/search";

        // ── Jobs ──────────────────────────────────────────────
        public const string Jobs = "v2/jobs";
        public const string JobByKey = "v2/jobs/{0}";
        public const string JobSearch = "v2/jobs/search";
        public const string JobActivate = "v2/jobs/activation";
        public const string JobComplete = "v2/jobs/{0}/completion";
        public const string JobFail = "v2/jobs/{0}/failure";
        public const string JobError = "v2/jobs/{0}/error";
        public const string JobUpdateRetries = "v2/jobs/{0}/retries";
        public const string JobUpdateTimeout = "v2/jobs/{0}/deadline";

        // ── Incidents ─────────────────────────────────────────
        public const string Incidents = "v2/incidents";
        public const string IncidentByKey = "v2/incidents/{0}";
        public const string IncidentSearch = "v2/incidents/search";
        public const string IncidentResolve = "v2/incidents/{0}/resolution";

        // ── Messages ──────────────────────────────────────────
        public const string MessagesCorrelate = "v2/messages/correlation";
        public const string MessagesPublish = "v2/messages/publication";
        public const string MessageSubscriptions = "v2/message-subscriptions";
        public const string MessageSubscriptionSearch = "v2/message-subscriptions/search";

        // ── Signals ───────────────────────────────────────────
        public const string SignalsBroadcast = "v2/signals/broadcast";

        // ── Decision Definitions ──────────────────────────────
        public const string DecisionDefinitions = "v2/decision-definitions";
        public const string DecisionDefinitionByKey = "v2/decision-definitions/{0}";
        public const string DecisionDefinitionSearch = "v2/decision-definitions/search";
        public const string DecisionDefinitionXml = "v2/decision-definitions/{0}/xml";

        // ── Decision Requirements ─────────────────────────────
        public const string DecisionRequirements = "v2/decision-requirements";
        public const string DecisionRequirementsByKey = "v2/decision-requirements/{0}";
        public const string DecisionRequirementsSearch = "v2/decision-requirements/search";
        public const string DecisionRequirementsXml = "v2/decision-requirements/{0}/xml";

        // ── Decision Instances ────────────────────────────────
        public const string DecisionInstances = "v2/decision-instances";
        public const string DecisionInstanceByKey = "v2/decision-instances/{0}";
        public const string DecisionInstanceSearch = "v2/decision-instances/search";
        public const string DecisionEvaluate = "v2/decisions/evaluation";

        // ── Batch Operations ──────────────────────────────────
        public const string BatchOperations = "v2/batch-operations";
        public const string BatchOperationByKey = "v2/batch-operations/{0}";
        public const string BatchOperationSearch = "v2/batch-operations/search";
        public const string BatchOperationCancel = "v2/batch-operations/{0}/cancellation";

        // ── Documents ─────────────────────────────────────────
        public const string Documents = "v2/documents";
        public const string DocumentByKey = "v2/documents/{0}";
        public const string DocumentLink = "v2/documents/{0}/links";

        // ── Forms ─────────────────────────────────────────────
        public const string FormByKey = "v2/forms/{0}";

        // ── Users ─────────────────────────────────────────────
        public const string Users = "v2/users";
        public const string UserByKey = "v2/users/{0}";
        public const string UserSearch = "v2/users/search";

        // ── Groups ────────────────────────────────────────────
        public const string Groups = "v2/groups";
        public const string GroupByKey = "v2/groups/{0}";
        public const string GroupSearch = "v2/groups/search";
        public const string GroupMembers = "v2/groups/{0}/users";
        public const string GroupMemberByKey = "v2/groups/{0}/users/{1}";
        public const string GroupRoles = "v2/groups/{0}/roles";
        public const string GroupRoleByKey = "v2/groups/{0}/roles/{1}";

        // ── Roles ─────────────────────────────────────────────
        public const string Roles = "v2/roles";
        public const string RoleByKey = "v2/roles/{0}";
        public const string RoleSearch = "v2/roles/search";

        // ── Tenants ───────────────────────────────────────────
        public const string Tenants = "v2/tenants";
        public const string TenantByKey = "v2/tenants/{0}";
        public const string TenantSearch = "v2/tenants/search";

        // ── Authorizations ────────────────────────────────────
        public const string Authorizations = "v2/authorizations";
        public const string AuthorizationByKey = "v2/authorizations/{0}";
        public const string AuthorizationSearch = "v2/authorizations/search";

        // ── Mapping Rules ─────────────────────────────────────
        public const string MappingRules = "v2/mapping-rules";
        public const string MappingRuleByKey = "v2/mapping-rules/{0}";
        public const string MappingRuleSearch = "v2/mapping-rules/search";

        // ── Clock (test/dev only) ─────────────────────────────
        public const string ClockPin = "v2/clock";
        public const string ClockReset = "v2/clock/reset";
    }
}