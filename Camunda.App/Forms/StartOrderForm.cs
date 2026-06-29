using Camunda.Infra.Services;

namespace Camunda.App.Forms;

public partial class StartOrderForm : Form
{
    private readonly CamundaService _service;

    public StartOrderForm(CamundaService service)
    {
        _service = service;
        InitializeComponent();
        txtOrderId.Text = $"ORD-{DateTime.Now:yyyyMMddHHmm}";
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
        {
            MessageBox.Show("لطفاً نام مشتری را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        btnStart.Enabled = false;
        btnStart.Text = "در حال ارسال...";

        try
        {
            var result = await _service.StartProcessAsync(
                txtOrderId.Text,
                txtCustomerName.Text,
                txtCustomerEmail.Text,
                (int)numQuantity.Value);

            MessageBox.Show($"سفارش با موفقیت ثبت شد.\nشناسه: {result.Id}",
                "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا:\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnStart.Enabled = true;
            btnStart.Text = "▶  شروع سفارش";
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}