using Attendance.Infrastructure.Data;
using Attendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class AddTeacher : Form
    {
        private readonly AttendanceDbContext _db;
        private readonly User _user;      
        private readonly bool _isEdit;     

        public AddTeacher(AttendanceDbContext db)
        {
            InitializeComponent();
            _db = db;
            _isEdit = false;

            this.Load += AddTeacher_Load;
            AddBtn.Click += AddTeacherBtn_Click;
            CancelBtn.Click += CancelBtn_Click;
        }

        public AddTeacher(AttendanceDbContext db, User user) : this(db)
        {
            _user = user;
            _isEdit = true;
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                var classes = _db.Classes
                    .Select(c => new { c.ClassId, c.ClassName })
                    .ToList();

                if (!classes.Any())
                {
                    MessageBox.Show("No classes found in the database.");
                    return;
                }

                ClassComb.Items.Clear();
                foreach (var c in classes)
                {
                    ClassComb.Items.Add(new ClassItem
                    {
                        ClassID = c.ClassId,
                        ClassName = c.ClassName
                    });
                }
                ClassComb.DisplayMember = "ClassName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classes: {ex.Message}");
            }

            UserPassTxt.UseSystemPasswordChar = true;

            if (_isEdit && _user != null)
            {
                userNameTxt.Text = _user.UserName;
                var teacher = _db.Teachers
                                 .Include(t => t.TeacherClasses)
                                 .FirstOrDefault(t => t.UserId == _user.UserId);

                if (teacher != null)
                {
                    var teacherClassIds = teacher.TeacherClasses
                                                .Select(tc => tc.ClassId)
                                                .ToHashSet();

                    ClassComb.BeginUpdate();
                    try
                    {
                        for (int i = 0; i < ClassComb.Items.Count; i++)
                        {
                            var classItem = (ClassItem)ClassComb.Items[i];
                            if (teacherClassIds.Contains(classItem.ClassID))
                            {
                                ClassComb.SetItemChecked(i, true);
                            }
                            else
                            {
                                ClassComb.SetItemChecked(i, false); 
                            }
                        }
                    }
                    finally
                    {
                        ClassComb.EndUpdate();
                    }
                }


                AddBtn.Text = "Update";
            }
        }

        private void AddTeacherBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text.Trim();
            string password = UserPassTxt.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (!_isEdit && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.");
                return;
            }

            if (ClassComb.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one class.");
                return;
            }

            using var transaction = _db.Database.BeginTransaction();
            try
            {
                if (_isEdit)
                {
                    _user.UserName = userName;
                    if (!string.IsNullOrEmpty(password))
                        _user.Password = HashPassword(password);

                    _db.Users.Update(_user);
                    _db.SaveChanges();

                    var teacher = _db.Teachers
                                     .Include(t => t.TeacherClasses)
                                     .FirstOrDefault(t => t.UserId == _user.UserId);

                    if (teacher != null)
                    {
                        teacher.TeacherName = userName;

                        _db.TeacherClasses.RemoveRange(teacher.TeacherClasses);
                        _db.SaveChanges();

                        foreach (ClassItem item in ClassComb.CheckedItems)
                        {
                            var tc = new TeacherClass
                            {
                                TeacherId = teacher.TeacherId,
                                ClassId = item.ClassID
                            };
                            _db.TeacherClasses.Add(tc);
                        }
                    }

                    _db.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Teacher updated successfully!");
                }
                else
                {
                    string hashedPassword = HashPassword(password);

                    var user = new User
                    {
                        UserName = userName,
                        Password = hashedPassword,
                        RoleId = 2
                    };
                    _db.Users.Add(user);
                    _db.SaveChanges();

                    var teacher = new Teacher
                    {
                        TeacherName = userName,
                        UserId = user.UserId
                    };
                    _db.Teachers.Add(teacher);
                    _db.SaveChanges();

                    foreach (ClassItem item in ClassComb.CheckedItems)
                    {
                        var tc = new TeacherClass
                        {
                            TeacherId = teacher.TeacherId,
                            ClassId = item.ClassID
                        };
                        _db.TeacherClasses.Add(tc);
                    }

                    _db.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Teacher added successfully!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error saving teacher: {ex.Message}");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        private class ClassItem
        {
            public int ClassID { get; set; }
            public string ClassName { get; set; }
            public override string ToString() => ClassName;
        }
    }
}
