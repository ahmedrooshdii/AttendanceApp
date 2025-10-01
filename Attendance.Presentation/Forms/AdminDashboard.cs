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
    public partial class AdminDashboard : Form
    {
        private readonly User _user;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            _user = user;
            this.FormClosed += AdminDashboard_FormClosed;
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

    }
}
