using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;

namespace Attendance.Presentation.Forms
{
    public partial class StudentDashboard : Form
    {
        private readonly User _user;

        public StudentDashboard(User user)
        {
            InitializeComponent();
            _user = user;
            this.FormClosed += StudentDashboard_FormClosed;
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
    }
}
