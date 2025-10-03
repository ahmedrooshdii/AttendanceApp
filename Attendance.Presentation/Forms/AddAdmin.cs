using Attendance.Domain.Entities;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class AddAdmin : Form
    {
        private readonly AttendanceDbContext _db;
        private readonly User _user;       
        private readonly bool _isEdit;     

        public AddAdmin(AttendanceDbContext db)
        {
            InitializeComponent();
            _db = db;
            _isEdit = false;

            AddBtn.Click += AddAdminBtn_Click;
            CancelBtn.Click += CancelBtn_Click;
            this.Load += AddAdmin_Load;
        }

        public AddAdmin(AttendanceDbContext db, User user) : this(db)
        {
            _user = user;
            _isEdit = true;
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
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

            string hashedPassword = !string.IsNullOrEmpty(password)? HashPassword(password): null;

            using var transaction = _db.Database.BeginTransaction();
            try
            {
                if (_isEdit)
                {
                    _user.UserName = userName;
                    if (!string.IsNullOrEmpty(password))
                        _user.Password = hashedPassword;

                    _db.Users.Update(_user);
                    _db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("Admin updated successfully!");
                }
                else
                {
                    var existingUser = _db.Users.FirstOrDefault(u => u.UserName == userName);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Username already exists. Please choose another.");
                        return;
                    }

                    var user = new User
                    {
                        UserName = userName,
                        Password = hashedPassword,
                        RoleId = 1
                    };

                    _db.Users.Add(user);
                    _db.SaveChanges();

                    transaction.Commit();
                    MessageBox.Show("Admin added successfully!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error saving Admin: {ex.Message}");
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

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            if (_isEdit && _user != null)
            {
                userNameTxt.Text = _user.UserName;
                AddBtn.Text = "Update";
            }
        }
    }
}
