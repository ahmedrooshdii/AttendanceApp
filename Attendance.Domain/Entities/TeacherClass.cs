using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table("TeacherClass")]
    public class TeacherClass
    {
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int? ClassId { get; set; }

        public Class? Class { get; set; }       

    }
}
