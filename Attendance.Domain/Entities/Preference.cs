using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table ("Preference")]
    public class Preference
    {
        [Key]
        public int PreferenceId { get; set; }
        public string Language { get; set; } = "English";
        public string DateFormat { get; set; }= "MM/dd/yyyy";
        public string Theme { get; set; } = "Light";
    }
}
