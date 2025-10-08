using Attendance.Domain.Entities;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Attendance.Presentation.Forms
{
    public partial class UpdateClass : Form
    {
        private readonly AttendanceDbContext db;
        public int clssicd;
        public UpdateClass(AttendanceDbContext _db, int _clssicd)
        {
            InitializeComponent();
            db = _db;
            clssicd = _clssicd;
        }
        private void UpdateClass_Load(object sender, EventArgs e)
        {
            var existingClass = db.Classes.FirstOrDefault(c => c.ClassId == clssicd);
            if (existingClass != null)
            {
                textBox_updateClass.Text = existingClass.ClassName;
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string newClassName = textBox_updateClass.Text.Trim();

            if (string.IsNullOrEmpty(newClassName))
            {
                MessageBox.Show("Please enter a class name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingClass = db.Classes.FirstOrDefault(c => c.ClassId == clssicd);

            if (existingClass != null)
            {
                
                bool classExists = db.Classes
                    .Any(c => c.ClassName.ToLower() == newClassName.ToLower() && c.ClassId != clssicd);

                if (classExists)
                {
                    MessageBox.Show("This class name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           
                existingClass.ClassName = newClassName;
                db.Classes.Update(existingClass);
                db.SaveChanges();

                MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}

