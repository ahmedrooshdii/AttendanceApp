using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;

namespace Attendance.Presentation.Forms
{
    public partial class StudentDashboard : BaseDashboardForm
    {
        private readonly User _user;
        private readonly ViewAttendance _viewAttendanceForm;
        private readonly Reports _reportsForm;
        private readonly DatabaseLog _databaseLogForm;
        private bool _isLoggingOut = false;

        private readonly IClassServices classServices;
        private readonly IUserService userServices;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;
        private readonly IAttendanceService attendanceService;

        public StudentDashboard(User user, IClassServices _classServices, IUserService _userServices, ITeacherService _teacherService, IStudentService _studentService, IAttendanceService _attendanceService)
        {
            InitializeComponent();
            timerDateAndTime.Start();
            lblAppName.AutoSize = true;
            _user = user;
            lblUserName.Text = $"User: {_user.UserName}";
            lblRoleName.Text = $"Role: Student";
            classServices = _classServices;
            userServices = _userServices;
            teacherService = _teacherService;
            studentService = _studentService;
            attendanceService = _attendanceService;


            // Pre-load forms
            _viewAttendanceForm = new ViewAttendance(user.UserId, classServices, userServices, teacherService, studentService, attendanceService)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Add forms to main content panel
            mainContentPanel.Controls.Add(_viewAttendanceForm);

            // Set User Management as the default active tab
            _viewAttendanceForm.BringToFront();
            _viewAttendanceForm.Show();
            this.FormClosed += StudentDashboard_FormClosed;
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _isLoggingOut = true;
            timerDateAndTime.Stop();
            this.Owner.Show();
            this.Close();
        }
        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDate.Text = "Date: " + now.ToString("MMMM dd, yyyy");
        }

        private void StudentDashboard_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            try
            {   
                _viewAttendanceForm.BringToFront();
                _viewAttendanceForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected internal override void OnUserInitialized(User user)
        {
            lblUserName.Text = $"User: {_user.UserName}";
            lblRoleName.Text = $"Role: Student";
        }
    }
}
