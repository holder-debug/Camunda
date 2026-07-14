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
            // ====================== کامپوننت‌های اصلی ======================
            lblTitle = new Label();
            grpRuleInfo = new GroupBox();
            lblActivationState = new CheckBox();
            txtCondition = new TextBox();
            lblCondition = new Label();
            txtRuleName = new TextBox();
            lblRuleName = new Label();
            btnSaveJson = new Button();
            btnRuleCopy = new Button();
            btnCancelEdit = new Button();
            btnDeleteRule = new Button();
            dataGridView1 = new DataGridView();
            txtJsonPreview = new TextBox();
            grpRuleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // ====================== عنوان فرم ======================
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitle.Location = new Point(180, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏗️ ساخت قانون با RulesEngine";

            // ====================== گروه اطلاعات قانون ======================
            // grpRuleInfo
            grpRuleInfo.BackColor = Color.FromArgb(248, 249, 250);
            grpRuleInfo.Controls.Add(lblActivationState);
            grpRuleInfo.Controls.Add(txtCondition);
            grpRuleInfo.Controls.Add(lblCondition);
            grpRuleInfo.Controls.Add(txtRuleName);
            grpRuleInfo.Controls.Add(lblRuleName);
            grpRuleInfo.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            grpRuleInfo.ForeColor = Color.FromArgb(44, 62, 80);
            grpRuleInfo.Location = new Point(12, 44);
            grpRuleInfo.Name = "grpRuleInfo";
            grpRuleInfo.RightToLeft = RightToLeft.Yes;
            grpRuleInfo.Size = new Size(505, 175);
            grpRuleInfo.TabIndex = 1;
            grpRuleInfo.TabStop = false;
            grpRuleInfo.Text = "📋 اطلاعات قانون";

            // lblRuleName
            lblRuleName.AutoSize = true;
            lblRuleName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblRuleName.ForeColor = Color.FromArgb(44, 62, 80);
            lblRuleName.Location = new Point(435, 28);
            lblRuleName.Name = "lblRuleName";
            lblRuleName.Size = new Size(64, 14);
            lblRuleName.TabIndex = 0;
            lblRuleName.Text = "📛 نام قانون:";

            // txtRuleName
            txtRuleName.BackColor = Color.White;
            txtRuleName.BorderStyle = BorderStyle.FixedSingle;
            txtRuleName.Font = new Font("Tahoma", 10F);
            txtRuleName.Location = new Point(6, 22);
            txtRuleName.Name = "txtRuleName";
            txtRuleName.RightToLeft = RightToLeft.Yes;
            txtRuleName.Size = new Size(423, 24);
            txtRuleName.TabIndex = 1;

            // lblCondition
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblCondition.ForeColor = Color.FromArgb(44, 62, 80);
            lblCondition.Location = new Point(434, 69);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(65, 14);
            lblCondition.TabIndex = 8;
            lblCondition.Text = "📝 شرط کامل:";

            // txtCondition
            txtCondition.BackColor = Color.White;
            txtCondition.BorderStyle = BorderStyle.FixedSingle;
            txtCondition.Font = new Font("Tahoma", 10F);
            txtCondition.Location = new Point(6, 69);
            txtCondition.Multiline = true;
            txtCondition.Name = "txtCondition";
            txtCondition.RightToLeft = RightToLeft.Yes;
            txtCondition.Size = new Size(422, 68);
            txtCondition.TabIndex = 9;

            // lblActivationState
            lblActivationState.Font = new Font("Tahoma", 9F);
            lblActivationState.ForeColor = Color.FromArgb(44, 62, 80);
            lblActivationState.Location = new Point(389, 143);
            lblActivationState.Name = "lblActivationState";
            lblActivationState.Size = new Size(104, 24);
            lblActivationState.TabIndex = 12;
            lblActivationState.Text = "✅ فعال";
            lblActivationState.UseVisualStyleBackColor = true;

            // ====================== دکمه‌های عملیاتی ======================
            // btnSaveJson
            btnSaveJson.BackColor = Color.FromArgb(46, 204, 113);
            btnSaveJson.FlatAppearance.BorderSize = 0;
            btnSaveJson.FlatStyle = FlatStyle.Flat;
            btnSaveJson.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSaveJson.ForeColor = Color.White;
            btnSaveJson.Location = new Point(12, 230);
            btnSaveJson.Name = "btnSaveJson";
            btnSaveJson.Size = new Size(110, 38);
            btnSaveJson.TabIndex = 6;
            btnSaveJson.Text = "💾 ذخیره";
            btnSaveJson.UseVisualStyleBackColor = false;
            btnSaveJson.Click += BtnSaveJson_Click;

            // btnCancelEdit
            btnCancelEdit.BackColor = Color.FromArgb(241, 196, 15);
            btnCancelEdit.FlatAppearance.BorderSize = 0;
            btnCancelEdit.FlatStyle = FlatStyle.Flat;
            btnCancelEdit.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCancelEdit.ForeColor = Color.White;
            btnCancelEdit.Location = new Point(128, 230);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(110, 38);
            btnCancelEdit.TabIndex = 13;
            btnCancelEdit.Text = "↩️ لغو ویرایش";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += BtnCancelEdit_Click;

            // btnDeleteRule
            btnDeleteRule.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteRule.FlatAppearance.BorderSize = 0;
            btnDeleteRule.FlatStyle = FlatStyle.Flat;
            btnDeleteRule.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDeleteRule.ForeColor = Color.White;
            btnDeleteRule.Location = new Point(244, 230);
            btnDeleteRule.Name = "btnDeleteRule";
            btnDeleteRule.Size = new Size(110, 38);
            btnDeleteRule.TabIndex = 14;
            btnDeleteRule.Text = "🗑️ حذف";
            btnDeleteRule.UseVisualStyleBackColor = false;
            btnDeleteRule.Click += BtnDeleteRule_Click;

            // btnRuleCopy
            btnRuleCopy.BackColor = Color.FromArgb(52, 152, 219);
            btnRuleCopy.FlatAppearance.BorderSize = 0;
            btnRuleCopy.FlatStyle = FlatStyle.Flat;
            btnRuleCopy.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnRuleCopy.ForeColor = Color.White;
            btnRuleCopy.Location = new Point(360, 230);
            btnRuleCopy.Name = "btnRuleCopy";
            btnRuleCopy.Size = new Size(157, 38);
            btnRuleCopy.TabIndex = 11;
            btnRuleCopy.Text = "📋 مشاهده JSON";
            btnRuleCopy.UseVisualStyleBackColor = false;
            btnRuleCopy.Click += btnRuleCopy_Click;

            // ====================== پیش‌نمایش JSON ======================
            // txtJsonPreview
            txtJsonPreview.BackColor = Color.FromArgb(44, 62, 80);
            txtJsonPreview.BorderStyle = BorderStyle.None;
            txtJsonPreview.Font = new Font("Consolas", 9F);
            txtJsonPreview.ForeColor = Color.FromArgb(46, 204, 113);
            txtJsonPreview.Location = new Point(12, 280);
            txtJsonPreview.Multiline = true;
            txtJsonPreview.Name = "txtJsonPreview";
            txtJsonPreview.ReadOnly = true;
            txtJsonPreview.RightToLeft = RightToLeft.No;
            txtJsonPreview.ScrollBars = ScrollBars.Vertical;
            txtJsonPreview.Size = new Size(505, 120);
            txtJsonPreview.TabIndex = 15;
            txtJsonPreview.Text = "📄 JSON قوانین در اینجا نمایش داده می‌شود...";
            txtJsonPreview.WordWrap = false;

            // ====================== جدول نمایش قوانین ======================
            // dataGridView1
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.FromArgb(236, 240, 241);
            dataGridView1.Location = new Point(0, 406);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(529, 170);
            dataGridView1.TabIndex = 7;

            // ====================== تنظیمات نهایی فرم ======================
            // RuleBuilderForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(529, 576);
            Controls.Add(txtJsonPreview);
            Controls.Add(btnDeleteRule);
            Controls.Add(btnCancelEdit);
            Controls.Add(btnRuleCopy);
            Controls.Add(btnSaveJson);
            Controls.Add(grpRuleInfo);
            Controls.Add(lblTitle);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RuleBuilderForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🏗️ ساخت قانون با RulesEngine";
            grpRuleInfo.ResumeLayout(false);
            grpRuleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ====================== متغیرهای کامپوننت‌ها ======================
        private Label lblTitle;
        private GroupBox grpRuleInfo;
        private Label lblRuleName;
        private TextBox txtRuleName;
        private Label lblCondition;
        private TextBox txtCondition;
        private Button btnSaveJson;
        private CheckBox lblActivationState;
        private DataGridView dataGridView1;
        private Button btnRuleCopy;
        private Button btnCancelEdit;
        private Button btnDeleteRule;
        private TextBox txtJsonPreview;
    }
}