using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Repositories
{
    public interface IStudentrepository
    {
        Task<Student?> GetStudentByUserIdAsync(int userid);
        Task<List<Student>> GetStudentByNameAsync(string studentName);
    }
}
