using Camunda.Infra.Models;
using Camunda.Infra.Services;

namespace Camunda.App.Forms;

public partial class ValidateOrderForm : Form
{
    private readonly string _processInstanceId;
    private readonly CamundaService _service;

    public ValidateOrderForm(CamundaService service, string processInstanceId)
    {
        _service = service;
        _processInstanceId = processInstanceId;
        InitializeComponent();
        _ = LoadAsync();
    }

    private async Task LoadAsync()
    {
        try
        {
            var vars = await _service.GetProcessVariablesAsync(_processInstanceId);
            lblProcessId.Text = _processInstanceId;
            lblOrderId.Text = vars.GetValueOrDefault("orderId")?.ToString() ?? "-";
            lblCustomerName.Text = vars.GetValueOrDefault("customerName")?.ToString() ?? "-";
            lblCustomerEmail.Text = vars.GetValueOrDefault("customerEmail")?.ToString() ?? "-";
            lblQuantity.Text = vars.GetValueOrDefault("quantity")?.ToString() ?? "-";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا در بارگذاری: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnApprove_Click(object sender, EventArgs e)
    {
        try
        {
            btnApprove.Enabled = false;
            btnReject.Enabled = false;
            var jobs = await _service.FetchJobsAsync("validate-order");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.JobKey, new Dictionary<string, VariableValue>
            {
                ["valid"] = new() { Value = true, Type = "Boolean" }
            });
            MessageBox.Show("سفارش تایید شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnApprove.Enabled = true;
            btnReject.Enabled = true;
        }
    }

    private async void btnReject_Click(object sender, EventArgs e)
    {
        try
        {
            btnApprove.Enabled = false;
            btnReject.Enabled = false;
            var jobs = await _service.FetchJobsAsync("validate-order");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new Dictionary<string, VariableValue>
            {
                ["valid"] = new() { Value = false, Type = "Boolean" }
            });
            MessageBox.Show("سفارش رد شد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnApprove.Enabled = true;
            btnReject.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}