namespace Attendance.Presentation.Forms
{
    partial class DatabaseLog
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
            btnBackup = new Button();
            btnRestore = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.DarkOrchid;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(14, 33);
            btnBackup.Margin = new Padding(2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(198, 121);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += Backup;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.DarkOrchid;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(219, 33);
            btnRestore.Margin = new Padding(2);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(198, 121);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += Restore;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkOrchid;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(424, 33);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 121);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += Cancel;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(14, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            lblStatus.Click += lblStatus_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnRestore);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(btnBackup);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(0, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 183);
            panel1.TabIndex = 3;
            // 
            // DatabaseLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "DatabaseLog";
            Text = "Database Log";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        private Button btnBackup;
        private Button btnRestore;
        private Button btnCancel;
        private Label lblStatus;
        private Panel panel1;
    }
}