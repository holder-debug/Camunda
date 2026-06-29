namespace Camunda.App.Forms;

// ─── CreateInvoiceForm.Designer ────────────────────────────────────────────────
partial class CreateInvoiceForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblTitleHeader = new Label();
        grpInfo = new GroupBox();
        lblProcessIdCaption = new Label(); lblProcessId = new Label();
        lblOrderIdCaption = new Label(); lblOrderId = new Label();
        lblCustomerNameCaption = new Label(); lblCustomerName = new Label();
        lblQuantityCaption = new Label(); lblQuantity = new Label();
        lblInvoiceIdCaption = new Label(); lblInvoiceId = new Label();
        lblInvoiceDateCaption = new Label(); lblInvoiceDate = new Label();
        pnlButtons = new Panel();
        btnConfirm = new Button(); btnClose = new Button();

        pnlHeader.BackColor = Color.FromArgb(0, 96, 100);
        pnlHeader.Controls.Add(lblTitleHeader);
        pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 55;

        lblTitleHeader.Dock = DockStyle.Fill;
        lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White;
        lblTitleHeader.Text = "🧾  صدور فاکتور - Create Invoice";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        grpInfo.Location = new Point(20, 70); grpInfo.Size = new Size(440, 220);
        grpInfo.Text = "اطلاعات فاکتور"; grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

        SetLabel(lblProcessIdCaption, "شناسه پروسه:", 10, 25); SetLabel(lblProcessId, "...", 160, 25);
        SetLabel(lblOrderIdCaption, "شناسه سفارش:", 10, 60); SetLabel(lblOrderId, "...", 160, 60);
        SetLabel(lblCustomerNameCaption, "نام مشتری:", 10, 95); SetLabel(lblCustomerName, "...", 160, 95);
        SetLabel(lblQuantityCaption, "تعداد:", 10, 130); SetLabel(lblQuantity, "...", 160, 130);
        SetLabel(lblInvoiceIdCaption, "شماره فاکتور:", 10, 165); 
        lblInvoiceId.AutoSize = true; lblInvoiceId.Location = new Point(160, 165);
        lblInvoiceId.Font = new Font("Segoe UI", 10F, FontStyle.Bold); lblInvoiceId.ForeColor = Color.FromArgb(0, 96, 100);
        SetLabel(lblInvoiceDateCaption, "تاریخ:", 10, 195); SetLabel(lblInvoiceDate, "...", 160, 195);

        grpInfo.Controls.AddRange(new Control[] { lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName, lblQuantityCaption, lblQuantity, lblInvoiceIdCaption, lblInvoiceId, lblInvoiceDateCaption, lblInvoiceDate });

        pnlButtons.BackColor = Color.FromArgb(245, 245, 245);
        pnlButtons.Controls.Add(btnConfirm); pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom; pnlButtons.Height = 55;

        btnConfirm.BackColor = Color.FromArgb(0, 96, 100); btnConfirm.FlatStyle = FlatStyle.Flat; btnConfirm.FlatAppearance.BorderSize = 0;
        btnConfirm.ForeColor = Color.White; btnConfirm.Location = new Point(240, 11); btnConfirm.Size = new Size(140, 34);
        btnConfirm.Text = "✔  صدور فاکتور"; btnConfirm.Cursor = Cursors.Hand; btnConfirm.Click += btnConfirm_Click;

        btnClose.BackColor = Color.FromArgb(158, 158, 158); btnClose.FlatStyle = FlatStyle.Flat; btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White; btnClose.Location = new Point(10, 11); btnClose.Size = new Size(90, 34);
        btnClose.Text = "بستن"; btnClose.Cursor = Cursors.Hand; btnClose.Click += btnClose_Click;

        BackColor = Color.White; ClientSize = new Size(480, 370);
        Controls.Add(pnlHeader); Controls.Add(grpInfo); Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "صدور فاکتور";
    }

    private static void SetLabel(Label lbl, string text, int x, int y) { lbl.AutoSize = true; lbl.Location = new Point(x, y); lbl.Text = text; }

    private Panel pnlHeader; private Label lblTitleHeader; private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId;
    private Label lblCustomerNameCaption, lblCustomerName, lblQuantityCaption, lblQuantity;
    private Label lblInvoiceIdCaption, lblInvoiceId, lblInvoiceDateCaption, lblInvoiceDate;
    private Panel pnlButtons; private Button btnConfirm, btnClose;
}

