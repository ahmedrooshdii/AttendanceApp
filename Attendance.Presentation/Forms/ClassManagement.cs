using System;
using System.Linq;
using System.Windows.Forms;
using Attendance.Infrastructure.Data;


namespace Attendance.Presentation.Forms
{
    public partial class ClassManagement : Form
    {


        private readonly AttendanceDbContext db;



        public ClassManagement()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<AttendanceDbContext>()
               .UseSqlServer("Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True;TrustServerCertificate=True;")
               .Options;

            db = new AttendanceDbContext(options);
            LoadClasses();
        }
        public ClassManagement(AttendanceDbContext _db)
        {
            InitializeComponent();
            db = _db;
            LoadClasses();
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }


        private void LoadClasses()
        {
            var classes = db.Classes
                .Select(e => new { Id = e.ClassId, Class_Name = e.ClassName })
                .ToList();

            DisplayClasss.DataSource = classes;

            DisplayClasss.EnableHeadersVisualStyles = false;
            DisplayClasss.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            DisplayClasss.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;

            DisplayClasss.Columns["Id"].HeaderText = "Class ID";
            DisplayClasss.Columns["Class_Name"].HeaderText = "Class Name";
            DisplayClasss.ColumnHeadersHeight = 40;
        }



        private void Add_btn_Click(object sender, EventArgs e)
        {
            Add ad = new Add(db);

            // adminDashboard.Hide();  
            // ad.Show();
            //adminDashboard.Show(.);  


            using (Add frm = new Add(db))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadClasses();
                }
            }


        }


        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (DisplayClasss.CurrentRow != null && DisplayClasss.CurrentRow.Cells["Id"].Value != null)
            {
                int classId = Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value);

                using (UpdateClass frm = new UpdateClass(db, classId))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadClasses();
                    }
                }
            }
        }


        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (DisplayClasss.CurrentRow != null && DisplayClasss.CurrentRow.Cells["Id"].Value != null)
            {
                int id = Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value);
                var classObj = db.Classes.FirstOrDefault(c => c.ClassId == id);

                if (classObj != null)
                {
                    // check if class has teachers
                    bool hasTeachers = db.TeacherClasses.Any(t => t.ClassId == id);

                    if (hasTeachers)
                    {
                        MessageBox.Show("This class is assigned to a teacher and cannot be deleted.",
                                        "Delete Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    // check if class has students
                    bool hasStudents = db.Students.Any(s => s.ClassId == id);

                    if (hasStudents)
                    {
                        MessageBox.Show("This class has students assigned and cannot be deleted.",
                                        "Delete Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    // confirm delete
                    var result = MessageBox.Show("Are you sure you want to delete this class?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        db.Classes.Remove(classObj);
                        db.SaveChanges();
                        LoadClasses();
                        MessageBox.Show("Class deleted successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row before deleting.",
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void Search_btn_Click(object sender, EventArgs e)
        {
            string keyword = seahrch_tbx.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a class name to search.");
                return;
            }


            var result = db.Classes
                           .Where(c => c.ClassName.Contains(keyword))
                           .Select(c => new { Id = c.ClassId, Class_Name = c.ClassName })
                           .ToList();

            if (result.Count > 0)
            {
                DisplayClasss.DataSource = result;
            }
            else
            {
                MessageBox.Show("No classes found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayClasss.DataSource = null;
                LoadClasses();
            }
        }

        private void DisplayClasss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Assign_teacherBtn_Click(object sender, EventArgs e)
        {
            if (DisplayClasss.CurrentRow != null && DisplayClasss.CurrentRow.Cells["Id"].Value != null)
            {
                int classId = Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value);

                AssignTeacher assignTeacher = new AssignTeacher(db, classId);
                assignTeacher.Show();
            }
            else
            {
                MessageBox.Show("Please select a class first.");
            }
        }


    }
}
