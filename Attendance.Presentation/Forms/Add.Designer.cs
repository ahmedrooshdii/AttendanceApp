namespace Attendance.Presentation.Forms
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            label1 = new Label();
            textBox_add = new TextBox();
            Add_classBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 125);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Class Name";
            // 
            // textBox_add
            // 
            textBox_add.Location = new Point(166, 129);
            textBox_add.Name = "textBox_add";
            textBox_add.Size = new Size(265, 27);
            textBox_add.TabIndex = 1;
            // 
            // Add_classBtn
            // 
            Add_classBtn.BackColor = Color.FromArgb(0, 192, 0);
            Add_classBtn.Cursor = Cursors.Hand;
            Add_classBtn.FlatAppearance.BorderSize = 0;
            Add_classBtn.FlatStyle = FlatStyle.Flat;
            Add_classBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_classBtn.ForeColor = Color.White;
            Add_classBtn.Location = new Point(193, 223);
            Add_classBtn.Name = "Add_classBtn";
            Add_classBtn.Size = new Size(143, 54);
            Add_classBtn.TabIndex = 2;
            Add_classBtn.Text = "Add Class ";
            Add_classBtn.UseVisualStyleBackColor = false;
            Add_classBtn.Click += Add_classBtn_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 346);
            Controls.Add(Add_classBtn);
            Controls.Add(label1);
            Controls.Add(textBox_add);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_add;
        private Button Add_classBtn;
    }
}