using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.DTOs;
using Attendance.Domain.Entities;

namespace Attendance.Service
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserManagementRepository _repo;

        public UserManagementService(IUserManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            return await _repo.GetAllUsersAsync();
        }

        public async Task<List<UserDto>> SearchUsersAsync(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return await GetAllUsersAsync();

            return await _repo.SearchUsersAsync(searchText);
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _repo.GetUserByIdAsync(userId);
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            return await _repo.DeleteUserAsync(userId);
        }
    }
}