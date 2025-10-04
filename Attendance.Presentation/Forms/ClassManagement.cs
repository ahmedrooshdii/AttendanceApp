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
                UpdateClass up = new UpdateClass(db, Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value));
                up.Show();
                using (UpdateClass frm = new UpdateClass(db, Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value)))
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
            //if (DisplayClasss.CurrentRow != null)
            //{
            if (DisplayClasss.CurrentRow != null && DisplayClasss.CurrentRow.Cells["Id"].Value != null)
            {
                //int id = (int)DisplayClasss.CurrentRow.Cells["Id"].Value;
                int id = Convert.ToInt32(DisplayClasss.CurrentRow.Cells["Id"].Value);

                var classObj = db.Classes.FirstOrDefault(e=>e.ClassId==id);

                if (classObj != null)
                {
                   
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
                MessageBox.Show("Please select a row before deleting.");
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
    }
}
