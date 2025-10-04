using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.RepositoryImplementation
{
    public class ClassRepository : IClassRepository
    {
        private readonly IDbContextFactory<AttendanceDbContext> _contextFactory;
        public ClassRepository(IDbContextFactory<AttendanceDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<List<Class>> GetAllClassesAsync(System.Linq.Expressions.Expression<Func<Class, bool>>? predicate = null)
        {
            using var _context = _contextFactory.CreateDbContext();
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
            using var _context = _contextFactory.CreateDbContext();
            return await _context.Students
                .Include(s=>s.Atendances)
                .Where(s => s.ClassId == classId)
                .ToListAsync();
        }
    }
}
