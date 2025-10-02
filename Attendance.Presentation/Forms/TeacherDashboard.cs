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
    public partial class TeacherDashboard : Form
    {
        private readonly User _user;
        private readonly TakeAttendance _takeAttendanceForm;
        private readonly ViewClassAttendance _classManagementForm;
        private readonly Reports _reportsForm;
        private readonly DatabaseLog _databaseLogForm;
        private bool _isLoggingOut = false;
        public TeacherDashboard(User user)
        {
            InitializeComponent();
            timerDateAndTime.Start();
            lblAppName.AutoSize = true;
            _user = user;
            lblUserName.Text = $"User: {_user.UserName}";
            lblRoleName.Text = $"Role: Teacher";

            // Pre-load forms
            _takeAttendanceForm = new TakeAttendance
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            _classManagementForm = new ViewClassAttendance
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            // Add forms to main content panel
            mainContentPanel.Controls.Add(_takeAttendanceForm);
            mainContentPanel.Controls.Add(_classManagementForm);

            // Set User Management as the default active tab
            _takeAttendanceForm.BringToFront();
            _takeAttendanceForm.Show();

            this.FormClosed += TeacherDashboard_FormClosed;
        }

        private void TeacherDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
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
        private void MoveSidePanel(Control btn)
        {
            panelSlide.Location = new Point(btn.Location.X - btn.Location.X, btn.Location.Y - 180);
        }

        private void TeacherDashboard_FormClosed_1(object sender, FormClosedEventArgs e)
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
                MoveSidePanel(btnTakeAttendance);
                _takeAttendanceForm.BringToFront();
                _takeAttendanceForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSidePanel(btnClassManagement);
                _classManagementForm.BringToFront();
                _classManagementForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
