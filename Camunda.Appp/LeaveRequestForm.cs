using Camunda.Appp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Camunda.Appp
{
    public partial class LeaveRequestForm : Form
    {
        private CamundaService _camundaService;

        public LeaveRequestForm(CamundaService camundaService)
        {
            InitializeComponent();
            _camundaService = camundaService;
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("لطفاً نام کارمند را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("لطفاً دلیل مرخصی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnSubmit.Enabled = false;
                btnSubmit.Text = "در حال ارسال...";

                var variables = new Dictionary<string, object>
                {
                    { "employeeName", txtEmployeeName.Text.Trim() },
                    { "startDate", dtpStartDate.Value.ToString("yyyy-MM-dd") },
                    { "days", (int)numDays.Value },
                    { "reason", txtReason.Text.Trim() }
                };

                var result = await _camundaService.StartProcessInstanceAsync("leave-approval-process", variables);

                MessageBox.Show(
                    $"درخواست مرخصی با موفقیت ثبت شد!\n\n" +
                    $"کد پیگیری: {result.ProcessInstanceKey}",
                    "موفقیت",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ثبت درخواست:\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSubmit.Enabled = true;
                btnSubmit.Text = "ثبت درخواست";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}