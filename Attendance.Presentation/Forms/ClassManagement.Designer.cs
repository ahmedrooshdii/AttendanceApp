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
            seahrch_tbx = new TextBox();
            Search_btn = new Button();
            Add_btn = new Button();
            Update_btn = new Button();
            Delete_btn = new Button();
            Assign_teacherBtn = new Button();
            DisplayClasss = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DisplayClasss).BeginInit();
            SuspendLayout();
            // 
            // seahrch_tbx
            // 
            seahrch_tbx.Location = new Point(12, 22);
            seahrch_tbx.Name = "seahrch_tbx";
            seahrch_tbx.Size = new Size(231, 27);
            seahrch_tbx.TabIndex = 1;
            seahrch_tbx.TextChanged += seahrch_tbx_TextChanged_1;
            // 
            // Search_btn
            // 
            Search_btn.BackColor = Color.Blue;
            Search_btn.Cursor = Cursors.Hand;
            Search_btn.FlatAppearance.BorderSize = 0;
            Search_btn.FlatStyle = FlatStyle.Flat;
            Search_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search_btn.ForeColor = SystemColors.ButtonHighlight;
            Search_btn.Location = new Point(261, 22);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(103, 32);
            Search_btn.TabIndex = 2;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = false;
            Search_btn.Click += Search_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Add_btn.BackColor = Color.FromArgb(0, 192, 0);
            Add_btn.Cursor = Cursors.Hand;
            Add_btn.FlatAppearance.BorderSize = 0;
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_btn.Location = new Point(23, 371);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(141, 54);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Update_btn
            // 
            Update_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Update_btn.BackColor = SystemColors.HotTrack;
            Update_btn.Cursor = Cursors.Hand;
            Update_btn.FlatAppearance.BorderSize = 0;
            Update_btn.FlatStyle = FlatStyle.Flat;
            Update_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_btn.ForeColor = SystemColors.ButtonHighlight;
            Update_btn.Location = new Point(210, 372);
            Update_btn.Name = "Update_btn";
            Update_btn.Size = new Size(133, 54);
            Update_btn.TabIndex = 4;
            Update_btn.Text = "Update";
            Update_btn.UseVisualStyleBackColor = false;
            Update_btn.Click += Update_btn_Click;
            // 
            // Delete_btn
            // 
            Delete_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Delete_btn.BackColor = Color.Red;
            Delete_btn.Cursor = Cursors.Hand;
            Delete_btn.FlatAppearance.BorderSize = 0;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_btn.ForeColor = SystemColors.ControlLightLight;
            Delete_btn.Location = new Point(393, 372);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(153, 54);
            Delete_btn.TabIndex = 5;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = false;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Assign_teacherBtn
            // 
            Assign_teacherBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Assign_teacherBtn.BackColor = Color.NavajoWhite;
            Assign_teacherBtn.Cursor = Cursors.Hand;
            Assign_teacherBtn.FlatAppearance.BorderSize = 0;
            Assign_teacherBtn.FlatStyle = FlatStyle.Flat;
            Assign_teacherBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Assign_teacherBtn.Location = new Point(580, 371);
            Assign_teacherBtn.Name = "Assign_teacherBtn";
            Assign_teacherBtn.Size = new Size(201, 55);
            Assign_teacherBtn.TabIndex = 6;
            Assign_teacherBtn.Text = "Assign Teacher";
            Assign_teacherBtn.UseVisualStyleBackColor = false;
            Assign_teacherBtn.Click += Assign_teacherBtn_Click;
            // 
            // DisplayClasss
            // 
            DisplayClasss.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayClasss.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisplayClasss.BackgroundColor = Color.White;
            DisplayClasss.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayClasss.Location = new Point(12, 85);
            DisplayClasss.Name = "DisplayClasss";
            DisplayClasss.RowHeadersWidth = 51;
            DisplayClasss.Size = new Size(769, 253);
            DisplayClasss.TabIndex = 7;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(815, 465);
            Controls.Add(DisplayClasss);
            Controls.Add(Assign_teacherBtn);
            Controls.Add(Delete_btn);
            Controls.Add(Update_btn);
            Controls.Add(Add_btn);
            Controls.Add(Search_btn);
            Controls.Add(seahrch_tbx);
            Margin = new Padding(2);
            Name = "ClassManagement";
            Text = "Class Management";
            Load += ClassManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayClasss).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox seahrch_tbx;
        private Button Search_btn;
        private Button Add_btn;
        private Button Update_btn;
        private Button Delete_btn;
        private Button Assign_teacherBtn;
        private DataGridView DisplayClasss;
    }
}