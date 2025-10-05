namespace Attendance.Presentation.Forms
{
    partial class Preference
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbDateFormat;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.Label lblLanguage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbDateFormat = new ComboBox();
            cmbLanguage = new ComboBox();
            lblDateFormat = new Label();
            lblLanguage = new Label();
            save = new Button();
            cmbTheme = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDateFormat
            // 
            cmbDateFormat.Items.AddRange(new object[] { "dd/MM/yyyy", "MM/dd/yyyy" });
            cmbDateFormat.Location = new Point(267, 40);
            cmbDateFormat.Name = "cmbDateFormat";
            cmbDateFormat.Size = new Size(408, 33);
            cmbDateFormat.TabIndex = 1;
            // 
            // cmbLanguage
            // 
            cmbLanguage.Items.AddRange(new object[] { "English", "Arabic" });
            cmbLanguage.Location = new Point(267, 120);
            cmbLanguage.MaximumSize = new Size(500, 0);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(408, 33);
            cmbLanguage.TabIndex = 3;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // lblDateFormat
            // 
            lblDateFormat.Location = new Point(103, 40);
            lblDateFormat.Name = "lblDateFormat";
            lblDateFormat.Size = new Size(104, 33);
            lblDateFormat.TabIndex = 0;
            lblDateFormat.Text = "Date Format :";
            lblDateFormat.Click += lblDateFormat_Click;
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(103, 120);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(104, 33);
            lblLanguage.TabIndex = 2;
            lblLanguage.Text = "Language :";
            // 
            // save
            // 
            save.BackColor = Color.DodgerBlue;
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.ForeColor = Color.White;
            save.Location = new Point(385, 267);
            save.Name = "save";
            save.Size = new Size(161, 54);
            save.TabIndex = 5;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            // 
            // cmbTheme
            // 
            cmbTheme.Items.AddRange(new object[] { "Light", "Dark" });
            cmbTheme.Location = new Point(267, 201);
            cmbTheme.MaximumSize = new Size(500, 0);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(408, 33);
            cmbTheme.TabIndex = 6;
            cmbTheme.SelectedIndexChanged += cmbTheme_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(103, 204);
            label1.Name = "label1";
            label1.Size = new Size(104, 33);
            label1.TabIndex = 7;
            label1.Text = "Theme : ";
            label1.Click += label1_Click;
            // 
            // Preference
            // 
            BackColor = Color.White;
            ClientSize = new Size(988, 357);
            Controls.Add(label1);
            Controls.Add(cmbTheme);
            Controls.Add(save);
            Controls.Add(lblDateFormat);
            Controls.Add(cmbDateFormat);
            Controls.Add(lblLanguage);
            Controls.Add(cmbLanguage);
            Name = "Preference";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preferences";
            ResumeLayout(false);
        }
        private Button save;
        private ComboBox cmbTheme;
        private Label label1;
    }
}