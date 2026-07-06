namespace Camunda.Appp
{
    partial class LeaveRequestForm
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(200, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "درخواست مرخصی جدید";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(280, 70);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 15);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "نام کارمند:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(50, 67);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmployeeName.Size = new System.Drawing.Size(220, 23);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(280, 110);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStartDate.Size = new System.Drawing.Size(100, 15);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "تاریخ شروع:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(50, 105);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpStartDate.Size = new System.Drawing.Size(220, 23);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(280, 150);
            this.lblDays.Name = "lblDays";
            this.lblDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDays.Size = new System.Drawing.Size(100, 15);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "تعداد روزها:";
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(50, 145);
            this.numDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDays.Name = "numDays";
            this.numDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numDays.Size = new System.Drawing.Size(220, 23);
            this.numDays.TabIndex = 6;
            this.numDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(280, 190);
            this.lblReason.Name = "lblReason";
            this.lblReason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReason.Size = new System.Drawing.Size(100, 15);
            this.lblReason.TabIndex = 7;
            this.lblReason.Text = "دلیل مرخصی:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(50, 185);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReason.Size = new System.Drawing.Size(220, 80);
            this.txtReason.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(190, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSubmit.Size = new System.Drawing.Size(130, 40);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "ثبت درخواست";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(50, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LeaveRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.numDays);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LeaveRequestForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت درخواست مرخصی";
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}