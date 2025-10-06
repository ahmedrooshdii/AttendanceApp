using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Service
{
    public class AuthService : IAuthService
    {
        private readonly IServiceProvider _serviceProvider;

        public AuthService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            // var c = HashPassword(password);
            using var scope = _serviceProvider.CreateScope();
            var _repo = scope.ServiceProvider.GetRequiredService<IUserRepository>();

            var user = await _repo.GetByUsernameAsync(username);
            if (user == null) return new User();

            var checkuser= VerifyPassword(password, user.Password);
            if(checkuser)
            {
                return user;
            }
            return new User();
        }

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            return HashPassword(password) == storedHash;
        }
    }
}