// ─── ShipOrderForm.Designer ────────────────────────────────────────────────────
partial class ShipOrderForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        pnlHeader = new Panel(); lblTitleHeader = new Label();
        grpInfo = new GroupBox();
        lblProcessIdCaption = new Label(); lblProcessId = new Label();
        lblOrderIdCaption = new Label(); lblOrderId = new Label();
        lblCustomerNameCaption = new Label(); lblCustomerName = new Label();
        lblInvoiceIdCaption = new Label(); lblInvoiceId = new Label();
        grpShipping = new GroupBox();
        lblTrackingCaption = new Label(); txtTrackingCode = new TextBox();
        pnlButtons = new Panel(); btnShip = new Button(); btnClose = new Button();

        pnlHeader.BackColor = Color.FromArgb(1, 87, 155);
        pnlHeader.Controls.Add(lblTitleHeader); pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 55;
        lblTitleHeader.Dock = DockStyle.Fill; lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White; lblTitleHeader.Text = "🚚  ارسال سفارش - Ship Order";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        grpInfo.Location = new Point(20, 70); grpInfo.Size = new Size(440, 155);
        grpInfo.Text = "اطلاعات سفارش"; grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        SetLabel(lblProcessIdCaption, "شناسه پروسه:", 10, 25); SetLabel(lblProcessId, "...", 160, 25);
        SetLabel(lblOrderIdCaption, "شناسه سفارش:", 10, 60); SetLabel(lblOrderId, "...", 160, 60);
        SetLabel(lblCustomerNameCaption, "نام مشتری:", 10, 95); SetLabel(lblCustomerName, "...", 160, 95);
        SetLabel(lblInvoiceIdCaption, "شماره فاکتور:", 10, 125); SetLabel(lblInvoiceId, "...", 160, 125);
        grpInfo.Controls.AddRange(new Control[] { lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName, lblInvoiceIdCaption, lblInvoiceId });

        grpShipping.Location = new Point(20, 235); grpShipping.Size = new Size(440, 70);
        grpShipping.Text = "اطلاعات ارسال"; grpShipping.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTrackingCaption.AutoSize = true; lblTrackingCaption.Location = new Point(10, 30); lblTrackingCaption.Text = "کد رهگیری:";
        txtTrackingCode.Location = new Point(120, 27); txtTrackingCode.Size = new Size(200, 23);
        grpShipping.Controls.AddRange(new Control[] { lblTrackingCaption, txtTrackingCode });

        pnlButtons.BackColor = Color.FromArgb(245, 245, 245); pnlButtons.Controls.Add(btnShip); pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom; pnlButtons.Height = 55;

        btnShip.BackColor = Color.FromArgb(1, 87, 155); btnShip.FlatStyle = FlatStyle.Flat; btnShip.FlatAppearance.BorderSize = 0;
        btnShip.ForeColor = Color.White; btnShip.Location = new Point(240, 11); btnShip.Size = new Size(130, 34);
        btnShip.Text = "🚚  ثبت ارسال"; btnShip.Cursor = Cursors.Hand; btnShip.Click += btnShip_Click;

        btnClose.BackColor = Color.FromArgb(158, 158, 158); btnClose.FlatStyle = FlatStyle.Flat; btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White; btnClose.Location = new Point(10, 11); btnClose.Size = new Size(90, 34);
        btnClose.Text = "بستن"; btnClose.Cursor = Cursors.Hand; btnClose.Click += btnClose_Click;

        BackColor = Color.White; ClientSize = new Size(480, 380);
        Controls.Add(pnlHeader); Controls.Add(grpInfo); Controls.Add(grpShipping); Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "ارسال سفارش";
    }

    private static void SetLabel(Label lbl, string text, int x, int y) { lbl.AutoSize = true; lbl.Location = new Point(x, y); lbl.Text = text; }

    private Panel pnlHeader; private Label lblTitleHeader; private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId;
    private Label lblCustomerNameCaption, lblCustomerName, lblInvoiceIdCaption, lblInvoiceId;
    private GroupBox grpShipping; private Label lblTrackingCaption; private TextBox txtTrackingCode;
    private Panel pnlButtons; private Button btnShip, btnClose;
}

