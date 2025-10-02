using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class EditUser : Form
    {
        private readonly int _userId;
        private string connectionString = "Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True;TrustServerCertificate=True;";

        public EditUser(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Load += EditUser_Load;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string roleQuery = "SELECT RoleID, RoleName FROM Role";
                SqlDataAdapter da = new SqlDataAdapter(roleQuery, con);
                DataTable dtRoles = new DataTable();
                da.Fill(dtRoles);
                RoleComb.DataSource = dtRoles;
                RoleComb.DisplayMember = "RoleName";
                RoleComb.ValueMember = "RoleID";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT UserName, RoleID FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", _userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userNameTxt.Text = reader["UserName"].ToString();
                    RoleComb.SelectedValue = Convert.ToInt32(reader["RoleID"]);
                }
                con.Close();
            }

            UserPassTxt.UseSystemPasswordChar = true; 
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text.Trim();
            string password = UserPassTxt.Text.Trim();
            int roleId = Convert.ToInt32(RoleComb.SelectedValue);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("enter user name");
                return;
            }

            string query;
            if (!string.IsNullOrEmpty(password))
            {
                string hashedPassword = HashPassword(password);
                query = "UPDATE Users SET UserName=@UserName, Password=@Password, RoleID=@RoleID WHERE UserID=@UserID";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@RoleID", roleId);
                    cmd.Parameters.AddWithValue("@UserID", _userId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                query = "UPDATE Users SET UserName=@UserName, RoleID=@RoleID WHERE UserID=@UserID";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@RoleID", roleId);
                    cmd.Parameters.AddWithValue("@UserID", _userId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("updated");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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
