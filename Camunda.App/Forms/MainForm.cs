using Camunda.Infra.Services;
using Timer = System.Windows.Forms.Timer;

namespace Camunda.App.Forms;

public partial class MainForm : Form
{
    private readonly CamundaService _service;
    private Timer _timer = null!;

    public MainForm(CamundaService service)
    {
        _service = service;
        InitializeComponent();
        _ = LoadProcessesAsync();
        StartAutoRefresh();
    }

    private void StartAutoRefresh()
    {
        _timer = new Timer { Interval = 10000 };
        _timer.Tick += async (s, e) => await LoadProcessesAsync();
        _timer.Start();
    }

    private async Task LoadProcessesAsync()
    {
        try
        {
            lblStatus.Text = "در حال بارگذاری...";
            var processes = await _service.GetActiveProcessesAsync();

            dgvProcesses.Rows.Clear();
            foreach (var p in processes)
            {
                var currentTask = await GetCurrentTaskNameAsync(p.Id, p.State);
                dgvProcesses.Rows.Add(p.Id, p.BusinessId ?? "-", p.State, p.StartTime, currentTask);
            }

            lblStatus.Text = $"تعداد: {processes.Count} | بروزرسانی: {DateTime.Now:HH:mm:ss}";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"خطا: {ex.Message}";
        }
    }

    private async Task<string> GetCurrentTaskNameAsync(string processInstanceId, string state)
    {
        if (state != "ACTIVE") return state == "COMPLETED" ? "✅ تکمیل" : state;
        try
        {
            var activity = await _service.GetActivityInstanceAsync(processInstanceId);
            if (activity.ChildActivityInstances.Any())
                return activity.ChildActivityInstances[0].ActivityName
                       ?? activity.ChildActivityInstances[0].ActivityId;
            return "در انتظار";
        }
        catch
        {
            return "نامشخص";
        }
    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
        var form = new StartOrderForm(_service);
        form.FormClosed += async (s, e) => await LoadProcessesAsync();
        form.ShowDialog();
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await LoadProcessesAsync();
    }

    private async void btnProcessTask_Click(object sender, EventArgs e)
    {
        if (dgvProcesses.SelectedRows.Count == 0) return;
        var processInstanceId = dgvProcesses.SelectedRows[0].Cells["colId"].Value?.ToString() ?? "";

        try
        {
            var activity = await _service.GetActivityInstanceAsync(processInstanceId);
            var currentTask = activity.ChildActivityInstances.FirstOrDefault();
            if (currentTask == null)
            {
                MessageBox.Show("هیچ task فعالی یافت نشد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form? taskForm = currentTask.ActivityId switch
            {
                "validate-order" => new ValidateOrderForm(_service, processInstanceId),
                "check-inventory" => new CheckInventoryForm(_service, processInstanceId),
                "create-invoice" => new CreateInvoiceForm(_service, processInstanceId),
                "ship-order" => new ShipOrderForm(_service, processInstanceId),
                "reject-order" => new RejectOrderForm(_service, processInstanceId),
                "notify-customer-outofstock" => new NotifyCustomerForm(_service, processInstanceId),
                _ => null
            };

            if (taskForm == null)
            {
                MessageBox.Show($"فرم برای «{currentTask.ActivityId}» تعریف نشده.", "اطلاع", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            taskForm.FormClosed += async (s, e) => await LoadProcessesAsync();
            taskForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvProcesses_SelectionChanged(object sender, EventArgs e)
    {
        btnProcessTask.Enabled = dgvProcesses.SelectedRows.Count > 0;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        _timer?.Stop();
        base.OnFormClosed(e);
    }
}