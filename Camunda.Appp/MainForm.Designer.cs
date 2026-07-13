namespace Camunda.Appp
{
    partial class MainForm
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
            btnEmployeeRequest = new Button();
            btnManagerView = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(95, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.Yes;
            lblTitle.Size = new Size(299, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "سیستم درخواست مرخصی";
            // 
            // btnEmployeeRequest
            // 
            btnEmployeeRequest.BackColor = Color.FromArgb(0, 120, 215);
            btnEmployeeRequest.FlatAppearance.BorderSize = 0;
            btnEmployeeRequest.FlatStyle = FlatStyle.Flat;
            btnEmployeeRequest.Font = new Font("Tahoma", 10F);
            btnEmployeeRequest.ForeColor = Color.White;
            btnEmployeeRequest.Location = new Point(70, 94);
            btnEmployeeRequest.Name = "btnEmployeeRequest";
            btnEmployeeRequest.RightToLeft = RightToLeft.Yes;
            btnEmployeeRequest.Size = new Size(260, 47);
            btnEmployeeRequest.TabIndex = 1;
            btnEmployeeRequest.Text = "ثبت درخواست مرخصی (کارمند)";
            btnEmployeeRequest.UseVisualStyleBackColor = false;
            btnEmployeeRequest.Click += BtnEmployeeRequest_Click;
            // 
            // btnManagerView
            // 
            btnManagerView.BackColor = Color.FromArgb(16, 124, 16);
            btnManagerView.FlatAppearance.BorderSize = 0;
            btnManagerView.FlatStyle = FlatStyle.Flat;
            btnManagerView.Font = new Font("Tahoma", 10F);
            btnManagerView.ForeColor = Color.White;
            btnManagerView.Location = new Point(70, 159);
            btnManagerView.Name = "btnManagerView";
            btnManagerView.RightToLeft = RightToLeft.Yes;
            btnManagerView.Size = new Size(260, 47);
            btnManagerView.TabIndex = 2;
            btnManagerView.Text = "مدیریت درخواست‌ها (مدیر)";
            btnManagerView.UseVisualStyleBackColor = false;
            btnManagerView.Click += BtnManagerView_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Magenta;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 227);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(260, 47);
            button1.TabIndex = 3;
            button1.Text = "مدیریت رول (مدیر)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 318);
            Controls.Add(button1);
            Controls.Add(btnManagerView);
            Controls.Add(btnEmployeeRequest);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سیستم مدیریت مرخصی - Camunda 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmployeeRequest;
        private System.Windows.Forms.Button btnManagerView;
        private Button button1;
    }
}