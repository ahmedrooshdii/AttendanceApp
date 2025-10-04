namespace Attendance.Presentation.Forms
{
    partial class ClassManagement
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DisplayClasss = new Guna.UI2.WinForms.Guna2DataGridView();
            seahrch_tbx = new TextBox();
            Search_btn = new Button();
            Add_btn = new Button();
            Update_btn = new Button();
            Delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayClasss).BeginInit();
            SuspendLayout();
            // 
            // DisplayClasss
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DisplayClasss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DisplayClasss.BackgroundColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DisplayClasss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DisplayClasss.ColumnHeadersHeight = 4;
            DisplayClasss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DisplayClasss.DefaultCellStyle = dataGridViewCellStyle3;
            DisplayClasss.GridColor = Color.FromArgb(231, 229, 255);
            DisplayClasss.Location = new Point(6, 69);
            DisplayClasss.Name = "DisplayClasss";
            DisplayClasss.RowHeadersVisible = false;
            DisplayClasss.RowHeadersWidth = 51;
            DisplayClasss.Size = new Size(797, 288);
            DisplayClasss.TabIndex = 0;
            DisplayClasss.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DisplayClasss.ThemeStyle.AlternatingRowsStyle.Font = null;
            DisplayClasss.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DisplayClasss.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DisplayClasss.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DisplayClasss.ThemeStyle.BackColor = SystemColors.WindowFrame;
            DisplayClasss.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DisplayClasss.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DisplayClasss.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DisplayClasss.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DisplayClasss.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DisplayClasss.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DisplayClasss.ThemeStyle.HeaderStyle.Height = 4;
            DisplayClasss.ThemeStyle.ReadOnly = false;
            DisplayClasss.ThemeStyle.RowsStyle.BackColor = Color.White;
            DisplayClasss.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DisplayClasss.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DisplayClasss.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DisplayClasss.ThemeStyle.RowsStyle.Height = 29;
            DisplayClasss.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DisplayClasss.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DisplayClasss.CellContentClick += DisplayClasss_CellContentClick;
            // 
            // seahrch_tbx
            // 
            seahrch_tbx.Location = new Point(34, 22);
            seahrch_tbx.Name = "seahrch_tbx";
            seahrch_tbx.Size = new Size(227, 27);
            seahrch_tbx.TabIndex = 1;
            // 
            // Search_btn
            // 
            Search_btn.Location = new Point(305, 22);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(94, 29);
            Search_btn.TabIndex = 2;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.Click += Search_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Location = new Point(34, 377);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(89, 43);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Location = new Point(161, 377);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(88, 43);
            Update_btn.TabIndex = 4;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = true;
            Update_btn.Click += Update_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(285, 377);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(91, 43);
            Delete_btn.TabIndex = 5;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 445);
            Controls.Add(Delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(Add_btn);
            Controls.Add(Search_btn);
            Controls.Add(seahrch_tbx);
            Controls.Add(DisplayClasss);
            Margin = new Padding(2);
            Name = "ClassManagement";
            Text = "Class Management";
            Load += ClassManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayClasss).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Guna.UI2.WinForms.Guna2DataGridView DisplayClasss;
        private TextBox seahrch_tbx;
        private Button Search_btn;
        private Button Add_btn;
        private Button Update_btn;
        private Button Delete_btn;
    }
}