using Camunda.Appp;

namespace Camunda.Appp
{
    public class LeaveJobWorker
    {
        private CamundaService _camundaService;

        public LeaveJobWorker(CamundaService camundaService)
        {
            _camundaService = camundaService;
        }

        public async Task StartAsync()
        {
            Console.WriteLine("Leave Job Worker started...");

            while (true)
            {
                try
                {
                    // پردازش Jobهای process-approval
                    var approvalJobs = await _camundaService.ActivateJobsAsync("process-approval", 10);
                    if (approvalJobs.Jobs != null)
                    {
                        foreach (var job in approvalJobs.Jobs)
                        {
                            Console.WriteLine($"Processing approval job: {job.JobKey}");
                            var variables = new Dictionary<string, object>
                            {
                                { "finalStatus", "APPROVED" },
                                { "processedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                            };
                            await _camundaService.CompleteJobAsync(job.JobKey, variables);
                        }
                    }

                    // پردازش Jobهای process-rejection
                    var rejectionJobs = await _camundaService.ActivateJobsAsync("process-rejection", 10);
                    if (rejectionJobs.Jobs != null)
                    {
                        foreach (var job in rejectionJobs.Jobs)
                        {
                            Console.WriteLine($"Processing rejection job: {job.JobKey}");
                            var variables = new Dictionary<string, object>
                            {
                                { "finalStatus", "REJECTED" },
                                { "processedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                            };
                            await _camundaService.CompleteJobAsync(job.JobKey, variables);
                        }
                    }

                    await Task.Delay(2000); // 2 ثانیه صبر کن
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in worker: {ex.Message}");
                    await Task.Delay(5000);
                }
            }
        }
    }


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();



            // شروع Worker در پس‌زمینه
            var camundaService = new CamundaService("http://localhost:8080");
            var worker = new LeaveJobWorker(camundaService);
            Task.Run(() => worker.StartAsync());

            Application.Run(new MainForm());
        }
    }
}

 