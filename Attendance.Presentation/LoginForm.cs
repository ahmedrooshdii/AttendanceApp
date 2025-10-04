using Attendance.Domain.Contracts.Services;
using Attendance.Presentation.Forms;
using Attendance.Service;
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
        private readonly ITeacherService _teacherService;
        private readonly IClassServices _classService;
        private readonly IAttendanceService _attendanceService;
        private readonly IUserService userServices;
        private readonly IStudentService _studentService;

        public LoginForm(IAuthService authService, ITeacherService teacherService, IClassServices classService, IAttendanceService attendanceService, IUserService userServices, IStudentService studentService)
        {
            InitializeComponent();
            _authService = authService;
            _teacherService = teacherService;
            _classService = classService;
            _attendanceService = attendanceService;
            this.userServices = userServices;
            _studentService = studentService;
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
                    txt.UseSystemPasswordChar = false;
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
                    txt.UseSystemPasswordChar = originalUseSystemPasswordChar;
                    tbPassword.PasswordChar = originalPasswordChar;
                }
            }

            txt.GotFocus += (s, e) => HidePlaceholder();
            txt.LostFocus += (s, e) => ShowPlaceholder();

            txt.TextChanged += (s, e) =>
            {
                if (!txt.Focused && string.IsNullOrEmpty(txt.Text))
                    ShowPlaceholder();
                else if (!string.IsNullOrEmpty(txt.Text) && isPlaceholderActive && txt.Focused)
                    HidePlaceholder();
            };

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
                    var adminDashboard = new AdminDashboard(user, _classService, _teacherService, _studentService, _attendanceService, userServices);
                    adminDashboard.Owner = this;
                    adminDashboard.Show();
                }
                else if (user.RoleId == 2)
                {
                    // Teacher
                    this.Hide();
                    var teacherDashboard = new TeacherDashboard(user, _teacherService, _classService, _attendanceService, userServices, _studentService);
                    teacherDashboard.Owner = this;
                    teacherDashboard.Show();
                }
                else if (user.RoleId == 3)
                {
                    // Student
                    this.Hide();
                    var studentDashboard = new StudentDashboard(user, _classService, userServices, _teacherService, _studentService, _attendanceService);
                    studentDashboard.Owner = this;
                    studentDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
