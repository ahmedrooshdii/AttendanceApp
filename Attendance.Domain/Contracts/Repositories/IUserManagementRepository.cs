namespace Attendance.Domain.Contracts.Repositories
{
    using Attendance.Domain.DTOs;
    using Attendance.Domain.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserManagementRepository
    {
        // Task<IEnumerable<User>> GetAllUsers();

        Task<List<UserDto>> GetAllUsersAsync();
        Task<List<UserDto>> SearchUsersAsync(string searchText);
        Task<User?> GetUserByIdAsync(int userId);
        Task<bool> DeleteUserAsync(int userId);


    }
}
