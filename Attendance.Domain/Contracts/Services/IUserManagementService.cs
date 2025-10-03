using Attendance.Domain.DTOs;
using Attendance.Domain.Entities;

namespace Attendance.Domain.Contracts.Services
{
    public interface IUserManagementService
    {
        Task<List<UserDto>> GetAllUsersAsync();
        Task<List<UserDto>> SearchUsersAsync(string searchText);
        Task<User?> GetUserByIdAsync(int userId);
        Task<bool> DeleteUserAsync(int userId);
    }
}