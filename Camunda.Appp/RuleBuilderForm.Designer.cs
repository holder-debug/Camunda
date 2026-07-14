 
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
            lblActivationState = new CheckBox();
            txtCondition = new TextBox();
            lblCondition = new Label();
            txtRuleName = new TextBox();
            lblRuleName = new Label();
            btnSaveJson = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            grpRuleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(280, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ساخت قانون با RulesEngine";
            // 
            // grpRuleInfo
            // 
            grpRuleInfo.Controls.Add(lblActivationState);
            grpRuleInfo.Controls.Add(txtCondition);
            grpRuleInfo.Controls.Add(lblCondition);
            grpRuleInfo.Controls.Add(txtRuleName);
            grpRuleInfo.Controls.Add(lblRuleName);
            grpRuleInfo.Location = new Point(0, 184);
            grpRuleInfo.Name = "grpRuleInfo";
            grpRuleInfo.RightToLeft = RightToLeft.Yes;
            grpRuleInfo.Size = new Size(529, 180);
            grpRuleInfo.TabIndex = 1;
            grpRuleInfo.TabStop = false;
            grpRuleInfo.Text = "اطلاعات قانون";
            // 
            // lblActivationState
            // 
            lblActivationState.Location = new Point(389, 143);
            lblActivationState.Name = "lblActivationState";
            lblActivationState.Size = new Size(104, 24);
            lblActivationState.TabIndex = 12;
            lblActivationState.Text = "وضعیت ";
            lblActivationState.UseVisualStyleBackColor = true;
            // 
            // txtCondition
            // 
            txtCondition.Location = new Point(6, 69);
            txtCondition.Multiline = true;
            txtCondition.Name = "txtCondition";
            txtCondition.RightToLeft = RightToLeft.Yes;
            txtCondition.Size = new Size(409, 68);
            txtCondition.TabIndex = 9;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Tahoma", 9F);
            lblCondition.Location = new Point(428, 69);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(65, 14);
            lblCondition.TabIndex = 8;
            lblCondition.Text = "شرط کامل:";
            // 
            // txtRuleName
            // 
            txtRuleName.Location = new Point(6, 22);
            txtRuleName.Name = "txtRuleName";
            txtRuleName.RightToLeft = RightToLeft.Yes;
            txtRuleName.Size = new Size(409, 23);
            txtRuleName.TabIndex = 1;
            // 
            // lblRuleName
            // 
            lblRuleName.AutoSize = true;
            lblRuleName.Font = new Font("Tahoma", 9F);
            lblRuleName.Location = new Point(439, 31);
            lblRuleName.Name = "lblRuleName";
            lblRuleName.Size = new Size(54, 14);
            lblRuleName.TabIndex = 0;
            lblRuleName.Text = "نام قانون:";
            // 
            // btnSaveJson
            // 
            btnSaveJson.BackColor = Color.FromArgb(16, 124, 16);
            btnSaveJson.FlatAppearance.BorderSize = 0;
            btnSaveJson.FlatStyle = FlatStyle.Flat;
            btnSaveJson.Font = new Font("Tahoma", 9F);
            btnSaveJson.ForeColor = Color.White;
            btnSaveJson.Location = new Point(0, 370);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(150, 35);
            btnSaveJson.TabIndex = 6;
            btnSaveJson.Text = "ذخیره JSON";
            btnSaveJson.UseVisualStyleBackColor = false;
            btnSaveJson.Click += BtnSaveJson_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 411);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(529, 165);
            dataGridView1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(409, 68);
            textBox1.TabIndex = 10;
            // 
            // RuleBuilderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 576);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSaveJson);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private Label lblTitle;
        private GroupBox grpRuleInfo;
        private Label lblRuleName;
        private TextBox txtRuleName;
        private Label lblCondition;
        private TextBox txtCondition;
        private Button btnSaveJson;
        private CheckBox lblActivationState;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}