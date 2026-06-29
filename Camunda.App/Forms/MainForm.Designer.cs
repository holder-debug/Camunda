namespace Camunda.App.Forms;

partial class MainForm
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
        pnlToolbar = new Panel();
        btnNewOrder = new Button();
        btnRefresh = new Button();
        btnProcessTask = new Button();
        dgvProcesses = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colBusinessKey = new DataGridViewTextBoxColumn();
        colState = new DataGridViewTextBoxColumn();
        colStartTime = new DataGridViewTextBoxColumn();
        colCurrentTask = new DataGridViewTextBoxColumn();
        pnlStatus = new Panel();
        lblStatus = new Label();

        // pnlHeader
        pnlHeader.BackColor = Color.FromArgb(30, 136, 229);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 60;

        // lblTitle
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Text = "سیستم مدیریت سفارشات - Camunda";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        // pnlToolbar
        pnlToolbar.BackColor = Color.White;
        pnlToolbar.Controls.Add(btnNewOrder);
        pnlToolbar.Controls.Add(btnRefresh);
        pnlToolbar.Controls.Add(btnProcessTask);
        pnlToolbar.Dock = DockStyle.Top;
        pnlToolbar.Height = 50;
        pnlToolbar.Padding = new Padding(10, 8, 10, 8);

        // btnNewOrder
        btnNewOrder.BackColor = Color.FromArgb(46, 125, 50);
        btnNewOrder.FlatStyle = FlatStyle.Flat;
        btnNewOrder.FlatAppearance.BorderSize = 0;
        btnNewOrder.ForeColor = Color.White;
        btnNewOrder.Location = new Point(10, 8);
        btnNewOrder.Size = new Size(140, 34);
        btnNewOrder.Text = "➕  سفارش جدید";
        btnNewOrder.Cursor = Cursors.Hand;
        btnNewOrder.Click += btnNewOrder_Click;

        // btnRefresh
        btnRefresh.BackColor = Color.FromArgb(21, 101, 192);
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.ForeColor = Color.White;
        btnRefresh.Location = new Point(160, 8);
        btnRefresh.Size = new Size(130, 34);
        btnRefresh.Text = "🔄  بروزرسانی";
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.Click += btnRefresh_Click;

        // btnProcessTask
        btnProcessTask.BackColor = Color.FromArgb(230, 81, 0);
        btnProcessTask.FlatStyle = FlatStyle.Flat;
        btnProcessTask.FlatAppearance.BorderSize = 0;
        btnProcessTask.ForeColor = Color.White;
        btnProcessTask.Location = new Point(300, 8);
        btnProcessTask.Size = new Size(140, 34);
        btnProcessTask.Text = "▶  پردازش task";
        btnProcessTask.Cursor = Cursors.Hand;
        btnProcessTask.Enabled = false;
        btnProcessTask.Click += btnProcessTask_Click;

        // dgvProcesses
        dgvProcesses.AllowUserToAddRows = false;
        dgvProcesses.AllowUserToDeleteRows = false;
        dgvProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProcesses.BackgroundColor = Color.White;
        dgvProcesses.BorderStyle = BorderStyle.None;
        dgvProcesses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 136, 229);
        dgvProcesses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvProcesses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProcesses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 240, 254);
        dgvProcesses.Columns.AddRange(colId, colBusinessKey, colState, colStartTime, colCurrentTask);
        dgvProcesses.Dock = DockStyle.Fill;
        dgvProcesses.MultiSelect = false;
        dgvProcesses.ReadOnly = true;
        dgvProcesses.RowHeadersVisible = false;
        dgvProcesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProcesses.SelectionChanged += dgvProcesses_SelectionChanged;

        // Columns
        colId.HeaderText = "شناسه";
        colId.Name = "colId";
        colId.FillWeight = 30;

        colBusinessKey.HeaderText = "کلید کسب‌وکار";
        colBusinessKey.Name = "colBusinessKey";
        colBusinessKey.FillWeight = 20;

        colState.HeaderText = "وضعیت";
        colState.Name = "colState";
        colState.FillWeight = 15;

        colStartTime.HeaderText = "زمان شروع";
        colStartTime.Name = "colStartTime";
        colStartTime.FillWeight = 25;

        colCurrentTask.HeaderText = "مرحله فعلی";
        colCurrentTask.Name = "colCurrentTask";
        colCurrentTask.FillWeight = 20;

        // pnlStatus
        pnlStatus.BackColor = Color.FromArgb(224, 224, 224);
        pnlStatus.Controls.Add(lblStatus);
        pnlStatus.Dock = DockStyle.Bottom;
        pnlStatus.Height = 28;

        // lblStatus
        lblStatus.Dock = DockStyle.Fill;
        lblStatus.Padding = new Padding(10, 0, 0, 0);
        lblStatus.Text = "آماده";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;

        // MainForm
        ClientSize = new Size(960, 600);
        Controls.Add(dgvProcesses);
        Controls.Add(pnlToolbar);
        Controls.Add(pnlHeader);
        Controls.Add(pnlStatus);
        Font = new Font("Segoe UI", 9F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "مدیریت سفارشات - Camunda";
    }

    private Panel pnlHeader;
    private Label lblTitle;
    private Panel pnlToolbar;
    private Button btnNewOrder;
    private Button btnRefresh;
    private Button btnProcessTask;
    private DataGridView dgvProcesses;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colBusinessKey;
    private DataGridViewTextBoxColumn colState;
    private DataGridViewTextBoxColumn colStartTime;
    private DataGridViewTextBoxColumn colCurrentTask;
    private Panel pnlStatus;
    private Label lblStatus;
}
