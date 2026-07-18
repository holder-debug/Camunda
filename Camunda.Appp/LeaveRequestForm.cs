using Camunda.Appp;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Camunda.Appp
{
    public partial class LeaveRequestForm : Form
    {
        private CamundaService _camundaService;
        private readonly RulesEngine.RulesEngine _rulesEngine;

        public LeaveRequestForm(CamundaService camundaService)
        {
            InitializeComponent();
            _camundaService = camundaService;

            // بارگذاری قوانین فعال
            var workflow = new Workflow
            {
                WorkflowName = "leave-approval-process",
                Rules = RuleBuilderForm.Rules
            };
            var workflows = new List<Workflow> { workflow };
            _rulesEngine = new RulesEngine.RulesEngine(workflows.ToArray());
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            // اعتبارسنجی ورودی‌ها
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("لطفاً نام کارمند را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("لطفاً دلیل مرخصی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReason.Focus();
                return;
            }

            if (numDays.Value < 1)
            {
                MessageBox.Show("تعداد روزهای مرخصی باید حداقل 1 روز باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDays.Focus();
                return;
            }

            try
            {
                btnSubmit.Enabled = false;
                btnSubmit.Text = "در حال بررسی قوانین...";

                // ========== مرحله 1: اجرای قوانین ==========
                var input = new { Day = (int)numDays.Value };
                var results = await _rulesEngine.ExecuteAllRulesAsync("leave-approval-process", input);

                // ========== مرحله 2: بررسی همه رول‌های فعال ==========
                var activeRules = results.Where(r => r.Rule.Enabled).ToList();
                var allRulesPassed = activeRules.All(r => r.IsSuccess);

                // ========== مرحله 3: اگر همه قوانین پاس نشدن ==========
                if (!allRulesPassed)
                {
                    var failedRules = activeRules.Where(r => !r.IsSuccess).Select(r => r.Rule.RuleName);
                    var failedMessage = string.Join("\n• ", failedRules);

                    MessageBox.Show(
                        $"❌ درخواست مرخصی با شکست مواجه شد!\n\n" +
                        $"قوانین زیر پاس نشدند:\n• {failedMessage}\n\n" +
                        $"تعداد روزهای مرخصی ({numDays.Value} روز) با قوانین سازمان همخوانی ندارد.",
                        "شکست قوانین",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    btnSubmit.Enabled = true;
                    btnSubmit.Text = "ثبت درخواست";
                    return;
                }

                // ========== مرحله 4: تصمیم‌گیری بر اساس رول‌های فعال ==========
                string approvalDecision = "rejected";
                string appliedRules = "هیچ";

                if (activeRules.Any())
                {
                    appliedRules = string.Join(", ", activeRules.Select(r => r.Rule.RuleName));

                    if (activeRules.Any(r => r.Rule.RuleName == "زیر 5 روز"))
                        approvalDecision = "approved";
                    else if (activeRules.Any(r => r.Rule.RuleName == "بین 6 تا 10 روز"))
                        approvalDecision = "rejected";
                }

                // ========== مرحله 5: ارسال به کاموندا ==========
                btnSubmit.Text = "در حال ارسال به کاموندا...";

                var variables = new Dictionary<string, object>
                {
                    { "employeeName", txtEmployeeName.Text.Trim() },
                    { "startDate", dtpStartDate.Value.ToString("yyyy-MM-dd") },
                    { "days", (int)numDays.Value },
                    { "reason", txtReason.Text.Trim() },
                    { "approvalDecision", approvalDecision },
                    { "appliedRules", appliedRules },
                    { "allRulesPassed", true },
                    { "submittedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                };

                var result = await _camundaService.StartProcessInstanceAsync("leave-approval-process", variables);

                // ========== مرحله 6: نمایش پیام موفقیت ==========
                var decisionText = approvalDecision == "approved" ? "✅ تأیید خودکار" : "⏳ نیاز به بررسی مدیر";

                MessageBox.Show(
                    $"✅ درخواست مرخصی با موفقیت ثبت شد!\n\n" +
                    $"👤 کارمند: {txtEmployeeName.Text}\n" +
                    $"📅 تاریخ شروع: {dtpStartDate.Value:yyyy-MM-dd}\n" +
                    $"📆 تعداد روز: {numDays.Value}\n" +
                    $"📋 قوانین اعمال شده: {appliedRules}\n" +
                    $"📌 وضعیت: {decisionText}\n" +
                    $"🆔 کد پیگیری: {result.ProcessInstanceKey}",
                    "موفقیت",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ خطا در ثبت درخواست:\n\n{ex.Message}",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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

        // نمایش وضعیت قوانین در فرم (اختیاری)
        private void ShowRulesStatus(int days)
        {
            try
            {
                var input = new { Day = days };
                var results = _rulesEngine.ExecuteAllRulesAsync("leave-approval-process", input).GetAwaiter().GetResult();

                var statusText = string.Join("\n", results.Select(r =>
                    $"{r.Rule.RuleName}: {(r.Rule.Enabled ? (r.IsSuccess ? "✅ فعال" : "❌ غیرفعال") : "⚪ غیرفعال")}"
                ));

                // میتونید در یک Label یا ToolTip نمایش بدید
       
            }
            catch
            {
                // خطا را نادیده بگیر
            }
        }

        private void NumDays_ValueChanged(object sender, EventArgs e)
        {
            // وقتی تعداد روز تغییر میکنه، وضعیت قوانین رو نمایش بده
            ShowRulesStatus((int)numDays.Value);
        }
    }
}