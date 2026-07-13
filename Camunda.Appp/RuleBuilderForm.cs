using System.Text.Json;

namespace Camunda.Appp
{
    public partial class RuleBuilderForm : Form
    {
        private List<string> _conditions = new List<string>();

        public RuleBuilderForm()
        {
            InitializeComponent();

            // تنظیم مقادیر پیش‌فرض
            cmbField.SelectedIndex = 0;
            cmbOperator.SelectedIndex = 0;
        }

        private void BtnAddCondition_Click(object sender, EventArgs e)
        {
            // گرفتن مقادیر
            string field = cmbField.SelectedItem?.ToString();
            string operator_ = cmbOperator.SelectedItem?.ToString();
            string value = txtValue.Text.Trim();

            // اعتبارسنجی
            if (string.IsNullOrEmpty(field))
            {
                MessageBox.Show("لطفاً یک فیلد انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("لطفاً مقدار را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ساخت شرط
            string condition = $"input1.{field} {operator_} {FormatValue(value, field)}";

            // اضافه کردن به لیست
            _conditions.Add(condition);
            lstConditions.Items.Add(condition);

            // به‌روزرسانی شرط کامل
            UpdateConditionText();

            // پاک کردن مقدار
            txtValue.Clear();
            txtValue.Focus();
        }

        private string FormatValue(string value, string field)
        {
            // اگر فیلد از نوع رشته است، باید داخل "" قرار بگیرد
            if (field == "userRole" || field == "employeeName")
            {
                return $"\"{value}\"";
            }

            // اگر مقدار عددی است، بدون تغییر
            if (int.TryParse(value, out _) || double.TryParse(value, out _))
            {
                return value;
            }

            // اگر مقدار boolean است
            if (value.ToLower() == "true" || value.ToLower() == "false")
            {
                return value.ToLower();
            }

            // پیش‌فرض
            return $"\"{value}\"";
        }

        private void UpdateConditionText()
        {
            if (_conditions.Count > 0)
            {
                txtCondition.Text = string.Join(" AND ", _conditions);
            }
            else
            {
                txtCondition.Text = "";
            }
        }

        private void BtnClearConditions_Click(object sender, EventArgs e)
        {
            _conditions.Clear();
            lstConditions.Items.Clear();
            txtCondition.Text = "";
        }

        private void BtnGenerateJson_Click(object sender, EventArgs e)
        {
            try
            {
                // گرفتن نام قانون
                string ruleName = txtRuleName.Text.Trim();
                if (string.IsNullOrEmpty(ruleName))
                {
                    MessageBox.Show("لطفاً نام قانون را وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRuleName.Focus();
                    return;
                }

                // گرفتن شرط
                string expression = txtCondition.Text.Trim();
                if (string.IsNullOrEmpty(expression))
                {
                    MessageBox.Show("لطفاً حداقل یک شرط اضافه کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ساخت JSON
                var rule = new
                {
                    RuleName = ruleName,
                    SuccessEvent = "Success",
                    ErrorMessage = "One or more rules failed.",
                    RuleExpressionType = "LambdaExpression",
                    Expression = expression
                };

                var workflow = new
                {
                    WorkflowName = "LeaveRequestRules",
                    Rules = new[] { rule }
                };

                var json = JsonSerializer.Serialize(workflow, new JsonSerializerOptions { WriteIndented = true });
                txtJsonOutput.Text = json;

                MessageBox.Show("JSON با موفقیت ساخته شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ساخت JSON: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopyJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJsonOutput.Text))
            {
                MessageBox.Show("ابتدا JSON را بسازید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clipboard.SetText(txtJsonOutput.Text);
            MessageBox.Show("JSON کپی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSaveJson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJsonOutput.Text))
            {
                MessageBox.Show("ابتدا JSON را بسازید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ذخیره در فایل
                string filePath = Path.Combine(Application.StartupPath, "rules.json");
                File.WriteAllText(filePath, txtJsonOutput.Text);

                MessageBox.Show($"JSON در مسیر زیر ذخیره شد:\n{filePath}", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // متد برای بارگذاری JSON موجود
        private void LoadJsonFromFile()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "rules.json");
                if (File.Exists(filePath))
                {
                    txtJsonOutput.Text = File.ReadAllText(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگذاری: {ex.Message}");
            }
        }
    }
}