using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Services
{
    public interface IAttendanceService
    {
        Task SaveAttendanceAsync(int classId, List<Attendence> records);
        Task<List<Attendence>> GetStudentAttendancesByDateRangeAsync(int userId, DateTime from, DateTime to);
    }
}
