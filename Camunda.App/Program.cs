using Camunda.App.Forms;
using Camunda.Infra.Services;

namespace Camunda.App;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        const string camundaBaseUrl = "http://localhost:8080";
        var service = new CamundaService(camundaBaseUrl);
        Application.Run(new MainForm(service));
    }
}