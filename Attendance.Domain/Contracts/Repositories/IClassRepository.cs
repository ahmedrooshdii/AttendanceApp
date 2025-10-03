using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Repositories
{
    public interface IClassRepository
    {
        Task<List<Class>> GetAllClassesAsync(Expression<Func<Class, bool>>? predicate = null);
        Task<List<Student>> GetStudentsByClassIdAsync(int classId);

    }
}
