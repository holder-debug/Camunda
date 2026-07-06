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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmployeeRequest = new System.Windows.Forms.Button();
            this.btnManagerView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(95, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(210, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "سیستم درخواست مرخصی";
            // 
            // btnEmployeeRequest
            // 
            this.btnEmployeeRequest.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnEmployeeRequest.FlatAppearance.BorderSize = 0;
            this.btnEmployeeRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRequest.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEmployeeRequest.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRequest.Location = new System.Drawing.Point(70, 100);
            this.btnEmployeeRequest.Name = "btnEmployeeRequest";
            this.btnEmployeeRequest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEmployeeRequest.Size = new System.Drawing.Size(260, 50);
            this.btnEmployeeRequest.TabIndex = 1;
            this.btnEmployeeRequest.Text = "ثبت درخواست مرخصی (کارمند)";
            this.btnEmployeeRequest.UseVisualStyleBackColor = false;
            this.btnEmployeeRequest.Click += new System.EventHandler(this.BtnEmployeeRequest_Click);
            // 
            // btnManagerView
            // 
            this.btnManagerView.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnManagerView.FlatAppearance.BorderSize = 0;
            this.btnManagerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerView.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnManagerView.ForeColor = System.Drawing.Color.White;
            this.btnManagerView.Location = new System.Drawing.Point(70, 170);
            this.btnManagerView.Name = "btnManagerView";
            this.btnManagerView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnManagerView.Size = new System.Drawing.Size(260, 50);
            this.btnManagerView.TabIndex = 2;
            this.btnManagerView.Text = "مدیریت درخواست‌ها (مدیر)";
            this.btnManagerView.UseVisualStyleBackColor = false;
            this.btnManagerView.Click += new System.EventHandler(this.BtnManagerView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.btnManagerView);
            this.Controls.Add(this.btnEmployeeRequest);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت مرخصی - Camunda 8";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmployeeRequest;
        private System.Windows.Forms.Button btnManagerView;
    }
}