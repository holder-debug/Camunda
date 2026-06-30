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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        pnlHeader = new Panel();
        lblTitle = new Label();
        pnlToolbar = new Panel();
        btnDelete = new Button();
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
        pnlHeader.SuspendLayout();
        pnlToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProcesses).BeginInit();
        pnlStatus.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 136, 229);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(960, 60);
        pnlHeader.TabIndex = 2;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(960, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "سیستم مدیریت سفارشات - Camunda";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlToolbar
        // 
        pnlToolbar.BackColor = Color.White;
        pnlToolbar.Controls.Add(btnDelete);
        pnlToolbar.Controls.Add(btnNewOrder);
        pnlToolbar.Controls.Add(btnRefresh);
        pnlToolbar.Controls.Add(btnProcessTask);
        pnlToolbar.Dock = DockStyle.Top;
        pnlToolbar.Location = new Point(0, 60);
        pnlToolbar.Name = "pnlToolbar";
        pnlToolbar.Padding = new Padding(10, 8, 10, 8);
        pnlToolbar.Size = new Size(960, 50);
        pnlToolbar.TabIndex = 1;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Red;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.Enabled = false;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(805, 8);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(143, 34);
        btnDelete.TabIndex = 3;
        btnDelete.Text = "▶ حذف پردازش";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Enabled = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnNewOrder
        // 
        btnNewOrder.BackColor = Color.FromArgb(46, 125, 50);
        btnNewOrder.Cursor = Cursors.Hand;
        btnNewOrder.FlatAppearance.BorderSize = 0;
        btnNewOrder.FlatStyle = FlatStyle.Flat;
        btnNewOrder.ForeColor = Color.White;
        btnNewOrder.Location = new Point(10, 8);
        btnNewOrder.Name = "btnNewOrder";
        btnNewOrder.Size = new Size(140, 34);
        btnNewOrder.TabIndex = 0;
        btnNewOrder.Text = "➕  سفارش جدید";
        btnNewOrder.UseVisualStyleBackColor = false;
        btnNewOrder.Click += btnNewOrder_Click;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(21, 101, 192);
        btnRefresh.Cursor = Cursors.Hand;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.ForeColor = Color.White;
        btnRefresh.Location = new Point(160, 8);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(130, 34);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "🔄  بروزرسانی";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnProcessTask
        // 
        btnProcessTask.BackColor = Color.FromArgb(230, 81, 0);
        btnProcessTask.Cursor = Cursors.Hand;
        btnProcessTask.Enabled = false;
        btnProcessTask.FlatAppearance.BorderSize = 0;
        btnProcessTask.FlatStyle = FlatStyle.Flat;
        btnProcessTask.ForeColor = Color.White;
        btnProcessTask.Location = new Point(300, 8);
        btnProcessTask.Name = "btnProcessTask";
        btnProcessTask.Size = new Size(140, 34);
        btnProcessTask.TabIndex = 2;
        btnProcessTask.Text = "▶  پردازش task";
        btnProcessTask.UseVisualStyleBackColor = false;
        btnProcessTask.Click += btnProcessTask_Click;
        // 
        // dgvProcesses
        // 
        dgvProcesses.AllowUserToAddRows = false;
        dgvProcesses.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 240, 254);
        dgvProcesses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProcesses.BackgroundColor = Color.White;
        dgvProcesses.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 136, 229);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProcesses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProcesses.Columns.AddRange(new DataGridViewColumn[] { colId, colBusinessKey, colState, colStartTime, colCurrentTask });
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvProcesses.DefaultCellStyle = dataGridViewCellStyle3;
        dgvProcesses.Dock = DockStyle.Fill;
        dgvProcesses.Location = new Point(0, 110);
        dgvProcesses.MultiSelect = false;
        dgvProcesses.Name = "dgvProcesses";
        dgvProcesses.ReadOnly = true;
        dgvProcesses.RowHeadersVisible = false;
        dgvProcesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProcesses.Size = new Size(960, 462);
        dgvProcesses.TabIndex = 0;
        dgvProcesses.SelectionChanged += dgvProcesses_SelectionChanged;
        // 
        // colId
        // 
        colId.FillWeight = 30F;
        colId.HeaderText = "شناسه";
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colBusinessKey
        // 
        colBusinessKey.FillWeight = 20F;
        colBusinessKey.HeaderText = "کلید کسب‌وکار";
        colBusinessKey.Name = "colBusinessKey";
        colBusinessKey.ReadOnly = true;
        // 
        // colState
        // 
        colState.FillWeight = 15F;
        colState.HeaderText = "وضعیت";
        colState.Name = "colState";
        colState.ReadOnly = true;
        // 
        // colStartTime
        // 
        colStartTime.FillWeight = 25F;
        colStartTime.HeaderText = "زمان شروع";
        colStartTime.Name = "colStartTime";
        colStartTime.ReadOnly = true;
        // 
        // colCurrentTask
        // 
        colCurrentTask.FillWeight = 20F;
        colCurrentTask.HeaderText = "مرحله فعلی";
        colCurrentTask.Name = "colCurrentTask";
        colCurrentTask.ReadOnly = true;
        // 
        // pnlStatus
        // 
        pnlStatus.BackColor = Color.FromArgb(224, 224, 224);
        pnlStatus.Controls.Add(lblStatus);
        pnlStatus.Dock = DockStyle.Bottom;
        pnlStatus.Location = new Point(0, 572);
        pnlStatus.Name = "pnlStatus";
        pnlStatus.Size = new Size(960, 28);
        pnlStatus.TabIndex = 3;
        // 
        // lblStatus
        // 
        lblStatus.Dock = DockStyle.Fill;
        lblStatus.Location = new Point(0, 0);
        lblStatus.Name = "lblStatus";
        lblStatus.Padding = new Padding(10, 0, 0, 0);
        lblStatus.Size = new Size(960, 28);
        lblStatus.TabIndex = 0;
        lblStatus.Text = "آماده";
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainForm
        // 
        ClientSize = new Size(960, 600);
        Controls.Add(dgvProcesses);
        Controls.Add(pnlToolbar);
        Controls.Add(pnlHeader);
        Controls.Add(pnlStatus);
        Font = new Font("Segoe UI", 9F);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "مدیریت سفارشات - Camunda";
        pnlHeader.ResumeLayout(false);
        pnlToolbar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvProcesses).EndInit();
        pnlStatus.ResumeLayout(false);
        ResumeLayout(false);
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
    private Button btnDelete;
}
