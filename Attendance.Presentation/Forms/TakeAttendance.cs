using Attendance.Domain.Entities;
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
    public partial class TakeAttendance : Form
    {
        private int _userId;
        private readonly ITeacherService _teacherService;
        private readonly IClassServices _classService;

        public TakeAttendance(int userId, ITeacherService teacherService, IClassServices classService)
        {
            InitializeComponent();
            dataGridViewMarkAttendance.Columns["ID"].Visible = false;
            dataGridViewMarkAttendance.Columns["Status2"].Visible = false;
            _userId = userId;
            _teacherService = teacherService;
            _classService = classService; 
        }

        private async void TakeAttendance_Load(object sender, EventArgs e)
        {
            if (_userId != 0)
            {
                var teacher = await _teacherService.GetTeacherByUserId(_userId);
                var classData = await _teacherService.GetClassesForTeacher(teacher.TeacherId);
                if (classData != null)
                {
                    classData.Insert(0, new Class { ClassId = 0, ClassName = "-- Select Class --" });
                    // Populate the form fields with the attendance data
                    comboBoxClass.DataSource = classData;
                    comboBoxClass.DisplayMember = "ClassName";
                    comboBoxClass.ValueMember = "ClassId";
                    comboBoxClass.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No classes found for the teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedValue is int selectedClassId && selectedClassId > 0)
            {
                var students = await _classService.GetStudentsByClassIdAsync(selectedClassId);

                if (students != null && students.Any())
                {
                    // Clear old rows
                    dataGridViewMarkAttendance.Rows.Clear();

                    // Add each student to the grid
                    foreach (var student in students)
                    {
                        dataGridViewMarkAttendance.Rows.Add(
                            student.StudentId,
                            student.StudentName,
                            false,
                            "Absent" // default attendance status
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No students found for this class.");
                }
            }
            else
            {
                // Clear the grid if no valid class is selected
                dataGridViewMarkAttendance.Rows.Clear();
            }
        }
    }
}
