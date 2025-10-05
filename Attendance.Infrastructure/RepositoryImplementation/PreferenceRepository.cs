using Attendance.Domain.Contracts.Repositories;
using Attendance.Infrastructure.Data;
using Attendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Infrastructure
{
    public class PreferenceRepository : IPreferenceRepository
    {
        private readonly AttendanceDbContext _context;
        public PreferenceRepository(AttendanceDbContext context) {
            _context = context; 
        }

        public async Task<Preference?> GetPreference()
        {
            // Get the first row from Preferences table
            return await _context.Preferences.FirstOrDefaultAsync();
        }

        public async Task<Preference?> UpdatePreference(Preference preference)
        {
            // Update the first row only
            var existing = await _context.Preferences.FirstOrDefaultAsync();
            if (existing == null) return null;
            existing.Language = preference.Language;
            existing.DateFormat = preference.DateFormat;
            existing.Theme = preference.Theme;
            await _context.SaveChangesAsync();
            return existing;
        }
    }
}
