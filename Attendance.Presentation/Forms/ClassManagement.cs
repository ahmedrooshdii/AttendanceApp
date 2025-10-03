using System;
using System.Windows.Forms;
using Attendance.Infrastructure.Data;

namespace Attendance.Presentation.Forms
{
    public partial class ClassManagement : Form
    {

        AttendanceDbContext db;
        public ClassManagement(AttendanceDbContext _db)
        {
            InitializeComponent();
            db = _db;


        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayClasss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Classs = db.Classes.Select(e => new { Id = e.ClassId, Class_Name = e.ClassName }).ToList();

            DisplayClasss.DataSource = Classs;

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add_update add = new Add_update();
            Hide();
            add.Show();
            this.Show();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Add_update Update = new Add_update();
            this.Hide();
            Update.ShowDialog();
            this.Show();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("is not implemented yet");

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("is not implemented yet");
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            var Classs = db.Classes.Select(e => new { Id = e.ClassId, Class_Name = e.ClassName }).ToList();
            DisplayClasss.DataSource = Classs;
                

        }
    }
}