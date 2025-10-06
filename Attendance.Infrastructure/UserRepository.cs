using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly AttendanceDbContext _context;
        public UserRepository(AttendanceDbContext context) {
            _context = context; 
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }

        public async Task<User?> GetByIdAsync(int userId) => await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == userId);
    }
}
