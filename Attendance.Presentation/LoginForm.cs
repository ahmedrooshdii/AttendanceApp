using Attendance.Domain.Contracts.Services;
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
        public LoginForm(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;

            // UI Enhancements
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
                    txt.PasswordChar = originalPasswordChar;
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
            if (await _authService.LoginAsync(tbUserName.Text, tbPassword.Text))
                MessageBox.Show("Login successful!");
            else
                MessageBox.Show("Invalid username or password.");
        }
    }
}