// ─── RejectOrderForm.Designer ──────────────────────────────────────────────────
partial class RejectOrderForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        pnlHeader = new Panel(); lblTitleHeader = new Label();
        grpInfo = new GroupBox();
        lblProcessIdCaption = new Label(); lblProcessId = new Label();
        lblOrderIdCaption = new Label(); lblOrderId = new Label();
        lblCustomerNameCaption = new Label(); lblCustomerName = new Label();
        grpReason = new GroupBox(); lblReasonCaption = new Label(); txtRejectReason = new TextBox();
        pnlButtons = new Panel(); btnConfirmReject = new Button(); btnClose = new Button();

        pnlHeader.BackColor = Color.FromArgb(183, 28, 28);
        pnlHeader.Controls.Add(lblTitleHeader); pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 55;
        lblTitleHeader.Dock = DockStyle.Fill; lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White; lblTitleHeader.Text = "❌  رد سفارش - Reject Order";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        grpInfo.Location = new Point(20, 70); grpInfo.Size = new Size(440, 120);
        grpInfo.Text = "اطلاعات سفارش"; grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        SetLabel(lblProcessIdCaption, "شناسه پروسه:", 10, 25); SetLabel(lblProcessId, "...", 160, 25);
        SetLabel(lblOrderIdCaption, "شناسه سفارش:", 10, 60); SetLabel(lblOrderId, "...", 160, 60);
        SetLabel(lblCustomerNameCaption, "نام مشتری:", 10, 90); SetLabel(lblCustomerName, "...", 160, 90);
        grpInfo.Controls.AddRange(new Control[] { lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName });

        grpReason.Location = new Point(20, 200); grpReason.Size = new Size(440, 80);
        grpReason.Text = "دلیل رد"; grpReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblReasonCaption.AutoSize = true; lblReasonCaption.Location = new Point(10, 30); lblReasonCaption.Text = "دلیل:";
        txtRejectReason.Location = new Point(70, 27); txtRejectReason.Size = new Size(350, 23); txtRejectReason.Text = "سفارش معتبر نیست";
        grpReason.Controls.AddRange(new Control[] { lblReasonCaption, txtRejectReason });

        pnlButtons.BackColor = Color.FromArgb(245, 245, 245); pnlButtons.Controls.Add(btnConfirmReject); pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom; pnlButtons.Height = 55;

        btnConfirmReject.BackColor = Color.FromArgb(183, 28, 28); btnConfirmReject.FlatStyle = FlatStyle.Flat; btnConfirmReject.FlatAppearance.BorderSize = 0;
        btnConfirmReject.ForeColor = Color.White; btnConfirmReject.Location = new Point(220, 11); btnConfirmReject.Size = new Size(150, 34);
        btnConfirmReject.Text = "✔  تایید رد سفارش"; btnConfirmReject.Cursor = Cursors.Hand; btnConfirmReject.Click += btnConfirmReject_Click;

        btnClose.BackColor = Color.FromArgb(158, 158, 158); btnClose.FlatStyle = FlatStyle.Flat; btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White; btnClose.Location = new Point(10, 11); btnClose.Size = new Size(90, 34);
        btnClose.Text = "بستن"; btnClose.Cursor = Cursors.Hand; btnClose.Click += btnClose_Click;

        BackColor = Color.White; ClientSize = new Size(480, 360);
        Controls.Add(pnlHeader); Controls.Add(grpInfo); Controls.Add(grpReason); Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "رد سفارش";
    }

    private static void SetLabel(Label lbl, string text, int x, int y) { lbl.AutoSize = true; lbl.Location = new Point(x, y); lbl.Text = text; }

    private Panel pnlHeader; private Label lblTitleHeader; private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName;
    private GroupBox grpReason; private Label lblReasonCaption; private TextBox txtRejectReason;
    private Panel pnlButtons; private Button btnConfirmReject, btnClose;
}

