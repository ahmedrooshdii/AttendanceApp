using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.RepositoryImplementation
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AttendanceDbContext _context;

        public TeacherRepository(AttendanceDbContext context)
        {
            _context = context;
        }

        public async Task<Teacher?> GetTeacherWithClasses(int teacherId)
        {
            return await _context.Teachers
                .Include(t => t.TeacherClasses)
                    .ThenInclude(tc => tc.Class)
                .FirstOrDefaultAsync(t => t.TeacherId == teacherId);
        }
        
        public async Task<Teacher?> GetTeacherByUserId(int? userId)
        {
            return await _context.Teachers.FirstOrDefaultAsync(t => t.UserId == userId);
        }
    }
}
