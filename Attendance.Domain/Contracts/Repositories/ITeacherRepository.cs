using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Repositories
{
    public interface ITeacherRepository
    {
        Task<Teacher?> GetTeacherWithClasses(int teacherId);
        Task<Teacher?> GetTeacherByUserId(int? userId);
    }
}
