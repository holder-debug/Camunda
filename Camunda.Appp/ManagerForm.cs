using Camunda.Appp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camunda.Appp
{
    public partial class ManagerForm : Form
    {
        private CamundaService _camundaService;

        public ManagerForm(CamundaService camundaService)
        {
            InitializeComponent();
            _camundaService = camundaService;
            LoadPendingRequests();
        }

        private async void LoadPendingRequests()
        {
            try
            {
                btnRefresh.Enabled = false;
                btnRefresh.Text = "در حال بارگذاری...";

                var instances = await _camundaService.GetProcessInstancesAsync("leave-approval-process", "ACTIVE");
                var activeInstances = instances.Items ?? new List<ProcessInstance>();

                dgvRequests.DataSource = null;
                dgvRequests.DataSource = activeInstances.Select(i => new
                {
                    ProcessInstanceKey = i.ProcessInstanceKey,
                    StartDate = i.StartDate?.ToString("yyyy/MM/dd HH:mm"),
                    State = i.State
                }).ToList();

                if (dgvRequests.Columns["ProcessInstanceKey"] != null)
                    dgvRequests.Columns["ProcessInstanceKey"].HeaderText = "کد درخواست";
                if (dgvRequests.Columns["StartDate"] != null)
                    dgvRequests.Columns["StartDate"].HeaderText = "تاریخ شروع";
                if (dgvRequests.Columns["State"] != null)
                    dgvRequests.Columns["State"].HeaderText = "وضعیت";

                if (activeInstances.Count == 0)
                {
                    txtDetails.Text = "هیچ درخواست مرخصی در انتظار بررسی وجود ندارد.";
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
                btnRefresh.Text = "بارگذاری مجدد";
            }
        }

        private async void DgvRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0) return;

            try
            {
                var row = dgvRequests.SelectedRows[0];
                var processInstanceKey = row.Cells["ProcessInstanceKey"].Value?.ToString();

                var variablesResponse = await _camundaService.GetVariablesAsync(processInstanceKey);
                var variables = variablesResponse.Items ?? new List<Variable>();

                var employeeName = variables.FirstOrDefault(v => v.Name == "employeeName")?.Value?.Trim('"') ?? "نامشخص";
                var startDate = variables.FirstOrDefault(v => v.Name == "startDate")?.Value?.Trim('"') ?? "نامشخص";
                var days = variables.FirstOrDefault(v => v.Name == "days")?.Value ?? "0";
                var reason = variables.FirstOrDefault(v => v.Name == "reason")?.Value?.Trim('"') ?? "بدون دلیل";

                txtDetails.Text =
                    $"نام کارمند: {employeeName}\n" +
                    $"تاریخ شروع: {startDate}\n" +
                    $"تعداد روز: {days}\n" +
                    $"دلیل مرخصی: {reason}";

                btnApprove.Enabled = true;
                btnReject.Enabled = true;
            }
            catch (Exception ex)
            {
                txtDetails.Text = $"خطا: {ex.Message}";
            }
        }

        private async Task<bool> CompleteManagerReviewJob(string processInstanceKey, string decision)
        {
            try
            {
                var jobsResponse = await _camundaService.ActivateJobsAsync("manager-review-task", 100);
                var targetJob = jobsResponse.Jobs?.FirstOrDefault(j => j.ProcessInstanceKey == processInstanceKey);

                if (targetJob == null)
                {
                    MessageBox.Show("Job مربوط به این درخواست پیدا نشد.", "خطا");
                    return false;
                }

                var variables = new Dictionary<string, object> { { "approvalDecision", decision } };
                await _camundaService.CompleteJobAsync(targetJob.JobKey.ToString(), variables);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا: {ex.Message}", "خطا");
                return false;
            }
        }

        private async void BtnApprove_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0) return;

            var result = MessageBox.Show("آیا از تایید این درخواست اطمینان دارید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var row = dgvRequests.SelectedRows[0];
            var processInstanceKey = row.Cells["ProcessInstanceKey"].Value?.ToString();

            bool success = await CompleteManagerReviewJob(processInstanceKey, "approved");

            if (success)
            {
                MessageBox.Show("درخواست با موفقیت تایید شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingRequests();
            }
        }

        private async void BtnReject_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0) return;

            var result = MessageBox.Show("آیا از رد این درخواست اطمینان دارید؟", "رد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var row = dgvRequests.SelectedRows[0];
            var processInstanceKey = row.Cells["ProcessInstanceKey"].Value?.ToString();

            bool success = await CompleteManagerReviewJob(processInstanceKey, "rejected");

            if (success)
            {
                MessageBox.Show("درخواست رد شد!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingRequests();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadPendingRequests();

        private async void BtnEnd_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک درخواست را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvRequests.SelectedRows[0];
            var processInstanceKey = row.Cells["ProcessInstanceKey"].Value?.ToString();

            try
            {
                // گرفتن متغیرها برای بررسی وضعیت
                var variablesResponse = await _camundaService.GetVariablesAsync(processInstanceKey);
                var variables = variablesResponse.Items ?? new List<Variable>();

                // بررسی اینکه آیا approvalDecision وجود دارد یا نه
                var decisionVar = variables.FirstOrDefault(v => v.Name == "approvalDecision");

                if (decisionVar == null)
                {
                    MessageBox.Show("این درخواست هنوز در مرحله بررسی مدیر است. ابتدا باید تایید یا رد شود.",
                        "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string decision = decisionVar.Value?.Trim('"');
                string finalJobType = decision == "approved" ? "process-approval" : "process-rejection";

                // پیدا کردن Job نهایی
                var finalJobs = await _camundaService.ActivateJobsAsync(finalJobType, 100);
                var finalJob = finalJobs.Jobs?.FirstOrDefault(j => j.ProcessInstanceKey == processInstanceKey);

                if (finalJob == null)
                {
                    MessageBox.Show("Job نهایی پیدا نشد. ممکن است فرآیند قبلاً کامل شده باشد.", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Complete کردن Job نهایی
                var finalVariables = new Dictionary<string, object>
                {
                    { "finalStatus", decision == "approved" ? "APPROVED" : "REJECTED" },
                    { "processedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                };

                await _camundaService.CompleteJobAsync((finalJob.JobKey), finalVariables);

                MessageBox.Show($"درخواست با موفقیت {decision} شد و فرآیند به پایان رسید.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPendingRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}