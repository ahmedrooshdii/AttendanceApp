﻿namespace Attendance.Presentation.Forms
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 186);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Class Name";
            // 
            // textBox_add
            // 
            textBox_add.Location = new Point(312, 186);
            textBox_add.Name = "textBox_add";
            textBox_add.Size = new Size(265, 27);
            textBox_add.TabIndex = 1;
            // 
            // Add_classBtn
            // 
            Add_classBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_classBtn.Location = new Point(366, 295);
            Add_classBtn.Name = "Add_classBtn";
            Add_classBtn.Size = new Size(117, 52);
            Add_classBtn.TabIndex = 2;
            Add_classBtn.Text = "Add Class ";
            Add_classBtn.UseVisualStyleBackColor = true;
            Add_classBtn.Click += Add_classBtn_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_classBtn);
            Controls.Add(label1);
            Controls.Add(textBox_add);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
           // Load += this.Add;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_add;
        private Button Add_classBtn;
    }
}