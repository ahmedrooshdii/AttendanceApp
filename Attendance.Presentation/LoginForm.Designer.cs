namespace Attendance.Presentation
{
    partial class LoginForm
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
            pnlLogin = new Panel();
            lbClose = new Label();
            lbLogin = new Label();
            tbPassword = new TextBox();
            pnlPassword = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tbUserName = new TextBox();
            panel1 = new Panel();
            pnlUserName = new Panel();
            pnlLogin.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlUserName.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.DodgerBlue;
            pnlLogin.Controls.Add(lbClose);
            pnlLogin.Controls.Add(lbLogin);
            pnlLogin.Location = new Point(-2, -3);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(618, 134);
            pnlLogin.TabIndex = 3;
            // 
            // lbClose
            // 
            lbClose.AutoSize = true;
            lbClose.BackColor = Color.Red;
            lbClose.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lbClose.ForeColor = Color.White;
            lbClose.Location = new Point(560, -10);
            lbClose.Name = "lbClose";
            lbClose.Size = new Size(64, 67);
            lbClose.TabIndex = 5;
            lbClose.Text = "×";
            lbClose.Click += Exit;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbLogin.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(219, 35);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(161, 67);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            // 
            // tbPassword
            // 
            tbPassword.AutoCompleteCustomSource.AddRange(new string[] { "admin", "teacher", "student1" });
            tbPassword.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPassword.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI", 14F);
            tbPassword.Location = new Point(25, 14);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(455, 32);
            tbPassword.TabIndex = 1;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.White;
            pnlPassword.Controls.Add(tbPassword);
            pnlPassword.Location = new Point(54, 253);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(495, 60);
            pnlPassword.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(54, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 60);
            panel2.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(138, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(323, 57);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += Login;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // tbUserName
            // 
            tbUserName.AutoCompleteCustomSource.AddRange(new string[] { "admin", "teacher", "student1" });
            tbUserName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Font = new Font("Segoe UI", 14F);
            tbUserName.Location = new Point(25, 14);
            tbUserName.Margin = new Padding(5);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(455, 32);
            tbUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 60);
            panel1.TabIndex = 7;
            // 
            // pnlUserName
            // 
            pnlUserName.BackColor = Color.White;
            pnlUserName.Controls.Add(panel1);
            pnlUserName.Controls.Add(tbUserName);
            pnlUserName.Location = new Point(54, 159);
            pnlUserName.Name = "pnlUserName";
            pnlUserName.Size = new Size(495, 60);
            pnlUserName.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 418);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(pnlPassword);
            Controls.Add(pnlUserName);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Init;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlUserName.ResumeLayout(false);
            pnlUserName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLogin;
        private Label lbLogin;
        private Label lbClose;

        private TextBox tbPassword;
        private Panel pnlPassword;
        private Panel panel2;
        private Button btnLogin;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox tbUserName;
        private Panel panel1;
        private Panel pnlUserName;
    }
}