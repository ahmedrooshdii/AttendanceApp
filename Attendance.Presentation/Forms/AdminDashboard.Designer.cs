namespace Attendance.Presentation.Forms
{
    partial class AdminDashboard
    {
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel sideNavPanel;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnClassManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDatabaseLog;

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
            headerPanel = new Panel();
            lblAppName = new Label();
            lblUserName = new Label();
            lblRoleName = new Label();
            btnLogout = new Button();
            sideNavPanel = new Panel();
            btnUserManagement = new Button();
            btnClassManagement = new Button();
            btnReports = new Button();
            btnDatabaseLog = new Button();
            mainContentPanel = new Panel();
            headerPanel.SuspendLayout();
            sideNavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightGray;
            headerPanel.Controls.Add(lblAppName);
            headerPanel.Controls.Add(lblUserName);
            headerPanel.Controls.Add(lblRoleName);
            headerPanel.Controls.Add(btnLogout);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 50);
            headerPanel.TabIndex = 2;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAppName.Location = new Point(10, 15);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(100, 23);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Student Attendance System";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.Location = new Point(400, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(100, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User: Admin";
            // 
            // lblRoleName
            // 
            lblRoleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRoleName.Location = new Point(500, 15);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(100, 23);
            lblRoleName.TabIndex = 2;
            lblRoleName.Text = "Role: Admin";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(700, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.Click += BtnLogout_Click;
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.LightGray;
            sideNavPanel.Controls.Add(btnDatabaseLog);
            sideNavPanel.Controls.Add(btnReports);
            sideNavPanel.Controls.Add(btnClassManagement);
            sideNavPanel.Controls.Add(btnUserManagement);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.Location = new Point(0, 50);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Size = new Size(200, 400);
            sideNavPanel.TabIndex = 1;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.Location = new Point(0, 0);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(200, 23);
            btnUserManagement.TabIndex = 0;
            btnUserManagement.Text = "User Management";
            btnUserManagement.Click += BtnUserManagement_Click;
            // 
            // btnClassManagement
            // 
            btnClassManagement.Dock = DockStyle.Top;
            btnClassManagement.Location = new Point(0, 23);
            btnClassManagement.Name = "btnClassManagement";
            btnClassManagement.Size = new Size(200, 23);
            btnClassManagement.TabIndex = 1;
            btnClassManagement.Text = "Class Management";
            btnClassManagement.Click += BtnClassManagement_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.Location = new Point(0, 46);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 23);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.Click += BtnReports_Click;
            // 
            // btnDatabaseLog
            // 
            btnDatabaseLog.Dock = DockStyle.Top;
            btnDatabaseLog.Location = new Point(0, 69);
            btnDatabaseLog.Name = "btnDatabaseLog";
            btnDatabaseLog.Size = new Size(200, 23);
            btnDatabaseLog.TabIndex = 3;
            btnDatabaseLog.Text = "Database Log";
            btnDatabaseLog.Click += BtnDatabaseLog_Click;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContentPanel.Location = new Point(200, 50);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(575, 377);
            mainContentPanel.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(mainContentPanel);
            Controls.Add(sideNavPanel);
            Controls.Add(headerPanel);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            headerPanel.ResumeLayout(false);
            sideNavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}