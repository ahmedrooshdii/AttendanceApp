using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.Infrastructure.Data;   

using Attendance.Domain.Entities;
namespace Attendance.Presentation.Forms
{
    public partial class AssignTeacher : Form
    {
        private readonly AttendanceDbContext db;
        int clsassId;
        public AssignTeacher(AttendanceDbContext context, int classId)
        {
            InitializeComponent();
            db = context;
            this.clsassId = classId;


            this.Load += AssignTeacher_Load;
            btnSave.Click += BtnSave_Click;
            BtnCansel.Click += BtnCansel_Click;


            Panal_ChkBox.AutoScroll = true;
        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {
            var teachers = db.Teachers.ToList();

           
            var assignedTeachers = db.TeacherClasses
                                     .Where(tc => tc.ClassId == clsassId)
                                     .Select(tc => tc.TeacherId)
                                     .ToList();

            int y = 10; 
            foreach (var teacher in teachers)
            {
                CheckBox chk = new CheckBox();
                chk.Text = teacher.TeacherName;
                chk.Tag = teacher.TeacherId; 
                chk.Location = new Point(10, y);
                chk.AutoSize = true;

             
                if (assignedTeachers.Contains(teacher.TeacherId))
                {
                    chk.Checked = true;
                }

                Panal_ChkBox.Controls.Add(chk);
                y += 30;
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            var existingAssignments = db.TeacherClasses
                                        .Where(tc => tc.ClassId == clsassId)
                                        .ToList();

            foreach (CheckBox chk in Panal_ChkBox.Controls.OfType<CheckBox>())
            {
                int teacherId = (int)chk.Tag;
                var existing = existingAssignments.FirstOrDefault(tc => tc.TeacherId == teacherId);

                if (chk.Checked)
                {
                    
                    if (existing == null)
                    {
                        db.TeacherClasses.Add(new TeacherClass
                        {
                            ClassId = clsassId,
                            TeacherId = teacherId
                        });
                    }
                }
                else
                {
                    if (existing != null)
                    {
                        db.TeacherClasses.Remove(existing);
                    }
                }
            }

            db.SaveChanges();
            MessageBox.Show("Teachers updated successfully!");
            this.Close();
        }

        private void BtnCansel_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
