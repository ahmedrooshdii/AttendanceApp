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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            RoundedForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            lbLogin = new Label();
            lbClose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            DragableForm = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 20;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(27, 335);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(313, 51);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Sign in";
            btnLogin.Click += Login;
            // 
            // RoundedForm
            // 
            RoundedForm.BorderRadius = 20;
            RoundedForm.TargetControl = this;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(lbLogin);
            guna2GradientPanel1.Controls.Add(lbClose);
            guna2GradientPanel1.CustomizableEdges = customizableEdges7;
            guna2GradientPanel1.FillColor = Color.FromArgb(255, 77, 165);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(94, 148, 255);
            guna2GradientPanel1.Location = new Point(-8, -9);
            guna2GradientPanel1.Margin = new Padding(5);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.Size = new Size(377, 110);
            guna2GradientPanel1.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbLogin.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(125, 33);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(127, 54);
            lbLogin.TabIndex = 4;
            lbLogin.Text = "Login";
            // 
            // lbClose
            // 
            lbClose.BackColor = Color.Transparent;
            lbClose.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbClose.ForeColor = Color.LightCyan;
            lbClose.Location = new Point(330, 5);
            lbClose.Margin = new Padding(5);
            lbClose.Name = "lbClose";
            lbClose.Size = new Size(31, 56);
            lbClose.TabIndex = 1;
            lbClose.Text = "×";
            lbClose.Click += Exit;
            // 
            // tbUserName
            // 
            tbUserName.BorderRadius = 15;
            tbUserName.BorderThickness = 0;
            tbUserName.CustomizableEdges = customizableEdges5;
            tbUserName.DefaultText = "";
            tbUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbUserName.Font = new Font("Segoe UI", 14F);
            tbUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbUserName.IconRight = (Image)resources.GetObject("tbUserName.IconRight");
            tbUserName.IconRightOffset = new Point(5, 0);
            tbUserName.IconRightSize = new Size(30, 30);
            tbUserName.Location = new Point(27, 140);
            tbUserName.Margin = new Padding(5, 6, 5, 6);
            tbUserName.Name = "tbUserName";
            tbUserName.PlaceholderText = "";
            tbUserName.SelectedText = "";
            tbUserName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbUserName.Size = new Size(313, 58);
            tbUserName.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BorderRadius = 15;
            tbPassword.BorderThickness = 0;
            tbPassword.CustomizableEdges = customizableEdges3;
            tbPassword.DefaultText = "";
            tbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.Font = new Font("Segoe UI", 14F);
            tbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPassword.IconLeftSize = new Size(50, 50);
            tbPassword.IconRight = (Image)resources.GetObject("tbPassword.IconRight");
            tbPassword.IconRightOffset = new Point(5, 0);
            tbPassword.IconRightSize = new Size(30, 30);
            tbPassword.Location = new Point(27, 232);
            tbPassword.Margin = new Padding(5, 6, 5, 6);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "";
            tbPassword.SelectedText = "";
            tbPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbPassword.Size = new Size(313, 58);
            tbPassword.TabIndex = 1;
            // 
            // DragableForm
            // 
            DragableForm.DockIndicatorTransparencyValue = 0D;
            DragableForm.TargetControl = guna2GradientPanel1;
            DragableForm.UseTransparentDrag = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 417);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2Elipse RoundedForm;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbClose;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2DragControl DragableForm;
        private Label lbLogin;
    }
}