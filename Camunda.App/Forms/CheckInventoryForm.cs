using Camunda.Infra.Models;
using Camunda.Infra.Services;

namespace Camunda.App.Forms;

public partial class CheckInventoryForm : Form
{
    private readonly CamundaService _service;
    private readonly string _processInstanceId;

    public CheckInventoryForm(CamundaService service, string processInstanceId)
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
            lblQuantity.Text = vars.GetValueOrDefault("quantity")?.ToString() ?? "-";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnInStock_Click(object sender, EventArgs e)
    {
        try
        {
            btnInStock.Enabled = false;
            btnOutOfStock.Enabled = false;
            var jobs = await _service.FetchJobsAsync("check-inventory");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["inventorySufficient"] = new VariableValue { Value = true, Type = "Boolean" }
            });
            MessageBox.Show("موجودی تایید شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnInStock.Enabled = true;
            btnOutOfStock.Enabled = true;
        }
    }

    private async void btnOutOfStock_Click(object sender, EventArgs e)
    {
        try
        {
            btnInStock.Enabled = false;
            btnOutOfStock.Enabled = false;
            var jobs = await _service.FetchJobsAsync("check-inventory");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["inventorySufficient"] = new VariableValue { Value = false, Type = "Boolean" }
            });
            MessageBox.Show("موجودی ناکافی.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnInStock.Enabled = true;
            btnOutOfStock.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
