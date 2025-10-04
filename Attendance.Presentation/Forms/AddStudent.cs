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
    public partial class AddStudent : Form
    {
        private readonly AttendanceDbContext _db;
        private readonly User _user;
        private readonly bool _isEdit;

        public AddStudent(AttendanceDbContext db)
        {
            InitializeComponent();
            _db = db;
            _isEdit = false;

            this.Load += AddStudent_Load;
            AddBtn.Click += AddStudentBtn_Click;
            CancelBtn.Click += CancelBtn_Click;
        }

        public AddStudent(AttendanceDbContext db, User user) : this(db)
        {
            _user = user;
            _isEdit = true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                var classes = _db.Classes
                    .Select(c => new { c.ClassId, c.ClassName })
                    .ToList();

                if (classes.Count == 0)
                {
                    MessageBox.Show("No classes found in the database.");
                    return;
                }

                ClassComb.DataSource = classes;
                ClassComb.DisplayMember = "ClassName";
                ClassComb.ValueMember = "ClassId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classes: {ex.Message}");
            }

            UserPassTxt.UseSystemPasswordChar = true;

            if (_isEdit && _user != null)
            {
                userNameTxt.Text = _user.UserName;

                var student = _db.Students.FirstOrDefault(s => s.UserId == _user.UserId);
                if (student != null)
                {
                    fullNameTxt.Text = student.StudentName;
                    ClassComb.SelectedValue = student.ClassId;
                }

                AddBtn.Text = "Update";
            }
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text.Trim();
            string password = UserPassTxt.Text.Trim();

            if (ClassComb.SelectedValue == null)
            {
                MessageBox.Show("Please select a class.");
                return;
            }

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            int classId = (int)ClassComb.SelectedValue;

            try
            {
                if (_isEdit)
                {
                    _user.UserName = userName;

                    if (!string.IsNullOrEmpty(password))
                        _user.Password = HashPassword(password);

                    var student = _db.Students.FirstOrDefault(s => s.UserId == _user.UserId);
                    if (student != null)
                        student.ClassId = classId;
                        student.StudentName = fullNameTxt.Text.Trim();

                    _db.Users.Update(_user);
                    _db.SaveChanges();

                    MessageBox.Show("Student updated successfully!");
                }
                else
                {
                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter password.");
                        return;
                    }

                    string hashedPassword = HashPassword(password);

                    var user = new User
                    {
                        UserName = userName,
                        Password = hashedPassword,
                        RoleId = 3
                    };

                    _db.Users.Add(user);
                    _db.SaveChanges();

                    var student = new Student
                    {
                        StudentName = fullNameTxt.Text.Trim(),
                        UserId = user.UserId,
                        ClassId = classId
                    };

                    _db.Students.Add(student);
                    _db.SaveChanges();

                    MessageBox.Show("Student added successfully!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student: {ex.Message}");
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


    }
}
