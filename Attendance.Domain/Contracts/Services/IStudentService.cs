using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Services
{
    public interface IStudentService
    {
        Task<Student?> GetStudentByUserIdAsync(int userId);
        Task<List<Student>> GetStudentByNameAsync(string studentName);

    }
}
