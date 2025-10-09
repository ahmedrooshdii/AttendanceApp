using Attendance.Domain.Entities;
using Attendance.Infrastructure.RepositoryImplementation;
using Guna.UI2.WinForms.Suite;
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
        private readonly int _userId;
        private readonly IServiceProvider _serviceProvider;
        private readonly ITeacherService _teacherService;
        private readonly IClassServices _classService;
        private readonly IAttendanceService _attendanceService;

        public TakeAttendance(int userId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            dataGridViewMarkAttendance.Columns["ID"].Visible = false;
            _userId = userId;
            _serviceProvider = serviceProvider;
            _teacherService = _serviceProvider.GetService<ITeacherService>();
            _classService = _serviceProvider.GetService<IClassServices>();
            _attendanceService = _serviceProvider.GetService<IAttendanceService>();
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
            await LoadStudentsForAttendance();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedValue is not int selectedClassId || selectedClassId <= 0)
            {
                MessageBox.Show("Please select a class before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDate = dateTimePicker1.Value.Date;
            var attendanceList = new List<Attendence>();

            foreach (DataGridViewRow row in dataGridViewMarkAttendance.Rows)
            {
                if (row.IsNewRow) continue;

                int studentId = Convert.ToInt32(row.Cells["ID"].Value);
                string studentName = row.Cells["StudentName"].Value?.ToString() ?? "";
                string status = row.Cells["Status"].Value?.ToString();
                string note = row.Cells["Note"].Value?.ToString() ?? "";

                // Force teacher to select a status
                if (string.IsNullOrEmpty(status) || status == "--Select--")
                {
                    MessageBox.Show($"Please select a status for student: {studentName}",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                attendanceList.Add(new Attendence
                {
                    StudentId = studentId,
                    Date = selectedDate,
                    Status = status,
                    Notes = note
                });
            }

            // Save to DB via service
            try
            {
                await _attendanceService.SaveAttendanceAsync(selectedClassId, attendanceList);

                MessageBox.Show("Attendance saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            await LoadStudentsForAttendance();
        }
        private async Task LoadStudentsForAttendance()
        {
            if (comboBoxClass.SelectedValue is int selectedClassId && selectedClassId > 0)
            {
                var selectedDate = dateTimePicker1.Value.Date;

                var students = await _classService.GetStudentsByClassIdAsync(selectedClassId);

                if (students != null && students.Any())
                {
                    dataGridViewMarkAttendance.Rows.Clear();

                    foreach (var student in students)
                    {
                        // check if attendance already exists for this date
                        var todayAttendance = student.Atendances?
                            .FirstOrDefault(a => a.Date.Date == selectedDate);

                        dataGridViewMarkAttendance.Rows.Add(
                            student.StudentId,
                            student.StudentName,
                            todayAttendance?.Status ?? "--Select--",
                            todayAttendance?.Notes ?? string.Empty
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
                dataGridViewMarkAttendance.Rows.Clear();
            }
        }
    }
}
