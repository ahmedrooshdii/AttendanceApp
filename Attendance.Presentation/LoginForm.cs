using Attendance.Domain.Contracts.Services;
using Attendance.Presentation.Forms;
using Attendance.Service;
using Guna.UI2.WinForms;

namespace Attendance.Presentation
{

    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;


        public LoginForm(IAuthService authService, IServiceProvider serviceProvider)

        {
            InitializeComponent();
            _authService = authService;
            _serviceProvider = serviceProvider;

            // UI Enhancements
            SetPlaceholder(tbUserName, "Username");
            SetPlaceholder(tbPassword, "Password", true);
            tbUserName.Focus();
            this.AcceptButton = btnLogin;
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void SetPlaceholder(TextBox txt, string placeholder)
        //{
        //    Color originalColor = txt.ForeColor;
        //    bool originalUseSystemPasswordChar = txt.UseSystemPasswordChar;
        //    char originalPasswordChar = txt.PasswordChar;
        //    bool isPlaceholderActive = false;

        //    void ShowPlaceholder()
        //    {
        //        if (string.IsNullOrEmpty(txt.Text))
        //        {
        //            isPlaceholderActive = true;
        //            txt.Text = placeholder;
        //            txt.ForeColor = Color.Gray;
        //            txt.UseSystemPasswordChar = false;
        //            tbPassword.PasswordChar = '●';
        //        }
        //    }

        //    void HidePlaceholder()
        //    {
        //        if (isPlaceholderActive)
        //        {
        //            isPlaceholderActive = false;
        //            txt.Text = "";
        //            txt.ForeColor = originalColor;
        //            txt.UseSystemPasswordChar = originalUseSystemPasswordChar;
        //            tbPassword.PasswordChar = originalPasswordChar;
        //        }
        //    }

        //    txt.GotFocus += (s, e) => HidePlaceholder();
        //    txt.LostFocus += (s, e) => ShowPlaceholder();

        //    txt.TextChanged += (s, e) =>
        //    {
        //        if (!txt.Focused && string.IsNullOrEmpty(txt.Text))
        //            ShowPlaceholder();
        //        else if (!string.IsNullOrEmpty(txt.Text) && isPlaceholderActive && txt.Focused)
        //            HidePlaceholder();
        //    };

        //    ShowPlaceholder();
        //}

        private void SetPlaceholder(TextBox txt, string placeholder, bool isPassword = false)
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
                    txt.PasswordChar = originalPasswordChar;
                }
            }

            void HidePlaceholder()
            {
                if (isPlaceholderActive)
                {
                    isPlaceholderActive = false;
                    txt.Text = "";
                    txt.ForeColor = originalColor;

                    if (isPassword)
                    {
                        txt.PasswordChar = '●';
                    }
                    else
                    {
                        txt.PasswordChar = originalPasswordChar;
                    }
                }
            }

            txt.GotFocus += (s, e) => HidePlaceholder();
            txt.LostFocus += (s, e) => ShowPlaceholder();

            txt.TextChanged += (s, e) =>
            {
                if (!txt.Focused && string.IsNullOrEmpty(txt.Text))
                    ShowPlaceholder();
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
                    var adminDashboard = new AdminDashboard(user, _serviceProvider);
                    adminDashboard.InitializeUser(user);
                    adminDashboard.Owner = this;
                    adminDashboard.Show();
                }
                else if (user.RoleId == 2)
                {
                    // Teacher
                    this.Hide();
                    var teacherDashboard = new TeacherDashboard(user, _serviceProvider);
                    //  var teacherDashboard = _serviceProvider.GetRequiredService<TeacherDashboard>();
                    // teacherDashboard.InitializeUser(user);
                    teacherDashboard.Owner = this;
                    teacherDashboard.Show();
                }
                else if (user.RoleId == 3)
                {
                    // Student
                    this.Hide();
                    var studentDashboard = new StudentDashboard(user, _serviceProvider);
                    //var studentDashboard = _serviceProvider.GetRequiredService<StudentDashboard>();
                    studentDashboard.InitializeUser(user);
                    studentDashboard.Owner = this;
                    studentDashboard.Show();
                }
                tbPassword.Text = string.Empty;
                tbUserName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid username or passwordz.");
            }
        }
    }
}
