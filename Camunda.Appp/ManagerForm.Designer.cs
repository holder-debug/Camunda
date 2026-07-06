namespace Camunda.Appp
{
    partial class ManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblProcessInstances = new Label();
            dgvRequests = new DataGridView();
            btnRefresh = new Button();
            btnApprove = new Button();
            btnReject = new Button();
            lblDetails = new Label();
            txtDetails = new TextBox();
            BtnEnd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(520, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.Yes;
            lblTitle.Size = new Size(291, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "مدیریت درخواست‌های مرخصی";
            // 
            // lblProcessInstances
            // 
            lblProcessInstances.AutoSize = true;
            lblProcessInstances.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblProcessInstances.Location = new Point(650, 60);
            lblProcessInstances.Name = "lblProcessInstances";
            lblProcessInstances.RightToLeft = RightToLeft.Yes;
            lblProcessInstances.Size = new Size(95, 17);
            lblProcessInstances.TabIndex = 1;
            lblProcessInstances.Text = "درخواست‌ها:";
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(50, 90);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RightToLeft = RightToLeft.Yes;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(700, 200);
            dgvRequests.TabIndex = 2;
            dgvRequests.SelectionChanged += DgvRequests_SelectionChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 120, 215);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Tahoma", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(50, 55);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RightToLeft = RightToLeft.Yes;
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "بارگذاری مجدد";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(16, 124, 16);
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Tahoma", 10F);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(520, 310);
            btnApprove.Name = "btnApprove";
            btnApprove.RightToLeft = RightToLeft.Yes;
            btnApprove.Size = new Size(110, 40);
            btnApprove.TabIndex = 4;
            btnApprove.Text = "تایید";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += BtnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(200, 50, 50);
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Tahoma", 10F);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(390, 310);
            btnReject.Name = "btnReject";
            btnReject.RightToLeft = RightToLeft.Yes;
            btnReject.Size = new Size(110, 40);
            btnReject.TabIndex = 5;
            btnReject.Text = "رد";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += BtnReject_Click;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblDetails.Location = new Point(650, 315);
            lblDetails.Name = "lblDetails";
            lblDetails.RightToLeft = RightToLeft.Yes;
            lblDetails.Size = new Size(129, 17);
            lblDetails.TabIndex = 6;
            lblDetails.Text = "جزئیات درخواست:";
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(50, 310);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.RightToLeft = RightToLeft.Yes;
            txtDetails.Size = new Size(320, 80);
            txtDetails.TabIndex = 7;
            // 
            // BtnEnd
            // 
            BtnEnd.BackColor = Color.FromArgb(0, 120, 215);
            BtnEnd.FlatAppearance.BorderSize = 0;
            BtnEnd.FlatStyle = FlatStyle.Flat;
            BtnEnd.Font = new Font("Tahoma", 9F);
            BtnEnd.ForeColor = Color.White;
            BtnEnd.Location = new Point(390, 356);
            BtnEnd.Name = "BtnEnd";
            BtnEnd.RightToLeft = RightToLeft.Yes;
            BtnEnd.Size = new Size(240, 40);
            BtnEnd.TabIndex = 8;
            BtnEnd.Text = "خاتمه";
            BtnEnd.UseVisualStyleBackColor = false;
            BtnEnd.Click += BtnEnd_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(BtnEnd);
            Controls.Add(txtDetails);
            Controls.Add(lblDetails);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(btnRefresh);
            Controls.Add(dgvRequests);
            Controls.Add(lblProcessInstances);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagerForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل مدیریت - تایید مرخصی";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProcessInstances;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private Button BtnEnd;
    }
}