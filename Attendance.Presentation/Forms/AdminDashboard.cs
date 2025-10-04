using Attendance.Domain.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class AdminDashboard : BaseDashboardForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManagement _userManagementForm;
        private readonly ClassManagement _classManagementForm;
        private readonly Reports _reportsForm;
        private readonly DatabaseLog _databaseLogForm;

        private bool _isLoggingOut = false;

        public AdminDashboard(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            timerDataAndTime.Start();
            lblAppName.AutoSize = true;

            // resolve forms from DI
            _userManagementForm = _serviceProvider.GetRequiredService<UserManagement>();
            _classManagementForm = _serviceProvider.GetRequiredService<ClassManagement>();
            _reportsForm = _serviceProvider.GetRequiredService<Reports>();
            _databaseLogForm = _serviceProvider.GetRequiredService<DatabaseLog>();

            // Pre-load forms
            PrepareForm(_userManagementForm);
            PrepareForm(_classManagementForm);
            PrepareForm(_reportsForm);
            PrepareForm(_databaseLogForm);

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

        private void PrepareForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
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

        protected internal override void OnUserInitialized(User user)
        {
            lblUserName.Text = $"User: {CurrentUser.UserName}";
            lblRoleName.Text = $"Role: Admin";
        }

    }
}