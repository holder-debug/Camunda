namespace Camunda.App.Forms;

partial class StartOrderForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblTitle = new Label();
        lblOrderId = new Label();
        txtOrderId = new TextBox();
        lblCustomerName = new Label();
        txtCustomerName = new TextBox();
        lblCustomerEmail = new Label();
        txtCustomerEmail = new TextBox();
        lblQuantity = new Label();
        numQuantity = new NumericUpDown();
        pnlButtons = new Panel();
        btnStart = new Button();
        btnCancel = new Button();

        // pnlHeader
        pnlHeader.BackColor = Color.FromArgb(46, 125, 50);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 55;

        // lblTitle
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Text = "➕  ثبت سفارش جدید";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        // lblOrderId
        lblOrderId.AutoSize = true;
        lblOrderId.Location = new Point(30, 80);
        lblOrderId.Text = "شناسه سفارش:";

        // txtOrderId
        txtOrderId.Location = new Point(160, 77);
        txtOrderId.Size = new Size(220, 23);

        // lblCustomerName
        lblCustomerName.AutoSize = true;
        lblCustomerName.Location = new Point(30, 120);
        lblCustomerName.Text = "نام مشتری:";

        // txtCustomerName
        txtCustomerName.Location = new Point(160, 117);
        txtCustomerName.Size = new Size(220, 23);

        // lblCustomerEmail
        lblCustomerEmail.AutoSize = true;
        lblCustomerEmail.Location = new Point(30, 160);
        lblCustomerEmail.Text = "ایمیل مشتری:";

        // txtCustomerEmail
        txtCustomerEmail.Location = new Point(160, 157);
        txtCustomerEmail.Size = new Size(220, 23);

        // lblQuantity
        lblQuantity.AutoSize = true;
        lblQuantity.Location = new Point(30, 200);
        lblQuantity.Text = "تعداد:";

        // numQuantity
        numQuantity.Location = new Point(160, 197);
        numQuantity.Minimum = 1;
        numQuantity.Maximum = 9999;
        numQuantity.Value = 1;
        numQuantity.Size = new Size(100, 23);

        // pnlButtons
        pnlButtons.BackColor = Color.FromArgb(245, 245, 245);
        pnlButtons.Controls.Add(btnStart);
        pnlButtons.Controls.Add(btnCancel);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.Height = 55;

        // btnStart
        btnStart.BackColor = Color.FromArgb(46, 125, 50);
        btnStart.FlatStyle = FlatStyle.Flat;
        btnStart.FlatAppearance.BorderSize = 0;
        btnStart.ForeColor = Color.White;
        btnStart.Location = new Point(200, 11);
        btnStart.Size = new Size(140, 34);
        btnStart.Text = "▶  شروع سفارش";
        btnStart.Cursor = Cursors.Hand;
        btnStart.Click += btnStart_Click;

        // btnCancel
        btnCancel.BackColor = Color.FromArgb(158, 158, 158);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.ForeColor = Color.White;
        btnCancel.Location = new Point(90, 11);
        btnCancel.Size = new Size(100, 34);
        btnCancel.Text = "انصراف";
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.Click += btnCancel_Click;

        // StartOrderForm
        BackColor = Color.White;
        ClientSize = new Size(420, 340);
        Controls.Add(pnlHeader);
        Controls.Add(lblOrderId);
        Controls.Add(txtOrderId);
        Controls.Add(lblCustomerName);
        Controls.Add(txtCustomerName);
        Controls.Add(lblCustomerEmail);
        Controls.Add(txtCustomerEmail);
        Controls.Add(lblQuantity);
        Controls.Add(numQuantity);
        Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "ثبت سفارش جدید";
    }

    private Panel pnlHeader;
    private Label lblTitle;
    private Label lblOrderId;
    private TextBox txtOrderId;
    private Label lblCustomerName;
    private TextBox txtCustomerName;
    private Label lblCustomerEmail;
    private TextBox txtCustomerEmail;
    private Label lblQuantity;
    private NumericUpDown numQuantity;
    private Panel pnlButtons;
    private Button btnStart;
    private Button btnCancel;
}
