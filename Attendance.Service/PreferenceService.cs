using Attendance.Domain.Contracts.Repositories;
using Attendance.Domain.Contracts.Services;
using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Service
{
    public class PreferenceService  
    {
        private IPreferenceRepository _repo;
        public PreferenceService(IPreferenceRepository repo)
        {
            _repo = repo;
        }
        public async Task<Preference?> GetPreference()
        {
            var preftence = await _repo.GetPreference();
            if (preftence != null)
            {
                return preftence;
            }

            return new Preference { Language = "Arabic" , DateFormat="dd/MM/yyyy", Theme="Light" };
        }

        public async Task<Preference?> UpdatePreference(Preference preference)
        {
            var preftence = await _repo.UpdatePreference(preference);
            if (preftence != null)
            {
                return preftence;
            }

            return new Preference { Language = "Arabic", DateFormat = "dd/MM/yyyy", Theme = "Light" };
        }

    }
}
