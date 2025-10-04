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
          
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var existingClass = db.Classes.FirstOrDefault(c => c.ClassId == clssicd);
           

            if (existingClass != null)
            {
              
                existingClass.ClassName = textBox_updateClass.Text;

                db.Classes.Update(existingClass);
                db.SaveChanges();

                MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
