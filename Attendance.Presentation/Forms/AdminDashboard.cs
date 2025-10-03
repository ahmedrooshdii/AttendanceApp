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
        private readonly  AttendanceDbContext db;
        public AdminDashboard(User user,AttendanceDbContext _db)
        {
            InitializeComponent();
            db = _db;

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
            _classManagementForm = new ClassManagement(db)
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
            this.Owner.Show();
            this.Close();
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
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
                // Bring the pre-loaded UserManagement form to the front
                _databaseLogForm.BringToFront();
                _databaseLogForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
