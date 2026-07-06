namespace Camunda.Appp;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

 
    public class ProcessInstance
    {
        [JsonPropertyName("processInstanceKey")]
        public string ProcessInstanceKey { get; set; }

        [JsonPropertyName("processDefinitionId")]
        public string ProcessDefinitionId { get; set; }

        [JsonPropertyName("processDefinitionName")]
        public string ProcessDefinitionName { get; set; }

        [JsonPropertyName("processDefinitionVersion")]
        public int ProcessDefinitionVersion { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("hasIncident")]
        public bool HasIncident { get; set; }
    }

    public class ProcessInstanceResponse
    {
        [JsonPropertyName("processInstanceKey")]
        public string ProcessInstanceKey { get; set; }

        [JsonPropertyName("processDefinitionId")]
        public string ProcessDefinitionId { get; set; }
    }

    public class ProcessInstanceListResponse
    {
        [JsonPropertyName("items")]
        public List<ProcessInstance> Items { get; set; }

        [JsonPropertyName("page")]
        public PageResponse Page { get; set; }
    }

    public class PageResponse
    {
        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }
    }

    public class Variable
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("processInstanceKey")]
        public string ProcessInstanceKey { get; set; }
    }

    public class VariableListResponse
    {
        [JsonPropertyName("items")]
        public List<Variable> Items { get; set; }
    }

    public class Job
    {
        [JsonPropertyName("jobKey")]
        public string JobKey { get; set; }

        [JsonPropertyName("processInstanceKey")]
        public string ProcessInstanceKey { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("variables")]
        public JsonElement Variables { get; set; }
    }

    public class JobListResponse
    {
        [JsonPropertyName("jobs")]
        public List<Job> Jobs { get; set; }
    }
 











