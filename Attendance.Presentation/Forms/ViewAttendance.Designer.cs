namespace Attendance.Presentation.Forms
{
    partial class ViewAttendance
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvReport = new DataGridView();
            btnExport = new Button();
            btnGenerate = new Button();
            dtTo = new DateTimePicker();
            dtFrom = new DateTimePicker();
            txtStudent = new TextBox();
            cmbClass = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvReport);
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(txtStudent);
            panel1.Controls.Add(cmbClass);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 616);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 133);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 19;
            label4.Text = "To  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 133);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 20;
            label3.Text = "From : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 18;
            label2.Text = "Student :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 17;
            label1.Text = "Class : ";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(66, 210);
            dgvReport.Margin = new Padding(4);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(991, 289);
            dgvReport.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(66, 533);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 29);
            btnExport.TabIndex = 15;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(901, 131);
            btnGenerate.Margin = new Padding(4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(96, 29);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // dtTo
            // 
            dtTo.Location = new Point(593, 130);
            dtTo.Margin = new Padding(4);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(256, 27);
            dtTo.TabIndex = 13;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(184, 130);
            dtFrom.Margin = new Padding(4);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(256, 27);
            dtFrom.TabIndex = 12;
            // 
            // txtStudent
            // 
            txtStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStudent.Location = new Point(593, 54);
            txtStudent.Margin = new Padding(4);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(256, 27);
            txtStudent.TabIndex = 11;
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(184, 55);
            cmbClass.Margin = new Padding(4);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(256, 27);
            cmbClass.TabIndex = 10;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // ViewAttendance
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 616);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAttendance";
            Text = "ViewAttendance";
            Load += ViewAttendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvReport;
        private Button btnExport;
        private Button btnGenerate;
        private DateTimePicker dtTo;
        private DateTimePicker dtFrom;
        private TextBox txtStudent;
        private ComboBox cmbClass;
    }
}