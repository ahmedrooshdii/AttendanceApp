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

namespace Attendance.Presentation.Forms
{
    public partial class ViewAttendance : Form
    {
        private readonly IUserService userServices;
        private readonly IClassServices classServices;
        private readonly ITeacherService teacherService;
        private readonly int userId;

        public ViewAttendance(int _userId, IClassServices _classServices, IUserService _userServices, ITeacherService _teacherService)
        {
            InitializeComponent();
            classServices = _classServices;
            userId = _userId;
            userServices = _userServices;
            teacherService = _teacherService;
        }

        private async void ViewAttendance_Load(object sender, EventArgs e)
        {
            List<Class> allClasses = null; // Initialize the variable
            //check if userId is valid
            if (userId == 0)
            {
                MessageBox.Show("Invalid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            var user = await userServices.GetByIdAsync(userId);
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
            LoadStudentAutoComplete(classId);
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
    }
}
