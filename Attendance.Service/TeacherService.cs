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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<List<Class>> GetClassesForTeacher(int teacherId)
        {
            var teacher = await _teacherRepository.GetTeacherWithClasses(teacherId);

            if (teacher == null)
                return new List<Class>();

            return teacher.TeacherClasses
                .Where(tc => tc.Class != null)
                .Select(tc => tc.Class!)
                .ToList();
        }
        public async Task<Teacher?> GetTeacherByUserId(int? userId)
        {
            return await _teacherRepository.GetTeacherByUserId(userId);
        }
    }
}
