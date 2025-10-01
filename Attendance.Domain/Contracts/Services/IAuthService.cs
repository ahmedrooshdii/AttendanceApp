using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Contracts.Services
{
    public interface IAuthService
    {
        Task<User> LoginAsync(string username, string password);
    }
}
