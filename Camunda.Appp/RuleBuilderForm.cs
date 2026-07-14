using System.Text.Json;
using RulesEngine.Models;

namespace Camunda.Appp;

public partial class RuleBuilderForm : Form
{
    public static List<Rule> Rules = [];
    private bool _isEditing = false;
    private int _selectedRowIndex = -1;

    public RuleBuilderForm()
    {
        InitializeComponent();
        lblActivationState.Checked = true;
        SetupDataGridView();

        textBox1.Text += "input1.Day > 1 && input1.Day < 5";
        textBox1.Text += Environment.NewLine;
        textBox1.Text += Environment.NewLine;
        textBox1.Text += "input1.Day > 6 && input1.Day < 10";
    }

    private void SetupDataGridView()
    {
        // تنظیمات گرید
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = false;
        dataGridView1.ReadOnly = true;
        dataGridView1.AllowUserToAddRows = false;

        // حذف ستون‌های اضافی اگر وجود دارند
        dataGridView1.Columns.Clear();

        // اضافه کردن ستون‌های مورد نیاز
        dataGridView1.Columns.Add("RuleName", "نام قانون");
        dataGridView1.Columns.Add("Enabled", "فعال");
        dataGridView1.Columns.Add("Expression", "شرط");

        // تنظیم عرض ستون‌ها
        dataGridView1.Columns["RuleName"].Width = 150;
        dataGridView1.Columns["Enabled"].Width = 80;
        dataGridView1.Columns["Expression"].Width = 250;

        // رویداد کلیک روی ردیف
        dataGridView1.CellClick += DataGridView1_CellClick;

        // بارگذاری قوانین موجود
        RefreshDataGridView();
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // اگر روی هدر یا خارج از ردیف کلیک شده باشد
        if (e.RowIndex < 0) return;

        try
        {
            _selectedRowIndex = e.RowIndex;
            var row = dataGridView1.Rows[e.RowIndex];

            // گرفتن اطلاعات از ردیف
            string ruleName = row.Cells["RuleName"].Value?.ToString() ?? "";
         
            string expression = row.Cells["Expression"].Value?.ToString() ?? "";

            var isEnabled = false;

            var isActiveFa = row.Cells["Enabled"].Value?.ToString();
            if (isActiveFa == "بله")
                isEnabled = true;



            // پر کردن فرم با اطلاعات
            txtRuleName.Text = ruleName;
            lblActivationState.Checked = isEnabled;
            txtCondition.Text = expression;

            // تغییر حالت به ویرایش
            _isEditing = true;
            btnSaveJson.Text = "ویرایش قانون";
            btnSaveJson.BackColor = Color.FromArgb(255, 140, 0); // نارنجی

            // غیرفعال کردن TextBox نام قانون
            txtRuleName.Enabled = false;

            MessageBox.Show($"قانون '{ruleName}' برای ویرایش انتخاب شد.", "ویرایش",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا در انتخاب قانون: {ex.Message}", "خطا",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


 
    private void BtnSaveJson_Click(object sender, EventArgs e)
    {
        try
        {
            // گرفتن اطلاعات از فرم
            string ruleName = txtRuleName.Text.Trim();
            string condition = txtCondition.Text.Trim();
            bool isEnabled = lblActivationState.Checked;

            // اعتبارسنجی
            if (string.IsNullOrEmpty(ruleName))
            {
                MessageBox.Show("لطفاً نام قانون را وارد کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuleName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(condition))
            {
                MessageBox.Show("لطفاً شرط قانون را وارد کنید.", "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondition.Focus();
                return;
            }

            if (_isEditing)
            {
                // ========== حالت ویرایش ==========
                // پیدا کردن قانون در لیست
                var existingRule = Rules.FirstOrDefault(r => r.RuleName == ruleName);
                if (existingRule != null)
                {
                    // به‌روزرسانی قانون
                    existingRule.Expression = condition;
                    existingRule.Enabled = isEnabled;

                    MessageBox.Show($"قانون '{ruleName}' با موفقیت ویرایش شد.", "موفقیت",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"قانون '{ruleName}' در لیست یافت نشد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // ========== حالت اضافه کردن جدید ==========
                // بررسی تکراری نبودن نام
                if (Rules.Any(r => r.RuleName == ruleName))
                {
                    MessageBox.Show($"قانون با نام '{ruleName}' قبلاً وجود دارد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRuleName.Focus();
                    txtRuleName.SelectAll();
                    return;
                }

                // ساخت قانون جدید
                var newRule = new Rule
                {
                    RuleName = ruleName,
                    Enabled = isEnabled,
                    Expression = condition
                };

                // اضافه کردن به لیست
                Rules.Add(newRule);
                MessageBox.Show($"قانون '{ruleName}' با موفقیت اضافه شد.", "موفقیت",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // ذخیره در فایل JSON
            SaveRulesToJson();

            // به‌روزرسانی گرید
            RefreshDataGridView();

            // خروج از حالت ویرایش و پاک کردن فرم
            CancelEditing();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا در عملیات: {ex.Message}", "خطا",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveRulesToJson()
    {
        try
        {
            // ساختار Workflow برای RulesEngine
            var workflow = new Workflow
            {
                WorkflowName = "MyWorkflow",
                Rules = Rules
            };

            var workflows = new List<Workflow> { workflow };

            // تبدیل به JSON
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            string jsonString = JsonSerializer.Serialize(workflows, options);

            // ذخیره در فایل
            string filePath = Path.Combine(Application.StartupPath, "rules.json");
            File.WriteAllText(filePath, jsonString);
        }
        catch (Exception ex)
        {
            throw new Exception($"خطا در ذخیره فایل JSON: {ex.Message}");
        }
    }

    private void RefreshDataGridView()
    {
        try
        {
            // پاک کردن گرید
            dataGridView1.Rows.Clear();

            // اضافه کردن قوانین به گرید
            foreach (var rule in Rules)
            {
                dataGridView1.Rows.Add(
                    rule.RuleName,
                    rule.Enabled ? "بله" : "خیر",
                    rule.Expression
                );
            }

            // نمایش تعداد قوانین
            lblTitle.Text = $"تعداد قوانین: {Rules.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"خطا در نمایش قوانین: {ex.Message}", "خطا",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CancelEditing()
    {
        // خروج از حالت ویرایش
        _isEditing = false;
        _selectedRowIndex = -1;

        // بازگرداندن دکمه به حالت عادی
        btnSaveJson.Text = "ذخیره JSON";
        btnSaveJson.BackColor = Color.FromArgb(16, 124, 16);

        // فعال کردن TextBox نام قانون
        txtRuleName.Enabled = true;

        // پاک کردن فرم
        ClearForm();
    }

    private void ClearForm()
    {
        txtRuleName.Clear();
        txtCondition.Clear();
        lblActivationState.Checked = true;
        txtRuleName.Focus();
    }

    // دکمه برای خروج از حالت ویرایش (اختیاری)
    private void BtnCancelEdit_Click(object sender, EventArgs e)
    {
        if (_isEditing)
        {
            var result = MessageBox.Show("آیا از خروج از حالت ویرایش مطمئن هستید؟", "تأیید",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CancelEditing();
            }
        }
    }
}