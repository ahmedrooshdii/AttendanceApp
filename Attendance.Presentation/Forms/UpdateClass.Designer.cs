namespace Attendance.Presentation.Forms
{
    partial class UpdateClass
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
            textBox_updateClass = new TextBox();
            UpdateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "Update Class Name";
            // 
            // textBox_updateClass
            // 
            textBox_updateClass.Location = new Point(213, 135);
            textBox_updateClass.Name = "textBox_updateClass";
            textBox_updateClass.Size = new Size(263, 27);
            textBox_updateClass.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Green;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(240, 240);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(130, 61);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // UpdateClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 384);
            Controls.Add(UpdateBtn);
            Controls.Add(textBox_updateClass);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UpdateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateClass";
            Load += UpdateClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_updateClass;
        private Button UpdateBtn;
    }
}