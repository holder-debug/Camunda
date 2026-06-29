using Newtonsoft.Json;

namespace Camunda.Infra.Models;

// ─── Process Definition ───────────────────────────────────────────────────────
public class ProcessDefinition
{
    [JsonProperty("key")]
    public long Key { get; set; }

    [JsonProperty("processDefinitionId")]
    public string ProcessDefinitionId { get; set; } = "";
}

public class ProcessDefinitionSearchResponse
{
    [JsonProperty("items")]
    public List<ProcessDefinition> Items { get; set; } = new();
}

// ─── Process Instance ──────────────────────────────────────────────────────────
public class ProcessInstance
{
    [JsonProperty("processInstanceKey")]
    public string ProcessInstanceKey { get; set; } = "";

    public string Id => ProcessInstanceKey;

 

    [JsonProperty("processDefinitionKey")]
    public long ProcessDefinitionKey { get; set; }

    [JsonProperty("processDefinitionId")]
    public string ProcessDefinitionId { get; set; } = "";

    [JsonProperty("startDate")]
    public string StartTime { get; set; } = "";

    [JsonProperty("state")]
    public string State { get; set; } = "";

    [JsonProperty("businessId")]
    public string? BusinessId { get; set; }
}

public class ProcessInstanceSearchResponse
{
    [JsonProperty("items")]
    public List<ProcessInstance> Items { get; set; } = new();

    [JsonProperty("total")]
    public int Total { get; set; }
}

// ─── Start Process ─────────────────────────────────────────────────────────────
public class StartProcessResponse
{
    [JsonProperty("processInstanceKey")]
    public string ProcessInstanceKey { get; set; } = "";

    public string Id => ProcessInstanceKey;
}

// ─── Flownode (Activity) ───────────────────────────────────────────────────────
public class FlownodeInstance
{
    [JsonProperty("elementInstanceKey")]
    public string Key { get; set; } = "";

    [JsonProperty("processInstanceKey")]
    public string ProcessInstanceKey { get; set; } = "";

    [JsonProperty("elementId")]      // ← عوض شد
    public string FlownodeId { get; set; } = "";

    [JsonProperty("elementName")]    // ← عوض شد
    public string? FlownodeName { get; set; }

    [JsonProperty("state")]
    public string State { get; set; } = "";

    [JsonProperty("type")]
    public string Type { get; set; } = "";
}

public class FlownodeSearchResponse
{
    [JsonProperty("items")]
    public List<FlownodeInstance> Items { get; set; } = new();
}

public class ActivityInstance
{
    public string Id { get; set; } = "";
    public string ActivityId { get; set; } = "";
    public string ActivityName { get; set; } = "";
    public List<ActivityInstance> ChildActivityInstances { get; set; } = new();
}

// ─── Variables ────────────────────────────────────────────────────────────────
public class VariableItem
{
    [JsonProperty("name")]
    public string Name { get; set; } = "";

    [JsonProperty("value")]
    public object? Value { get; set; }
}

public class VariableSearchResponse
{
    [JsonProperty("items")]
    public List<VariableItem> Items { get; set; } = new();
}

public class VariableValue
{
    public object? Value { get; set; }
    public string Type { get; set; } = "String";
}

// ─── Jobs ─────────────────────────────────────────────────────────────────────
public class Job
{
    [JsonProperty("key")]
    public long Key { get; set; }

    public string Id => Key.ToString();

    [JsonProperty("processInstanceKey")]
    public long ProcessInstanceKey { get; set; }

    public string ProcessInstanceId => ProcessInstanceKey.ToString();

    [JsonProperty("type")]
    public string TopicName { get; set; } = "";
}

public class JobSearchResponse
{
    [JsonProperty("items")]
    public List<Job> Items { get; set; } = new();
}

// ─── Start Request ────────────────────────────────────────────────────────────
public class StartProcessRequest
{
    [JsonProperty("variables")]
    public Dictionary<string, VariableValue> Variables { get; set; } = new();

    [JsonProperty("businessKey")]
    public string? BusinessKey { get; set; }
}
