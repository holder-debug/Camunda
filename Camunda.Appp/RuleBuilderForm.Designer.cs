 
namespace Camunda.Appp
{
    partial class RuleBuilderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            grpRuleInfo = new GroupBox();
            lblRuleName = new Label();
            txtRuleName = new TextBox();
            lblField = new Label();
            cmbField = new ComboBox();
            lblOperator = new Label();
            cmbOperator = new ComboBox();
            lblValue = new Label();
            txtValue = new TextBox();
            lblCondition = new Label();
            txtCondition = new TextBox();
            btnAddCondition = new Button();
            btnClearConditions = new Button();
            grpConditions = new GroupBox();
            lstConditions = new ListBox();
            btnGenerateJson = new Button();
            txtJsonOutput = new TextBox();
            btnCopyJson = new Button();
            btnSaveJson = new Button();
            grpRuleInfo.SuspendLayout();
            grpConditions.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
           // lblTitle.Font = new("Tahoma", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(280, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ساخت قانون با RulesEngine";
            // 
            // grpRuleInfo
            // 
            grpRuleInfo.Controls.Add(txtCondition);
            grpRuleInfo.Controls.Add(lblCondition);
            grpRuleInfo.Controls.Add(txtValue);
            grpRuleInfo.Controls.Add(lblValue);
            grpRuleInfo.Controls.Add(cmbOperator);
            grpRuleInfo.Controls.Add(lblOperator);
            grpRuleInfo.Controls.Add(cmbField);
            grpRuleInfo.Controls.Add(lblField);
            grpRuleInfo.Controls.Add(txtRuleName);
            grpRuleInfo.Controls.Add(lblRuleName);
            grpRuleInfo.Controls.Add(btnAddCondition);
            grpRuleInfo.Controls.Add(btnClearConditions);
            grpRuleInfo.Location = new Point(20, 50);
            grpRuleInfo.Name = "grpRuleInfo";
            grpRuleInfo.RightToLeft = RightToLeft.Yes;
            grpRuleInfo.Size = new Size(450, 180);
            grpRuleInfo.TabIndex = 1;
            grpRuleInfo.TabStop = false;
            grpRuleInfo.Text = "اطلاعات قانون";
            // 
            // lblRuleName
            // 
            lblRuleName.AutoSize = true;
            lblRuleName.Font = new Font("Tahoma", 9F);
            lblRuleName.Location = new Point(380, 25);
            lblRuleName.Name = "lblRuleName";
            lblRuleName.Size = new Size(64, 14);
            lblRuleName.TabIndex = 0;
            lblRuleName.Text = "نام قانون:";
            // 
            // txtRuleName
            // 
            txtRuleName.Location = new Point(150, 22);
            txtRuleName.Name = "txtRuleName";
            txtRuleName.RightToLeft = RightToLeft.Yes;
            txtRuleName.Size = new Size(220, 23);
            txtRuleName.TabIndex = 1;
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Font = new Font("Tahoma", 9F);
            lblField.Location = new Point(390, 55);
            lblField.Name = "lblField";
            lblField.Size = new Size(54, 14);
            lblField.TabIndex = 2;
            lblField.Text = "فیلد:";
            // 
            // cmbField
            // 
            cmbField.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbField.Items.AddRange(new object[] { "days", "userRole", "isHoliday", "employeeName", "salary", "experience" });
            cmbField.Location = new Point(240, 52);
            cmbField.Name = "cmbField";
            cmbField.RightToLeft = RightToLeft.Yes;
            cmbField.Size = new Size(130, 23);
            cmbField.TabIndex = 3;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Tahoma", 9F);
            lblOperator.Location = new Point(390, 85);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(56, 14);
            lblOperator.TabIndex = 4;
            lblOperator.Text = "عملگر:";
            // 
            // cmbOperator
            // 
            cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperator.Items.AddRange(new object[] {
                "==", "!=", ">", "<", ">=", "<=",
                "Contains", "StartsWith", "EndsWith"
            });
            cmbOperator.Location = new Point(240, 82);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.RightToLeft = RightToLeft.Yes;
            cmbOperator.Size = new Size(130, 23);
            cmbOperator.TabIndex = 5;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Tahoma", 9F);
            lblValue.Location = new Point(380, 115);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(62, 14);
            lblValue.TabIndex = 6;
            lblValue.Text = "مقدار:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(150, 112);
            txtValue.Name = "txtValue";
            txtValue.RightToLeft = RightToLeft.Yes;
            txtValue.Size = new Size(220, 23);
            txtValue.TabIndex = 7;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Tahoma", 9F);
            lblCondition.Location = new Point(390, 145);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(67, 14);
            lblCondition.TabIndex = 8;
            lblCondition.Text = "شرط کامل:";
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(10, 142);
            txtCondition.Name = "txtCondition";
            txtCondition.ReadOnly = true;
            txtCondition.RightToLeft = RightToLeft.Yes;
            txtCondition.Size = new Size(360, 23);
            txtCondition.TabIndex = 9;
            // 
            // btnAddCondition
            // 
            btnAddCondition.BackColor = Color.FromArgb(16, 124, 16);
            btnAddCondition.FlatAppearance.BorderSize = 0;
            btnAddCondition.FlatStyle = FlatStyle.Flat;
            btnAddCondition.Font = new Font("Tahoma", 9F);
            btnAddCondition.ForeColor = Color.White;
            btnAddCondition.Location = new Point(10, 10);
            btnAddCondition.Name = "btnAddCondition";
            btnAddCondition.Size = new Size(120, 25);
            btnAddCondition.TabIndex = 10;
            btnAddCondition.Text = "افزودن شرط";
            btnAddCondition.UseVisualStyleBackColor = false;
            btnAddCondition.Click += BtnAddCondition_Click;
            // 
            // btnClearConditions
            // 
            btnClearConditions.BackColor = Color.FromArgb(200, 50, 50);
            btnClearConditions.FlatAppearance.BorderSize = 0;
            btnClearConditions.FlatStyle = FlatStyle.Flat;
            btnClearConditions.Font = new Font("Tahoma", 9F);
            btnClearConditions.ForeColor = Color.White;
            btnClearConditions.Location = new Point(10, 40);
            btnClearConditions.Name = "btnClearConditions";
            btnClearConditions.Size = new Size(120, 25);
            btnClearConditions.TabIndex = 11;
            btnClearConditions.Text = "پاک کردن";
            btnClearConditions.UseVisualStyleBackColor = false;
            btnClearConditions.Click += BtnClearConditions_Click;
            // 
            // grpConditions
            // 
            grpConditions.Controls.Add(lstConditions);
            grpConditions.Location = new Point(480, 50);
            grpConditions.Name = "grpConditions";
            grpConditions.RightToLeft = RightToLeft.Yes;
            grpConditions.Size = new Size(280, 180);
            grpConditions.TabIndex = 2;
            grpConditions.TabStop = false;
            grpConditions.Text = "شرایط";
            // 
            // lstConditions
            // 
            lstConditions.Dock = DockStyle.Fill;
            lstConditions.FormattingEnabled = true;
            lstConditions.ItemHeight = 15;
            lstConditions.Location = new Point(3, 19);
            lstConditions.Name = "lstConditions";
            lstConditions.RightToLeft = RightToLeft.Yes;
            lstConditions.Size = new Size(274, 158);
            lstConditions.TabIndex = 0;
            // 
            // btnGenerateJson
            // 
            btnGenerateJson.BackColor = Color.FromArgb(0, 120, 215);
            btnGenerateJson.FlatAppearance.BorderSize = 0;
            btnGenerateJson.FlatStyle = FlatStyle.Flat;
            btnGenerateJson.Font = new Font("Tahoma", 10F);
            btnGenerateJson.ForeColor = Color.White;
            btnGenerateJson.Location = new Point(20, 240);
            btnGenerateJson.Name = "btnGenerateJson";
            btnGenerateJson.Size = new Size(150, 35);
            btnGenerateJson.TabIndex = 3;
            btnGenerateJson.Text = "ساخت JSON";
            btnGenerateJson.UseVisualStyleBackColor = false;
            btnGenerateJson.Click += BtnGenerateJson_Click;
            // 
            // txtJsonOutput
            // 
            txtJsonOutput.Location = new Point(20, 285);
            txtJsonOutput.Multiline = true;
            txtJsonOutput.Name = "txtJsonOutput";
            txtJsonOutput.RightToLeft = RightToLeft.Yes;
            txtJsonOutput.Size = new Size(740, 150);
            txtJsonOutput.TabIndex = 4;
            // 
            // btnCopyJson
            // 
            btnCopyJson.BackColor = Color.FromArgb(255, 140, 0);
            btnCopyJson.FlatAppearance.BorderSize = 0;
            btnCopyJson.FlatStyle = FlatStyle.Flat;
            btnCopyJson.Font = new Font("Tahoma", 9F);
            btnCopyJson.ForeColor = Color.White;
            btnCopyJson.Location = new Point(180, 240);
            btnCopyJson.Name = "btnCopyJson";
            btnCopyJson.Size = new Size(150, 35);
            btnCopyJson.TabIndex = 5;
            btnCopyJson.Text = "کپی JSON";
            btnCopyJson.UseVisualStyleBackColor = false;
            btnCopyJson.Click += BtnCopyJson_Click;
            // 
            // btnSaveJson
            // 
            btnSaveJson.BackColor = Color.FromArgb(16, 124, 16);
            btnSaveJson.FlatAppearance.BorderSize = 0;
            btnSaveJson.FlatStyle = FlatStyle.Flat;
            btnSaveJson.Font = new Font("Tahoma", 9F);
            btnSaveJson.ForeColor = Color.White;
            btnSaveJson.Location = new Point(340, 240);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(150, 35);
            btnSaveJson.TabIndex = 6;
            btnSaveJson.Text = "ذخیره JSON";
            btnSaveJson.UseVisualStyleBackColor = false;
            btnSaveJson.Click += BtnSaveJson_Click;
            // 
            // RuleBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(btnSaveJson);
            Controls.Add(btnCopyJson);
            Controls.Add(txtJsonOutput);
            Controls.Add(btnGenerateJson);
            Controls.Add(grpConditions);
            Controls.Add(grpRuleInfo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RuleBuilderForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ساخت قانون با RulesEngine";
            grpRuleInfo.ResumeLayout(false);
            grpRuleInfo.PerformLayout();
            grpConditions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

 

        private Label lblTitle;
        private GroupBox grpRuleInfo;
        private Label lblRuleName;
        private TextBox txtRuleName;
        private Label lblField;
        private ComboBox cmbField;
        private Label lblOperator;
        private ComboBox cmbOperator;
        private Label lblValue;
        private TextBox txtValue;
        private Label lblCondition;
        private TextBox txtCondition;
        private Button btnAddCondition;
        private Button btnClearConditions;
        private GroupBox grpConditions;
        private ListBox lstConditions;
        private Button btnGenerateJson;
        private TextBox txtJsonOutput;
        private Button btnCopyJson;
        private Button btnSaveJson;
    }
}