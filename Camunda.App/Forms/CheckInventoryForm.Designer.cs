namespace Camunda.App.Forms;

partial class CheckInventoryForm
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
        lblTitleHeader = new Label();
        grpInfo = new GroupBox();
        lblProcessIdCaption = new Label();
        lblProcessId = new Label();
        lblOrderIdCaption = new Label();
        lblOrderId = new Label();
        lblCustomerNameCaption = new Label();
        lblCustomerName = new Label();
        lblQuantityCaption = new Label();
        lblQuantity = new Label();
        pnlButtons = new Panel();
        btnInStock = new Button();
        btnOutOfStock = new Button();
        btnClose = new Button();

        // pnlHeader
        pnlHeader.BackColor = Color.FromArgb(106, 27, 154);
        pnlHeader.Controls.Add(lblTitleHeader);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 55;

        // lblTitleHeader
        lblTitleHeader.Dock = DockStyle.Fill;
        lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White;
        lblTitleHeader.Text = "📦  بررسی موجودی - Check Inventory";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        // grpInfo
        grpInfo.Location = new Point(20, 70);
        grpInfo.Size = new Size(440, 175);
        grpInfo.Text = "اطلاعات سفارش";
        grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

        lblProcessIdCaption = new Label { AutoSize = true, Location = new Point(10, 25), Text = "شناسه پروسه:", Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        lblProcessId = new Label { AutoSize = true, Location = new Point(140, 25), Text = "..." };
        lblOrderIdCaption = new Label { AutoSize = true, Location = new Point(10, 60), Text = "شناسه سفارش:", Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        lblOrderId = new Label { AutoSize = true, Location = new Point(140, 60), Text = "..." };
        lblCustomerNameCaption = new Label { AutoSize = true, Location = new Point(10, 95), Text = "نام مشتری:", Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        lblCustomerName = new Label { AutoSize = true, Location = new Point(140, 95), Text = "..." };
        lblQuantityCaption = new Label { AutoSize = true, Location = new Point(10, 130), Text = "تعداد درخواستی:", Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        lblQuantity = new Label { AutoSize = true, Location = new Point(140, 130), Text = "...", Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.FromArgb(106, 27, 154) };

        grpInfo.Controls.AddRange(new Control[] { lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName, lblQuantityCaption, lblQuantity });

        // pnlButtons
        pnlButtons.BackColor = Color.FromArgb(245, 245, 245);
        pnlButtons.Controls.Add(btnInStock);
        pnlButtons.Controls.Add(btnOutOfStock);
        pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.Height = 55;

        // btnInStock
        btnInStock.BackColor = Color.FromArgb(46, 125, 50);
        btnInStock.FlatStyle = FlatStyle.Flat;
        btnInStock.FlatAppearance.BorderSize = 0;
        btnInStock.ForeColor = Color.White;
        btnInStock.Location = new Point(240, 11);
        btnInStock.Size = new Size(120, 34);
        btnInStock.Text = "✔  موجود است";
        btnInStock.Cursor = Cursors.Hand;
        btnInStock.Click += btnInStock_Click;

        // btnOutOfStock
        btnOutOfStock.BackColor = Color.FromArgb(230, 81, 0);
        btnOutOfStock.FlatStyle = FlatStyle.Flat;
        btnOutOfStock.FlatAppearance.BorderSize = 0;
        btnOutOfStock.ForeColor = Color.White;
        btnOutOfStock.Location = new Point(110, 11);
        btnOutOfStock.Size = new Size(120, 34);
        btnOutOfStock.Text = "✖  ناموجود";
        btnOutOfStock.Cursor = Cursors.Hand;
        btnOutOfStock.Click += btnOutOfStock_Click;

        // btnClose
        btnClose.BackColor = Color.FromArgb(158, 158, 158);
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White;
        btnClose.Location = new Point(10, 11);
        btnClose.Size = new Size(90, 34);
        btnClose.Text = "بستن";
        btnClose.Cursor = Cursors.Hand;
        btnClose.Click += btnClose_Click;

        // CheckInventoryForm
        BackColor = Color.White;
        ClientSize = new Size(480, 340);
        Controls.Add(pnlHeader);
        Controls.Add(grpInfo);
        Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "بررسی موجودی";
    }

    private Panel pnlHeader;
    private Label lblTitleHeader;
    private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId;
    private Label lblOrderIdCaption, lblOrderId;
    private Label lblCustomerNameCaption, lblCustomerName;
    private Label lblQuantityCaption, lblQuantity;
    private Panel pnlButtons;
    private Button btnInStock;
    private Button btnOutOfStock;
    private Button btnClose;
}
