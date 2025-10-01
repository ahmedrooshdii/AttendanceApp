using Attendance.Domain.Entities;
using System;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly User _user;
        private readonly UserManagement _userManagementForm;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            _user = user;
            lblUserName.Text = $"User: {_user.UserName}";
            lblRoleName.Text = $"Role: Admin";

            // Pre-load the UserManagement form
            _userManagementForm = new UserManagement
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            mainContentPanel.Controls.Add(_userManagementForm);

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
    }
}
