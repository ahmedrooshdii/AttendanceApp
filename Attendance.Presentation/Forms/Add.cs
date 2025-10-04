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
          
            if (textBox_add.Text!= string.Empty)
            {
                var newClass = new Class();

                newClass.ClassName = textBox_add.Text;  
                db.Classes.Add(newClass);
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
               
                this.Close();
               

            }
            else
            {
                MessageBox.Show("Please enter a class name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

        }
    }
}
