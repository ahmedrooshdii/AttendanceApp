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

            // علشان نربط الأحداث بالزرار
            this.Load += AssignTeacher_Load;
            btnSave.Click += BtnSave_Click;
            BtnCansel.Click += BtnCansel_Click;

            // تفعيل الـ Scroll في البانيل
            Panal_ChkBox.AutoScroll = true;
        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {
            var teachers = db.Teachers.ToList();

            int y = 10; // المسافة الرأسية بين كل CheckBox
            foreach (var teacher in teachers)
            {
                CheckBox chk = new CheckBox();
                chk.Text = teacher.TeacherName;
                chk.Tag = teacher.TeacherId; // نخزن الـ Id هنا
                chk.Location = new Point(10, y);
                chk.AutoSize = true;

                Panal_ChkBox.Controls.Add(chk);
                y += 30;
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in Panal_ChkBox.Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                {
                    int teacherId = (int)chk.Tag;
                    var teacherClass = new TeacherClass
                    {
                        ClassId = clsassId,
                        TeacherId = teacherId
                    };

                    db.TeacherClasses.Add(teacherClass);
                }
            }

            db.SaveChanges();
            MessageBox.Show("Teachers assigned successfully!");
            this.Close();
        }


        private void BtnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
