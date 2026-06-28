using System.Net.Http.Json;
using Camunda.Infra.Interfaces;
using Camunda.Infra.Model;
using Newtonsoft.Json;

namespace Camunda.Infra.Services;

public class StepService : IStepService
{
    private readonly HttpClient _httpClient;


    public StepService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<NextStepResponse> StepAAsync(
        string processInstanceId,
        GetActivityInstanceResponse processInfo,
        CancellationToken ct = default)
    {
        var request = new NextStepRequest
        {
            SkipIoMappings = false,
            SkipCustomListeners = false,
            Annotation = "ok",
            Instructions = new[]
            {
                new Instruction
                {
                    Type = "startAfterActivity",
                    ActivityId = processInfo.ActivityId,
                    Variables = new InstructionVariablesModel
                    {
                        Mobile = new Var { Type = "long", Local = false, Value = "09355555" },
                        Name = new Var { Type = "string", Local = false, Value = "alllllllliiiii" }
                    }
                },
                new Instruction
                {
                    Type = "cancel",
                    ActivityId = processInfo.ActivityId
                }
            }
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"process-instance/{processInstanceId}/modification", request, ct);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync(ct);
        return JsonConvert.DeserializeObject<NextStepResponse>(content)
               ?? throw new Exception("پاسخ StepA خالی است");
    }
}