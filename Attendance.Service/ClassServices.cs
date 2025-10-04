using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Service
{
    public class ClassServices : IClassServices
    {
        private readonly IClassRepository _classRepository;

        public ClassServices(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<List<Domain.Entities.Class>> GetAllClassesAsync(System.Linq.Expressions.Expression<Func<Domain.Entities.Class, bool>>? predicate = null)
        {
            return await _classRepository.GetAllClassesAsync(predicate);
        }
        public async Task<List<Student>> GetStudentsByClassIdAsync(int classId)
        {
            return await _classRepository.GetStudentsByClassIdAsync(classId);
        }
    }
}
