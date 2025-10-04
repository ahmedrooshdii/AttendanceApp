using Attendance.Domain.Contracts.Services;
using Attendance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class UserManagement : Form
    {
        private readonly IUserManagementService _service;
        private readonly AttendanceDbContext _db;

        public UserManagement(IUserManagementService service, AttendanceDbContext db)
        {
            InitializeComponent();
            _service = service;
            _db = db;
            this.Load += FormUsers_Load;
        }

        public UserManagement()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<AttendanceDbContext>()
                .UseSqlServer("Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True;TrustServerCertificate=True;")
                .Options;

            _db = new AttendanceDbContext(options);

            var repo = new Attendance.Infrastructure.Repositories.UserManagementRepository(_db);
            _service = new Attendance.Service.UserManagementService(repo);

            this.Load += FormUsers_Load;
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var users = await _service.GetAllUsersAsync();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                var users = await _service.SearchUsersAsync(searchText);
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddAdmin_Click(object sender, EventArgs e)
        {
            using (AddAdmin frm = new AddAdmin(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadUsersAsync();
                }
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            using (AddStudent frm = new AddStudent(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadUsersAsync();
                }
            }
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            using (AddTeacher frm = new AddTeacher(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _ = LoadUsersAsync();
                }
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
                var confirm = MessageBox.Show("Are you sure you want to delete this user?",
                                              "Confirm",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        bool success = await _service.DeleteUserAsync(userId);
                        if (success)
                        {
                            MessageBox.Show("User deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadUsersAsync();
                        }
                        else
                        {
                            MessageBox.Show("Error deleting user", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                try
                {
                    int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
                    var user = await _service.GetUserByIdAsync(userId);

                    if (user == null)
                    {
                        MessageBox.Show("User not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (user.RoleId == 1) 
                    {
                        using (AddAdmin frm = new AddAdmin(_db, user))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                await LoadUsersAsync();
                            }
                        }
                    }
                    else if (user.RoleId == 2) 
                    {
                        using (AddTeacher frm = new AddTeacher(_db, user))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                await LoadUsersAsync();
                            }
                        }
                    }
                    else if (user.RoleId == 3) 
                    {
                        using (AddStudent frm = new AddStudent(_db, user))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                await LoadUsersAsync();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown role, cannot edit this user.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}