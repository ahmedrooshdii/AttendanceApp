using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Service
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task SaveAttendanceAsync(int classId, List<Attendence> records)
        {
            foreach (var record in records)
            {
                var existing = await _attendanceRepository.GetAttendanceAsync(record.StudentId, record.Date);

                if (existing != null)
                {
                    // Update existing
                    existing.Status = record.Status;
                    existing.Notes = record.Notes;

                    await _attendanceRepository.UpdateAttendanceAsync(existing);
                }
                else
                {
                    // Insert new
                    var newAttendance = new Attendence
                    {
                        StudentId = record.StudentId,
                        Date = record.Date,
                        Status = record.Status,
                        Notes = record.Notes
                    };

                    await _attendanceRepository.AddAttendanceAsync(newAttendance);
                }
            }

            await _attendanceRepository.SaveChangesAsync();
        }
        public async Task<List<Attendence>> GetStudentAttendancesByDateRangeAsync(int userId,DateTime from, DateTime to)
        {
            return await _attendanceRepository.GetByDateRangeAsync(userId, from, to);
        }
    }
}
