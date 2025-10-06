using Attendance.Domain.Contracts.Services;
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
using System.IO;
using ClosedXML.Excel;

namespace Attendance.Presentation.Forms
{
    public partial class ViewAttendance : Form
    {
        private User user;
        private readonly int userId;
        private readonly IUserService userServices;
        private readonly IClassServices classServices;
        private readonly ITeacherService teacherService;
        private readonly IStudentService studentService;
        private readonly IAttendanceService attendanceService;
        public ViewAttendance(int _userId, IClassServices _classServices, IUserService _userServices, ITeacherService _teacherService, IStudentService _studentService, IAttendanceService _attendanceService)
        {
            InitializeComponent();
            classServices = _classServices;
            userId = _userId;
            userServices = _userServices;
            teacherService = _teacherService;
            studentService = _studentService;
            attendanceService = _attendanceService;
        }

        public async void ViewAttendance_Load(object sender, EventArgs e)
        {
            List<Class> allClasses = null; // Initialize the variable
            //check if userId is valid
            if (userId == 0)
            {
                MessageBox.Show("Invalid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            user = await userServices.GetByIdAsync(userId);
            if (user?.Role?.RoleName == "Admin")
            {
                //load all classes
                allClasses = await classServices.GetAllClassesAsync();

            }
            else if (user?.Role?.RoleName == "Teacher")
            {
                //load only classes assigned to the teacher
                var teacher = await teacherService.GetTeacherByUserId(userId);
                allClasses = await teacherService.GetClassesForTeacher(teacher.TeacherId);
            }
            else
            {
                // make it invisible and disabled
                cmbClass.Enabled = false;
                cmbClass.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                txtStudent.Visible = false;
                btnGenerate.PerformClick();
            }
            if (allClasses != null)
            {
                cmbClass.DataSource = allClasses;
                cmbClass.DisplayMember = "ClassName";
                cmbClass.ValueMember = "ClassId";
                cmbClass.SelectedIndex = 0;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (user?.Role?.RoleName == "Student")
            {
                return; // do nothing if the user is not Admin or Teacher
            }
            if (cmbClass.SelectedValue == null) return;

            int classId;
            if (cmbClass.SelectedValue is int id)
            {
                classId = id;
            }
            else if (cmbClass.SelectedValue is Class cls)
            {
                classId = cls.ClassId;
            }
            else
            {
                return; // Unexpected type, do nothing
            }
            txtStudent.Text = "";
            LoadStudentAutoComplete(classId);
            PopulateTable(classId);
        }
        private async void LoadStudentAutoComplete(int classId)
        {
            var students = await classServices.GetStudentsByClassIdAsync(classId);
            if (students != null)
            {
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(students.Select(s => s.StudentName).ToArray());
                txtStudent.AutoCompleteCustomSource = autoCompleteData;
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            Student student;
            if (user?.Role?.RoleName == "Admin" || user?.Role?.RoleName == "Teacher")
            {
                // if class is selected and student is selected then fetch there attendance from db
                var students = await studentService.GetStudentByNameAsync(txtStudent.Text);
                if (students == null || students.Count() == 0)
                {
                    return;
                }
                student = students[0];
            }
            else
            {
                student = await studentService.GetStudentByUserIdAsync(userId);
                if (student == null)
                {
                    MessageBox.Show("Invalid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            var attendance = attendanceService.GetStudentAttendancesByDateRangeAsync(student.StudentId, dtFrom.Value.Date, dtTo.Value.Date);
            if (attendance.Result.Count() == 0)
            {
                MessageBox.Show("no Result choose another date range.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvReport.Rows.Clear();
            foreach (var attend in attendance.Result)
            {
                dgvReport.Rows.Add(
                    attend.Date.ToString("dddd/dd/MMM/yyyy"),
                    attend.Student?.StudentName,
                    attend.Status,
                    attend?.Notes ?? ""
                    );
            }
        }
        private async void PopulateTable(int classId)
        {
            var students = await classServices.GetStudentsByClassIdAsync(classId);
            if (students != null)
            {
                dgvReport.Rows.Clear();
                foreach (var student in students)
                {
                    var attendance = await attendanceService.GetStudentAttendancesByDateRangeAsync(student.StudentId, dtFrom.Value.Date, dtTo.Value.Date);
                    foreach (var attend in attendance)
                    {
                        dgvReport.Rows.Add(
                            attend.Date.ToString("dddd/dd/MMM/yyyy"),
                            student.StudentName,
                            attend.Status,
                            attend?.Notes ?? ""
                            );
                    }
                }
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            this.btnGenerate.PerformClick();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            this.btnGenerate.PerformClick();
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            this.btnGenerate.PerformClick();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No records to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fileName = "Attendance.xlsx";
            if (cmbClass.SelectedItem is Class selectedClass && !string.IsNullOrWhiteSpace(selectedClass.ClassName))
            {
                fileName = $"{selectedClass.ClassName}.xlsx";
            }
            using (var sfd = new SaveFileDialog { Filter = "Excel Files|*.xlsx", FileName = fileName })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var wb = new XLWorkbook();
                    var ws = wb.Worksheets.Add("Attendance");
                    // Add headers
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                        ws.Cell(1, i + 1).Value = dgvReport.Columns[i].HeaderText ?? string.Empty;
                    // Add rows
                    for (int i = 0; i < dgvReport.Rows.Count; i++)
                        for (int j = 0; j < dgvReport.Columns.Count; j++)
                            ws.Cell(i + 2, j + 1).Value = dgvReport.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                    wb.SaveAs(sfd.FileName);
                    MessageBox.Show("Exported to Excel successfully.");
                }
            }
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            btnExport_Click(sender, e);
        }
    }
}
