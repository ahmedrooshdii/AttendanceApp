using Attendance.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly User _user;
        private readonly UserManagement _userManagementForm;
        private readonly ClassManagement _classManagementForm;
        private readonly Reports _reportsForm;
        private readonly DatabaseLog _databaseLogForm;
        private bool _isLoggingOut = false;
        public AdminDashboard(User user)
        {
            InitializeComponent();
            timerDataAndTime.Start();
            lblAppName.AutoSize = true;
            _user = user;
            lblUserName.Text = $"User: {_user.UserName}";
            lblRoleName.Text = $"Role: Admin";

            // Pre-load forms
            _userManagementForm = new UserManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            _classManagementForm = new ClassManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            _reportsForm = new Reports
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            _databaseLogForm = new DatabaseLog
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Add forms to main content panel
            mainContentPanel.Controls.Add(_userManagementForm);
            mainContentPanel.Controls.Add(_classManagementForm);
            mainContentPanel.Controls.Add(_reportsForm);
            mainContentPanel.Controls.Add(_databaseLogForm);

            // Set User Management as the default active tab
            _userManagementForm.BringToFront();
            _userManagementForm.Show();

            this.FormClosed += AdminDashboard_FormClosed;
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            _isLoggingOut = true;
            timerDataAndTime.Stop();
            this.Owner.Show();
            this.Close();
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSidePanel(btnUserManagement);
                // Bring the pre-loaded UserManagement form to the front
                _userManagementForm.BringToFront();
                _userManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClassManagement_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSidePanel(btnClassManagement);
                // Bring the pre-loaded UserManagement form to the front
                _classManagementForm.BringToFront();
                _classManagementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSidePanel(btnReports);
                // Bring the pre-loaded UserManagement form to the front
                _reportsForm.BringToFront();
                _reportsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDatabaseLog_Click(object sender, EventArgs e)
        {
            try
            {
                MoveSidePanel(btnDatabaseLog);
                // Bring the pre-loaded UserManagement form to the front
                _databaseLogForm.BringToFront();
                _databaseLogForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerDataAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDate.Text = now.ToString("MMMM dd, yyyy");
        }
        private void MoveSidePanel(Control btn)
        {
            panelSlide.Location = new Point(btn.Location.X - btn.Location.X, btn.Location.Y - 180);
        }

        private void AdminDashboard_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
