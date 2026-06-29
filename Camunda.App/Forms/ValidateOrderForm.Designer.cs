namespace Camunda.App.Forms;

partial class ValidateOrderForm
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
        lblCustomerEmailCaption = new Label();
        lblCustomerEmail = new Label();
        lblQuantityCaption = new Label();
        lblQuantity = new Label();
        pnlButtons = new Panel();
        btnApprove = new Button();
        btnReject = new Button();
        btnClose = new Button();

        // pnlHeader
        pnlHeader.BackColor = Color.FromArgb(21, 101, 192);
        pnlHeader.Controls.Add(lblTitleHeader);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 55;

        // lblTitleHeader
        lblTitleHeader.Dock = DockStyle.Fill;
        lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White;
        lblTitleHeader.Text = "✅  تایید سفارش - Validate Order";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        // grpInfo
        grpInfo.Location = new Point(20, 70);
        grpInfo.Size = new Size(440, 210);
        grpInfo.Text = "اطلاعات سفارش";
        grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

        // Rows inside grpInfo
        AddInfoRow(grpInfo, "شناسه پروسه:", out lblProcessIdCaption, out lblProcessId, 25);
        AddInfoRow(grpInfo, "شناسه سفارش:", out lblOrderIdCaption, out lblOrderId, 60);
        AddInfoRow(grpInfo, "نام مشتری:", out lblCustomerNameCaption, out lblCustomerName, 95);
        AddInfoRow(grpInfo, "ایمیل:", out lblCustomerEmailCaption, out lblCustomerEmail, 130);
        AddInfoRow(grpInfo, "تعداد:", out lblQuantityCaption, out lblQuantity, 165);

        // pnlButtons
        pnlButtons.BackColor = Color.FromArgb(245, 245, 245);
        pnlButtons.Controls.Add(btnApprove);
        pnlButtons.Controls.Add(btnReject);
        pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom;
        pnlButtons.Height = 55;

        // btnApprove
        btnApprove.BackColor = Color.FromArgb(46, 125, 50);
        btnApprove.FlatStyle = FlatStyle.Flat;
        btnApprove.FlatAppearance.BorderSize = 0;
        btnApprove.ForeColor = Color.White;
        btnApprove.Location = new Point(230, 11);
        btnApprove.Size = new Size(130, 34);
        btnApprove.Text = "✔  تایید سفارش";
        btnApprove.Cursor = Cursors.Hand;
        btnApprove.Click += btnApprove_Click;

        // btnReject
        btnReject.BackColor = Color.FromArgb(183, 28, 28);
        btnReject.FlatStyle = FlatStyle.Flat;
        btnReject.FlatAppearance.BorderSize = 0;
        btnReject.ForeColor = Color.White;
        btnReject.Location = new Point(90, 11);
        btnReject.Size = new Size(130, 34);
        btnReject.Text = "✖  رد سفارش";
        btnReject.Cursor = Cursors.Hand;
        btnReject.Click += btnReject_Click;

        // btnClose
        btnClose.BackColor = Color.FromArgb(158, 158, 158);
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White;
        btnClose.Location = new Point(10, 11);
        btnClose.Size = new Size(70, 34);
        btnClose.Text = "بستن";
        btnClose.Cursor = Cursors.Hand;
        btnClose.Click += btnClose_Click;

        // ValidateOrderForm
        BackColor = Color.White;
        ClientSize = new Size(480, 360);
        Controls.Add(pnlHeader);
        Controls.Add(grpInfo);
        Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "تایید سفارش";
    }

    private static void AddInfoRow(GroupBox grp, string caption, out Label lblCaption, out Label lblValue, int top)
    {
        lblCaption = new Label { AutoSize = true, Location = new Point(10, top), Text = caption, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        lblValue = new Label { AutoSize = true, Location = new Point(140, top), Text = "...", ForeColor = Color.FromArgb(33, 33, 33) };
        grp.Controls.Add(lblCaption);
        grp.Controls.Add(lblValue);
    }

    private Panel pnlHeader;
    private Label lblTitleHeader;
    private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId;
    private Label lblOrderIdCaption, lblOrderId;
    private Label lblCustomerNameCaption, lblCustomerName;
    private Label lblCustomerEmailCaption, lblCustomerEmail;
    private Label lblQuantityCaption, lblQuantity;
    private Panel pnlButtons;
    private Button btnApprove;
    private Button btnReject;
    private Button btnClose;
}
