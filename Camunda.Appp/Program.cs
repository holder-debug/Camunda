using Camunda.Appp;

namespace Camunda.Appp
{

    //   input1.Day >= 1 && input1.Day <= 5
    //   input1.Day >= 6 && input1.Day <= 10
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
           
        

            Application.Run(new MainForm());
        }
    }
}

 