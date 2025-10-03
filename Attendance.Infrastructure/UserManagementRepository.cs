using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.DTOs;
using Attendance.Infrastructure.Data;

namespace Attendance.Infrastructure.Repositories
{
    public class UserManagementRepository : IUserManagementRepository
    {
        private readonly AttendanceDbContext _db;

        public UserManagementRepository(AttendanceDbContext db)
        {
            _db = db;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            return await _db.Users
                .Include(u => u.Role)
                .Select(u => new UserDto
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    RoleName = u.Role != null ? u.Role.RoleName : ""
                })
                .ToListAsync();
        }

        public async Task<List<UserDto>> SearchUsersAsync(string searchText)
        {
            return await _db.Users
                .Include(u => u.Role)
                .Where(u =>
                    EF.Functions.Like(u.UserId.ToString(), $"%{searchText}%") ||
                    EF.Functions.Like(u.UserName, $"%{searchText}%") ||
                    (u.Role != null && EF.Functions.Like(u.Role.RoleName, $"%{searchText}%"))
                )
                .Select(u => new UserDto
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    RoleName = u.Role != null ? u.Role.RoleName : ""
                })
                .ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _db.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            using var transaction = await _db.Database.BeginTransactionAsync();
            try
            {
                var teacher = await _db.Teachers.FirstOrDefaultAsync(t => t.UserId == userId);
                if (teacher != null)
                {
                    var teacherClasses = _db.TeacherClasses.Where(tc => tc.TeacherId == teacher.TeacherId);
                    _db.TeacherClasses.RemoveRange(teacherClasses);
                    _db.Teachers.Remove(teacher);
                }

                var student = await _db.Students.FirstOrDefaultAsync(s => s.UserId == userId);
                if (student != null)
                {
                    _db.Students.Remove(student);
                }

                var user = await _db.Users.FirstOrDefaultAsync(u => u.UserId == userId);
                if (user != null)
                {
                    _db.Users.Remove(user);
                }

                await _db.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                return false;
            }
        }
    }
}