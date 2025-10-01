using Attendance.Domain.Contracts.Services;
using Attendance.Presentation.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly AdminDashboard _adminDashboard;
        private readonly TeacherDashboard _teacherDashboard;
        private readonly StudentDashboard _studentDashboard;

        public LoginForm(IAuthService authService, AdminDashboard adminDashboard , TeacherDashboard teacherDashboard, StudentDashboard studentDashboard)
        {
            InitializeComponent();
            _authService = authService;
            _adminDashboard = adminDashboard;
            _teacherDashboard = teacherDashboard;
            _studentDashboard = studentDashboard;

            // UI Enhancements
            //tbPassword.UseSystemPasswordChar = true;
            SetPlaceholder(tbUserName, "Username");
            SetPlaceholder(tbPassword, "Password");
            tbUserName.Focus();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetPlaceholder(Guna2TextBox txt, string placeholder)
        {
            Color originalColor = txt.ForeColor;
            bool originalUseSystemPasswordChar = txt.UseSystemPasswordChar;
            char originalPasswordChar = txt.PasswordChar;
            bool isPlaceholderActive = false;

            void ShowPlaceholder()
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    isPlaceholderActive = true;
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                    // disable password masking while placeholder is shown
                    txt.UseSystemPasswordChar = false;
                    //tbUserName.PasswordChar = originalPasswordChar;
                    tbPassword.PasswordChar = '●';

                }
            }

            void HidePlaceholder()
            {
                if (isPlaceholderActive)
                {
                    isPlaceholderActive = false;
                    txt.Text = "";
                    txt.ForeColor = originalColor;
                    // restore password masking
                    txt.UseSystemPasswordChar = originalUseSystemPasswordChar;
                    tbPassword.PasswordChar = originalPasswordChar; // Use a bullet character for masking
                    //txt.PasswordChar = originalPasswordChar;
                }
            }

            txt.GotFocus += (s, e) => HidePlaceholder();
            txt.LostFocus += (s, e) => ShowPlaceholder();

            // If user types programmatically, keep state consistent
            txt.TextChanged += (s, e) =>
            {
                if (!txt.Focused && string.IsNullOrEmpty(txt.Text))
                    ShowPlaceholder();
                else if (!string.IsNullOrEmpty(txt.Text) && isPlaceholderActive && txt.Focused)
                    HidePlaceholder();
            };

            // initialize
            ShowPlaceholder();
        }

        private async void Login(object sender, EventArgs e)
        {
            var user = await _authService.LoginAsync(tbUserName.Text, tbPassword.Text);
            if (user != null && user.UserId > 0)
            {
                MessageBox.Show("Login successful!", "login", MessageBoxButtons.OK);
                if (user.RoleId == 1)
                {
                    // Admin
                    this.Hide();
                    _adminDashboard.Owner = (LoginForm)this;
                    _adminDashboard.Show();
                }
                else if (user.RoleId == 2)
                {
                    // Teacher
                    this.Hide();
                    _teacherDashboard.Owner = (LoginForm)this;
                    _teacherDashboard.Show();

                }
                else if (user.RoleId == 3)
                {
                    // Student
                    this.Hide();
                    _studentDashboard.Owner = (LoginForm)this;
                    _studentDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