// ─── NotifyCustomerForm.Designer ───────────────────────────────────────────────
partial class NotifyCustomerForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        pnlHeader = new Panel(); lblTitleHeader = new Label();
        grpInfo = new GroupBox();
        lblProcessIdCaption = new Label(); lblProcessId = new Label();
        lblOrderIdCaption = new Label(); lblOrderId = new Label();
        lblCustomerNameCaption = new Label(); lblCustomerName = new Label();
        lblCustomerEmailCaption = new Label(); lblCustomerEmail = new Label();
        lblMessageCaption = new Label(); lblMessage = new Label();
        pnlButtons = new Panel(); btnSendNotify = new Button(); btnClose = new Button();

        pnlHeader.BackColor = Color.FromArgb(230, 81, 0);
        pnlHeader.Controls.Add(lblTitleHeader); pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 55;
        lblTitleHeader.Dock = DockStyle.Fill; lblTitleHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitleHeader.ForeColor = Color.White; lblTitleHeader.Text = "📧  اطلاع‌رسانی - Notify Customer";
        lblTitleHeader.TextAlign = ContentAlignment.MiddleCenter;

        grpInfo.Location = new Point(20, 70); grpInfo.Size = new Size(440, 200);
        grpInfo.Text = "اطلاعات مشتری"; grpInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        SetLabel(lblProcessIdCaption, "شناسه پروسه:", 10, 25); SetLabel(lblProcessId, "...", 160, 25);
        SetLabel(lblOrderIdCaption, "شناسه سفارش:", 10, 60); SetLabel(lblOrderId, "...", 160, 60);
        SetLabel(lblCustomerNameCaption, "نام مشتری:", 10, 95); SetLabel(lblCustomerName, "...", 160, 95);
        SetLabel(lblCustomerEmailCaption, "ایمیل:", 10, 130); SetLabel(lblCustomerEmail, "...", 160, 130);
        SetLabel(lblMessageCaption, "پیام:", 10, 165);
        lblMessage.AutoSize = false; lblMessage.Location = new Point(160, 162); lblMessage.Size = new Size(260, 30);
        lblMessage.Text = "متأسفانه کالای مورد نظر موجود نمی‌باشد.";
        lblMessage.ForeColor = Color.FromArgb(183, 28, 28); lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
        grpInfo.Controls.AddRange(new Control[] { lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId, lblCustomerNameCaption, lblCustomerName, lblCustomerEmailCaption, lblCustomerEmail, lblMessageCaption, lblMessage });

        pnlButtons.BackColor = Color.FromArgb(245, 245, 245); pnlButtons.Controls.Add(btnSendNotify); pnlButtons.Controls.Add(btnClose);
        pnlButtons.Dock = DockStyle.Bottom; pnlButtons.Height = 55;

        btnSendNotify.BackColor = Color.FromArgb(230, 81, 0); btnSendNotify.FlatStyle = FlatStyle.Flat; btnSendNotify.FlatAppearance.BorderSize = 0;
        btnSendNotify.ForeColor = Color.White; btnSendNotify.Location = new Point(220, 11); btnSendNotify.Size = new Size(150, 34);
        btnSendNotify.Text = "📧  ارسال اطلاع‌رسانی"; btnSendNotify.Cursor = Cursors.Hand; btnSendNotify.Click += btnSendNotify_Click;

        btnClose.BackColor = Color.FromArgb(158, 158, 158); btnClose.FlatStyle = FlatStyle.Flat; btnClose.FlatAppearance.BorderSize = 0;
        btnClose.ForeColor = Color.White; btnClose.Location = new Point(10, 11); btnClose.Size = new Size(90, 34);
        btnClose.Text = "بستن"; btnClose.Cursor = Cursors.Hand; btnClose.Click += btnClose_Click;

        BackColor = Color.White; ClientSize = new Size(480, 360);
        Controls.Add(pnlHeader); Controls.Add(grpInfo); Controls.Add(pnlButtons);
        Font = new Font("Segoe UI", 9F); FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "اطلاع‌رسانی به مشتری";
    }

    private static void SetLabel(Label lbl, string text, int x, int y) { lbl.AutoSize = true; lbl.Location = new Point(x, y); lbl.Text = text; }

    private Panel pnlHeader; private Label lblTitleHeader; private GroupBox grpInfo;
    private Label lblProcessIdCaption, lblProcessId, lblOrderIdCaption, lblOrderId;
    private Label lblCustomerNameCaption, lblCustomerName, lblCustomerEmailCaption, lblCustomerEmail;
    private Label lblMessageCaption, lblMessage;
    private Panel pnlButtons; private Button btnSendNotify, btnClose;
}
