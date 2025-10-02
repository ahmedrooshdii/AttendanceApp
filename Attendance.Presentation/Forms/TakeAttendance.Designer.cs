namespace Attendance.Presentation.Forms
{
    partial class TakeAttendance
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
            tabControl1 = new TabControl();
            tabPageMarkAttendance = new TabPage();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageMarkAttendance);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(comboBox1);
            tabPageMarkAttendance.Controls.Add(panel4);
            tabPageMarkAttendance.Controls.Add(panel3);
            tabPageMarkAttendance.Controls.Add(panel2);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(dateTimePicker1);
            tabPageMarkAttendance.Controls.Add(label3);
            tabPageMarkAttendance.Controls.Add(label2);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(3);
            tabPageMarkAttendance.Size = new Size(912, 431);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Mark Attendance";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(535, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 24);
            comboBox1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Location = new Point(385, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 26);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(104, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 26);
            panel3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(120, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 13);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Location = new Point(120, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 10);
            panel1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(377, 9);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 24);
            comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 22);
            dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(535, 62);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 0;
            label3.Text = "Class : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(117, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 0;
            label2.Text = "Date : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(67, 31, 125);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(144, 19);
            label1.TabIndex = 0;
            label1.Text = "Mark Attendance";
            // 
            // TakeAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(926, 462);
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "TakeAttendance";
            Text = "TakeAttendance";
            tabControl1.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageMarkAttendance;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private ComboBox comboBox1;
        private Panel panel4;
        private Panel panel5;
        private ComboBox comboBox2;
    }
}