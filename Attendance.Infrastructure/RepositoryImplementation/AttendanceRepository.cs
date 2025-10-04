using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure.RepositoryImplementation
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AttendanceDbContext _dbContext;

        public AttendanceRepository(AttendanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Attendence?> GetAttendanceAsync(int? studentId, DateTime date)
        {
            return await _dbContext.Attendances
                .FirstOrDefaultAsync(a => a.StudentId == studentId && a.Date == date);
        }

        public async Task AddAttendanceAsync(Attendence attendance)
        {
            await _dbContext.Attendances.AddAsync(attendance);
        }

        public Task UpdateAttendanceAsync(Attendence attendance)
        {
            _dbContext.Attendances.Update(attendance);
            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Attendence>> GetByDateRangeAsync(int studentId, DateTime from, DateTime to)
        {
            return _dbContext.Attendances.Where(a=>a.StudentId == studentId && a.Date >= from && a.Date <= to).ToList();
        }
    }
}
