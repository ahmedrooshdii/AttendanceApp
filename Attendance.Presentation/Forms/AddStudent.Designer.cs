namespace Attendance.Presentation.Forms
{
    partial class AddStudent
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddBtn = new Guna.UI2.WinForms.Guna2Button();
            CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            userNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ClassComb = new Guna.UI2.WinForms.Guna2ComboBox();
            UserPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            fullNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(105, 85);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(105, 150);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(105, 215);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 2;
            label3.Text = "Class";
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.CustomizableEdges = customizableEdges1;
            AddBtn.DisabledState.BorderColor = Color.DarkGray;
            AddBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddBtn.FillColor = Color.Green;
            AddBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(167, 281);
            AddBtn.Name = "AddBtn";
            AddBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddBtn.Size = new Size(98, 37);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.CustomizableEdges = customizableEdges3;
            CancelBtn.DisabledState.BorderColor = Color.DarkGray;
            CancelBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CancelBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CancelBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CancelBtn.FillColor = Color.Gray;
            CancelBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(306, 281);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CancelBtn.Size = new Size(98, 37);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            // 
            // userNameTxt
            // 
            userNameTxt.CustomizableEdges = customizableEdges5;
            userNameTxt.DefaultText = "";
            userNameTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userNameTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userNameTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userNameTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userNameTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userNameTxt.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            userNameTxt.ForeColor = Color.Black;
            userNameTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userNameTxt.Location = new Point(242, 85);
            userNameTxt.Margin = new Padding(4);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.PlaceholderText = "";
            userNameTxt.SelectedText = "";
            userNameTxt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            userNameTxt.Size = new Size(200, 36);
            userNameTxt.TabIndex = 8;
            // 
            // ClassComb
            // 
            ClassComb.BackColor = Color.Transparent;
            ClassComb.CustomizableEdges = customizableEdges7;
            ClassComb.DrawMode = DrawMode.OwnerDrawFixed;
            ClassComb.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComb.FocusedColor = Color.FromArgb(94, 148, 255);
            ClassComb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ClassComb.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ClassComb.ForeColor = Color.Black;
            ClassComb.ItemHeight = 30;
            ClassComb.Location = new Point(242, 204);
            ClassComb.Name = "ClassComb";
            ClassComb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClassComb.Size = new Size(200, 36);
            ClassComb.TabIndex = 11;
            // 
            // UserPassTxt
            // 
            UserPassTxt.CustomizableEdges = customizableEdges9;
            UserPassTxt.DefaultText = "";
            UserPassTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            UserPassTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            UserPassTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            UserPassTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            UserPassTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            UserPassTxt.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            UserPassTxt.ForeColor = Color.Black;
            UserPassTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            UserPassTxt.Location = new Point(242, 150);
            UserPassTxt.Margin = new Padding(4);
            UserPassTxt.Name = "UserPassTxt";
            UserPassTxt.PlaceholderText = "";
            UserPassTxt.SelectedText = "";
            UserPassTxt.ShadowDecoration.CustomizableEdges = customizableEdges10;
            UserPassTxt.Size = new Size(200, 36);
            UserPassTxt.TabIndex = 10;
            UserPassTxt.UseSystemPasswordChar = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(105, 27);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 12;
            label4.Text = "Full Name";
            // 
            // fullNameTxt
            // 
            fullNameTxt.CustomizableEdges = customizableEdges11;
            fullNameTxt.DefaultText = "";
            fullNameTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            fullNameTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            fullNameTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            fullNameTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            fullNameTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            fullNameTxt.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameTxt.ForeColor = Color.Black;
            fullNameTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            fullNameTxt.Location = new Point(242, 27);
            fullNameTxt.Margin = new Padding(4);
            fullNameTxt.Name = "fullNameTxt";
            fullNameTxt.PlaceholderText = "";
            fullNameTxt.SelectedText = "";
            fullNameTxt.ShadowDecoration.CustomizableEdges = customizableEdges12;
            fullNameTxt.Size = new Size(200, 36);
            fullNameTxt.TabIndex = 13;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 338);
            Controls.Add(fullNameTxt);
            Controls.Add(label4);
            Controls.Add(ClassComb);
            Controls.Add(UserPassTxt);
            Controls.Add(userNameTxt);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(551, 377);
            MinimumSize = new Size(551, 377);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private Guna.UI2.WinForms.Guna2TextBox userNameTxt;
        private Guna.UI2.WinForms.Guna2ComboBox ClassComb;
        private Guna.UI2.WinForms.Guna2TextBox UserPassTxt;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTxt;
    }
}