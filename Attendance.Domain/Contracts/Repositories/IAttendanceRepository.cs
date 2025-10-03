using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Repositories
{
    public interface IAttendanceRepository
    {
        Task<Attendence?> GetAttendanceAsync(int? studentId, DateTime date);
        Task AddAttendanceAsync(Attendence attendance);
        Task UpdateAttendanceAsync(Attendence attendance);
        Task SaveChangesAsync();
    }
}
