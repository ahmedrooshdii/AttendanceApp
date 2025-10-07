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
            button1 = new Button();
            panel5 = new Panel();
            dataGridViewMarkAttendance = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewComboBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            comboBoxClass = new ComboBox();
            panel6 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageMarkAttendance);
            tabControl1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(button1);
            tabPageMarkAttendance.Controls.Add(panel5);
            tabPageMarkAttendance.Controls.Add(dataGridViewMarkAttendance);
            tabPageMarkAttendance.Controls.Add(comboBoxClass);
            tabPageMarkAttendance.Controls.Add(panel6);
            tabPageMarkAttendance.Controls.Add(panel4);
            tabPageMarkAttendance.Controls.Add(panel3);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(dateTimePicker1);
            tabPageMarkAttendance.Controls.Add(label3);
            tabPageMarkAttendance.Controls.Add(label2);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(3);
            tabPageMarkAttendance.Size = new Size(912, 428);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Mark Attendance";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(39, 368);
            button1.Name = "button1";
            button1.Size = new Size(244, 44);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Location = new Point(526, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 1);
            panel5.TabIndex = 4;
            // 
            // dataGridViewMarkAttendance
            // 
            dataGridViewMarkAttendance.AllowUserToAddRows = false;
            dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMarkAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendance.BackgroundColor = Color.White;
            dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { ID, StudentName, Status, Note });
            dataGridViewMarkAttendance.Location = new Point(39, 131);
            dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            dataGridViewMarkAttendance.ScrollBars = ScrollBars.Vertical;
            dataGridViewMarkAttendance.Size = new Size(831, 231);
            dataGridViewMarkAttendance.TabIndex = 6;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Items.AddRange(new object[] { "--Select--", "Present", "Absent", "Late" });
            Status.Name = "Status";
            // 
            // Note
            // 
            Note.HeaderText = "Note";
            Note.Name = "Note";
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(526, 79);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 27);
            comboBoxClass.TabIndex = 5;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.Location = new Point(367, 53);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 54);
            panel6.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Location = new Point(402, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 26);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(93, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 26);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Location = new Point(111, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 10);
            panel1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(377, 9);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 27);
            comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(459, 82);
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
            label2.Location = new Point(41, 82);
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
            Load += TakeAttendance_Load;
            tabControl1.ResumeLayout(false);
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).EndInit();
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
        private ComboBox comboBoxClass;
        private Panel panel4;
        private Panel panel5;
        private ComboBox comboBox2;
        private Panel panel6;
        private DataGridView dataGridViewMarkAttendance;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewComboBoxColumn Status;
        private DataGridViewTextBoxColumn Note;
    }
}