using Camunda.Infra.Models;
using Camunda.Infra.Services;

namespace Camunda.App.Forms;

// ─── CreateInvoiceForm ─────────────────────────────────────────────────────────
public partial class CreateInvoiceForm : Form
{
    private readonly CamundaService _service;
    private readonly string _processInstanceId;

    public CreateInvoiceForm(CamundaService service, string processInstanceId)
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
            lblInvoiceId.Text = $"INV-{DateTime.Now:yyyyMMddHHmmss}";
            lblInvoiceDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnConfirm_Click(object sender, EventArgs e)
    {
        try
        {
            btnConfirm.Enabled = false;
            var jobs = await _service.FetchJobsAsync("create-invoice");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["invoiceId"] = new VariableValue { Value = lblInvoiceId.Text, Type = "String" },
                ["invoiceDate"] = new VariableValue { Value = lblInvoiceDate.Text, Type = "String" }
            });
            MessageBox.Show($"فاکتور صادر شد.\nشماره: {lblInvoiceId.Text}", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnConfirm.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}

// ─── ShipOrderForm ─────────────────────────────────────────────────────────────
public partial class ShipOrderForm : Form
{
    private readonly CamundaService _service;
    private readonly string _processInstanceId;

    public ShipOrderForm(CamundaService service, string processInstanceId)
    {
        _service = service;
        _processInstanceId = processInstanceId;
        InitializeComponent();
        txtTrackingCode.Text = $"TRK-{new Random().Next(100000, 999999)}";
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
            lblInvoiceId.Text = vars.GetValueOrDefault("invoiceId")?.ToString() ?? "-";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnShip_Click(object sender, EventArgs e)
    {
        try
        {
            btnShip.Enabled = false;
            var jobs = await _service.FetchJobsAsync("ship-order");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["trackingCode"] = new VariableValue { Value = txtTrackingCode.Text, Type = "String" },
                ["shippedAt"] = new VariableValue { Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Type = "String" }
            });
            MessageBox.Show($"سفارش ارسال شد.\nکد رهگیری: {txtTrackingCode.Text}", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnShip.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}

// ─── RejectOrderForm ───────────────────────────────────────────────────────────
public partial class RejectOrderForm : Form
{
    private readonly CamundaService _service;
    private readonly string _processInstanceId;

    public RejectOrderForm(CamundaService service, string processInstanceId)
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
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnConfirmReject_Click(object sender, EventArgs e)
    {
        try
        {
            btnConfirmReject.Enabled = false;
            var jobs = await _service.FetchJobsAsync("reject-order");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["rejectedAt"] = new VariableValue { Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Type = "String" },
                ["rejectReason"] = new VariableValue { Value = txtRejectReason.Text, Type = "String" }
            });
            MessageBox.Show("سفارش رد شد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnConfirmReject.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}

// ─── NotifyCustomerForm ────────────────────────────────────────────────────────
public partial class NotifyCustomerForm : Form
{
    private readonly CamundaService _service;
    private readonly string _processInstanceId;

    public NotifyCustomerForm(CamundaService service, string processInstanceId)
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
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSendNotify_Click(object sender, EventArgs e)
    {
        try
        {
            btnSendNotify.Enabled = false;
            var jobs = await _service.FetchJobsAsync("send-email");
            var job = jobs.FirstOrDefault(j => j.ProcessInstanceId == _processInstanceId)
                      ?? throw new Exception("job یافت نشد");
            await _service.CompleteJobAsync(job.Id, new()
            {
                ["emailSentAt"] = new VariableValue { Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm"), Type = "String" }
            });
            MessageBox.Show("اطلاع‌رسانی ارسال شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnSendNotify.Enabled = true;
        }
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
}
