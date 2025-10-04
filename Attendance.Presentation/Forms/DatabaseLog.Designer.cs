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
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.Font = new Font("Segoe UI", 10F);
            btnBackup.Location = new Point(24, 62);
            btnBackup.Margin = new Padding(2);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(126, 60);
            btnBackup.TabIndex = 1;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += Backup;
            // 
            // btnRestore
            // 
            btnRestore.Font = new Font("Segoe UI", 10F);
            btnRestore.Location = new Point(171, 62);
            btnRestore.Margin = new Padding(2);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(126, 60);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += Restore;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(312, 62);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 60);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += Cancel;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(24, 26);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // DatabaseLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
            Margin = new Padding(2);
            Name = "DatabaseLog";
            Text = "Database Log";
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnBackup;
        private Button btnRestore;
        private Button btnCancel;
        private Label lblStatus;
    }
}