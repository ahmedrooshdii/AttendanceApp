using Attendance.Domain.Entities;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class BaseDashboardForm : Form
    {
        protected User CurrentUser { get; private set; }

        public void InitializeUser(User user)
        {
            CurrentUser = user;
            OnUserInitialized(user);
        }
        protected internal virtual void OnUserInitialized(User user)
        {
            throw new NotImplementedException("OnUserInitialized method must be implemented in derived classes.");
        }
    }
}
