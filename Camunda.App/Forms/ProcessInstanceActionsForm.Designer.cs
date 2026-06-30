namespace Camunda.App.Forms
{
    partial class ProcessInstanceActionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKey = new System.Windows.Forms.Label();
            this.txtProcessInstanceKey = new System.Windows.Forms.TextBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.lblCurrentState = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblKey
            //
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(290, 20);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(140, 17);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Process Instance Key:";
            //
            // txtProcessInstanceKey
            //
            this.txtProcessInstanceKey.Location = new System.Drawing.Point(40, 17);
            this.txtProcessInstanceKey.Name = "txtProcessInstanceKey";
            this.txtProcessInstanceKey.Size = new System.Drawing.Size(240, 23);
            this.txtProcessInstanceKey.TabIndex = 1;
            //
            // btnCheckStatus
            //
            this.btnCheckStatus.Location = new System.Drawing.Point(180, 55);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(120, 32);
            this.btnCheckStatus.TabIndex = 2;
            this.btnCheckStatus.Text = "بررسی وضعیت";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            //
            // lblCurrentState
            //
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCurrentState.Location = new System.Drawing.Point(40, 64);
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(60, 17);
            this.lblCurrentState.TabIndex = 3;
            this.lblCurrentState.Text = "وضعیت: -";
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(250, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "لغو اجرا (Cancel)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(40, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف کامل (Delete)";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // lblStatus
            //
            this.lblStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStatus.Location = new System.Drawing.Point(40, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 60);
            this.lblStatus.TabIndex = 6;
            //
            // ProcessInstanceActionsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.txtProcessInstanceKey);
            this.Controls.Add(this.lblKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessInstanceActionsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت Process Instance";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtProcessInstanceKey;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Label lblCurrentState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStatus;
    }
}
