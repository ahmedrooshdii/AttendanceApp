using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.Domain.Entities;
using Attendance.Infrastructure.Data;   

namespace Attendance.Presentation.Forms
{

    public partial class Add : Form
    {
        private readonly AttendanceDbContext db;
        public Add(AttendanceDbContext _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void Add_classBtn_Click(object sender, EventArgs e)
        {
            string className = textBox_add.Text.Trim();

            if (!string.IsNullOrEmpty(className))
            {
                bool classExists = db.Classes
                    .Any(c => c.ClassName.ToLower() == className.ToLower());

                if (classExists)
                {
                    MessageBox.Show("This class already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var newClass = new Class
                    {
                        ClassName = className
                    };

                    db.Classes.Add(newClass);
                    db.SaveChanges();

                    MessageBox.Show("Class added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a class name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
