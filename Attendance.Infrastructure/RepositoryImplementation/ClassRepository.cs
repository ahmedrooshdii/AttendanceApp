using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.RepositoryImplementation
{
    public class ClassRepository : IClassRepository
    {
        private readonly AttendanceDbContext _context;
        public ClassRepository(AttendanceDbContext context)
        {
            _context = context;
        }
        public async Task<List<Class>> GetAllClassesAsync(System.Linq.Expressions.Expression<Func<Class, bool>>? predicate = null)
        {
            if(predicate == null)
            {
                // Return all classes
                return await _context.Classes.ToListAsync();
            }
            else
            {
                // Return filtered classes based on the predicate
                return await _context.Classes.Where(predicate).ToListAsync();
            }
        }
        public async Task<List<Student>> GetStudentsByClassIdAsync(int classId)
        {
            return await _context.Students
                .Where(s => s.ClassId == classId)
                .ToListAsync();
        }
    }
}
