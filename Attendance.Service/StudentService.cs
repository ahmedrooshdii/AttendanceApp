using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;
using System.Formats.Asn1;

namespace Attendance.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentrepository studentrepository;
        public StudentService(IStudentrepository _studentrepository)
        {
            studentrepository = _studentrepository;
        }
        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            return await studentrepository.GetStudentByUserIdAsync(userId);
        }
        public async Task<List<Student>> GetStudentByNameAsync(string studentName)
        {
            return await studentrepository.GetStudentByNameAsync(studentName);
        }
    }
}
