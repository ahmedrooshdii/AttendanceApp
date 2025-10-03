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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            headerPanel = new Panel();
            lblAppName = new Label();
            lblUserName = new Label();
            lblRoleName = new Label();
            btnLogout = new Button();
            sideNavPanel = new Panel();
            btnReports = new Button();
            btnDatabaseLog = new Button();
            btnClassManagement = new Button();
            btnUserManagement = new Button();
            panel4 = new Panel();
            panelSlide = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mainContentPanel = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblDate = new Label();
            timerDataAndTime = new System.Windows.Forms.Timer(components);
            sideNavPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainContentPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Location = new Point(81, 125);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(774, 180);
            headerPanel.TabIndex = 2;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(23, 118);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(212, 19);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Attendance Management";
            // 
            // lblUserName
            // 
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(50, 22);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(111, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User: Admin";
            // 
            // lblRoleName
            // 
            lblRoleName.ForeColor = Color.White;
            lblRoleName.Location = new Point(250, 22);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(132, 23);
            lblRoleName.TabIndex = 2;
            lblRoleName.Text = "Role: Admin";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Red;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(816, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // sideNavPanel
            // 
            sideNavPanel.BackColor = Color.FromArgb(67, 3, 125);
            sideNavPanel.Controls.Add(btnReports);
            sideNavPanel.Controls.Add(btnDatabaseLog);
            sideNavPanel.Controls.Add(btnClassManagement);
            sideNavPanel.Controls.Add(btnUserManagement);
            sideNavPanel.Controls.Add(panel4);
            sideNavPanel.Controls.Add(panel1);
            sideNavPanel.Dock = DockStyle.Left;
            sideNavPanel.ForeColor = Color.White;
            sideNavPanel.Location = new Point(0, 0);
            sideNavPanel.Name = "sideNavPanel";
            sideNavPanel.Size = new Size(258, 681);
            sideNavPanel.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(8, 418);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(250, 80);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports        ";
            btnReports.Click += BtnReports_Click;
            // 
            // btnDatabaseLog
            // 
            btnDatabaseLog.Dock = DockStyle.Top;
            btnDatabaseLog.FlatAppearance.BorderSize = 0;
            btnDatabaseLog.FlatStyle = FlatStyle.Flat;
            btnDatabaseLog.ForeColor = Color.White;
            btnDatabaseLog.Image = (Image)resources.GetObject("btnDatabaseLog.Image");
            btnDatabaseLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatabaseLog.Location = new Point(8, 338);
            btnDatabaseLog.Name = "btnDatabaseLog";
            btnDatabaseLog.Size = new Size(250, 80);
            btnDatabaseLog.TabIndex = 3;
            btnDatabaseLog.Text = "Database Log";
            btnDatabaseLog.Click += BtnDatabaseLog_Click;
            // 
            // btnClassManagement
            // 
            btnClassManagement.Dock = DockStyle.Top;
            btnClassManagement.FlatAppearance.BorderSize = 0;
            btnClassManagement.FlatStyle = FlatStyle.Flat;
            btnClassManagement.ForeColor = Color.White;
            btnClassManagement.Image = (Image)resources.GetObject("btnClassManagement.Image");
            btnClassManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassManagement.Location = new Point(8, 258);
            btnClassManagement.Name = "btnClassManagement";
            btnClassManagement.Size = new Size(250, 80);
            btnClassManagement.TabIndex = 1;
            btnClassManagement.Text = "Class Management";
            btnClassManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClassManagement.Click += BtnClassManagement_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(67, 3, 125);
            btnUserManagement.Dock = DockStyle.Top;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Image = (Image)resources.GetObject("btnUserManagement.Image");
            btnUserManagement.ImageAlign = ContentAlignment.TopLeft;
            btnUserManagement.Location = new Point(8, 178);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(250, 80);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += BtnUserManagement_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelSlide);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 503);
            panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 80);
            panelSlide.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 178);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 137);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 0;
            label1.Text = "System";
            // 
            // mainContentPanel
            // 
            mainContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContentPanel.Controls.Add(headerPanel);
            mainContentPanel.Location = new Point(282, 93);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(879, 563);
            mainContentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(258, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(926, 72);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(67, 3, 125);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(lblRoleName);
            panel3.Controls.Add(lblUserName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(926, 72);
            panel3.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(427, 22);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(287, 19);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date : ";
            // 
            // timerDataAndTime
            // 
            timerDataAndTime.Tick += timerDataAndTime_Tick;
            // 
            // AdminDashboard
            // 
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(panel2);
            Controls.Add(mainContentPanel);
            Controls.Add(sideNavPanel);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            FormClosed += AdminDashboard_FormClosed_1;
            sideNavPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainContentPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label lblDate;
        private Panel panel4;
        private Panel panelSlide;
        private System.Windows.Forms.Timer timerDataAndTime;
        private PictureBox pictureBox1;
    }
}