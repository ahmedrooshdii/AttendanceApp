using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.RepositoryImplementation
{
    public class StudentRepository : IStudentrepository
    {
        private readonly AttendanceDbContext _context;
        public StudentRepository(AttendanceDbContext context)
        {
            _context = context;
        }
        public async Task<Student?> GetStudentByUserIdAsync(int userid)
        {
            return await Task.FromResult(_context.Students.FirstOrDefault(s => s.UserId == userid));
        }
        public async Task<List<Student>> GetStudentByNameAsync(string studentName)
        {
            return await _context.Students.Where(s=>s.StudentName == studentName).ToListAsync();
        }
    }
}
