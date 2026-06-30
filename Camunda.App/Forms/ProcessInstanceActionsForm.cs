// ============================================================
//  مدیریت Process Instance - منطق فرم (code-behind)
//  ساخت کنترل‌ها در فایل ProcessInstanceActionsForm.Designer.cs انجام شده
// ============================================================

using Camunda.Infra.Models;
using Camunda.Infra.Services;

namespace Camunda.App.Forms
{
    public partial class ProcessInstanceActionsForm : Form
    {
        private readonly CamundaProcessInstanceService _service;

        public ProcessInstanceActionsForm(CamundaProcessInstanceService service)
        {
            _service = service;
            InitializeComponent();
        }

        private string GetKeyOrWarn()
        {
            var key = txtProcessInstanceKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("لطفاً Process Instance Key را وارد کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return key;
        }

        private async void btnCheckStatus_Click(object sender, EventArgs e)
        {
            var key = GetKeyOrWarn();
            if (string.IsNullOrEmpty(key)) return;

            try
            {
                lblStatus.Text = "در حال بررسی...";
                var instance = await _service.GetByKeyAsync(key);

                if (instance == null)
                {
                    lblCurrentState.Text = "وضعیت: یافت نشد";
                    lblStatus.Text = "هیچ instance ای با این کلید پیدا نشد.";
                    return;
                }

                lblCurrentState.Text = $"وضعیت: {instance.State}";
                lblStatus.Text = $"نام پروسه: {instance.ProcessDefinitionName}\n" +
                                  $"شروع: {instance.StartDate}\n" +
                                  $"پایان: {instance.EndDate}";

                btnDelete.Enabled = instance.State is ProcessInstanceState.COMPLETED
                                                     or ProcessInstanceState.CANCELED;
                btnCancel.Enabled = instance.State == ProcessInstanceState.ACTIVE;
            }
            catch (CamundaApiException ex)
            {
                lblStatus.Text = $"خطا: {ex.Message}";
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            var key = GetKeyOrWarn();
            if (string.IsNullOrEmpty(key)) return;

            var confirm = MessageBox.Show(
                $"آیا از لغو اجرای instance با کلید {key} مطمئن هستید؟\n" +
                "این عملیات اجرای جاری را متوقف می‌کند (تاریخچه باقی می‌ماند).",
                "تایید لغو",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                btnCancel.Enabled = false;
                lblStatus.Text = "در حال لغو...";

                await _service.CancelAsync(key);

                lblStatus.Text = "✓ Process instance با موفقیت لغو شد.";
                MessageBox.Show("لغو با موفقیت انجام شد.", "موفق",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CamundaApiException ex)
            {
                lblStatus.Text = $"خطا: {ex.Message}";
                MessageBox.Show(ex.Message, "خطا در لغو",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCancel.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var key = GetKeyOrWarn();
            if (string.IsNullOrEmpty(key)) return;

            var confirm = MessageBox.Show(
                $"آیا از حذف کامل instance با کلید {key} مطمئن هستید؟\n\n" +
                "توجه: این عملیات غیرقابل بازگشت است و تمام تاریخچه " +
                "(متغیرها، فعالیت‌ها و ...) برای همیشه پاک می‌شود.\n" +
                "فقط instance های COMPLETED یا TERMINATED قابل حذف هستند.",
                "تایید حذف نهایی",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                btnDelete.Enabled = false;
                lblStatus.Text = "در حال حذف...";

                await _service.DeleteAsync(key);

                lblStatus.Text = "✓ Process instance با موفقیت حذف شد.";
                MessageBox.Show("حذف با موفقیت انجام شد.", "موفق",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtProcessInstanceKey.Clear();
                lblCurrentState.Text = "وضعیت: -";
            }
            catch (CamundaApiException ex)
            {
                lblStatus.Text = $"خطا: {ex.Message}";
                MessageBox.Show(ex.Message, "خطا در حذف",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDelete.Enabled = true;
            }
        }
    }
}
