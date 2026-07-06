using Camunda.Appp;
 
using System;
using System.Windows.Forms;

namespace Camunda.Appp
{
    public partial class MainForm : Form
    {
        private CamundaService _camundaService;

        public MainForm()
        {
            InitializeComponent();
            _camundaService = new CamundaService("http://localhost:8080");
        }

        private void BtnEmployeeRequest_Click(object sender, EventArgs e)
        {
            var form = new LeaveRequestForm(_camundaService);
            form.ShowDialog();
        }

        private void BtnManagerView_Click(object sender, EventArgs e)
        {
            var form = new ManagerForm(_camundaService);
            form.ShowDialog();
        }
    }
}