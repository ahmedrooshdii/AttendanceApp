using Attendance.Infrastructure.Data;
using Attendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class UserManagement : Form
    {
        private readonly AttendanceDbContext _db;

        public UserManagement()
        {

            InitializeComponent();
            var options = new DbContextOptionsBuilder<AttendanceDbContext>()
        .UseSqlServer("Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True;TrustServerCertificate=True;")
        .Options;

            _db = new AttendanceDbContext(options);

            this.Load += FormUsers_Load;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _db.Users
                .Include(u => u.Role)
                .Select(u => new
                {
                    u.UserId,
                    u.UserName,
                    Role = u.Role != null ? u.Role.RoleName : ""
                })
                .ToList();

            dgvUsers.DataSource = users;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            var users = _db.Users
                .Include(u => u.Role)
                .Where(u =>
                    EF.Functions.Like(u.UserId.ToString(), $"%{searchText}%") ||
                    EF.Functions.Like(u.UserName, $"%{searchText}%") ||
                    (u.Role != null && EF.Functions.Like(u.Role.RoleName, $"%{searchText}%"))
                )
                .Select(u => new
                {
                    u.UserId,
                    u.UserName,
                    Role = u.Role != null ? u.Role.RoleName : ""
                })
                .ToList();

            dgvUsers.DataSource = users;
        }

        private void BtnAddAdmin_Click(object sender, EventArgs e)
        {
            using (AddAdmin frm = new AddAdmin(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            using (AddStudent frm = new AddStudent(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            using (AddTeacher frm = new AddTeacher(_db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
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
                    using var transaction = _db.Database.BeginTransaction();
                    try
                    {
                        var teacher = _db.Teachers.FirstOrDefault(t => t.UserId == userId);
                        if (teacher != null)
                        {
                            var teacherClasses = _db.TeacherClasses.Where(tc => tc.TeacherId == teacher.TeacherId);
                            _db.TeacherClasses.RemoveRange(teacherClasses);
                            _db.Teachers.Remove(teacher);
                        }

                        var student = _db.Students.FirstOrDefault(s => s.UserId == userId);
                        if (student != null)
                        {
                            _db.Students.Remove(student);
                        }

                        var user = _db.Users.FirstOrDefault(u => u.UserId == userId);
                        if (user != null)
                        {
                            _db.Users.Remove(user);
                        }

                        _db.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
                var user = _db.Users
                              .Include(u => u.Role)
                              .FirstOrDefault(u => u.UserId == userId);

                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }
                if (user.RoleId == 1) 
                {
                    using (AddAdmin frm = new AddAdmin(_db, user)) 
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadUsers();
                        }
                    }
                }
                else if (user.RoleId == 2) 
                {
                    using (AddTeacher frm = new AddTeacher(_db, user))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadUsers();
                        }
                    }
                }
                else if (user.RoleId == 3) 
                {
                    using (AddStudent frm = new AddStudent(_db, user))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadUsers();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unknown role, cannot edit this user.");
                }
            }
            else
            {
                MessageBox.Show("Please select user to edit ");
            }
        }



    }
}