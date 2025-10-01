using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class Teacher
    {
        [ Key]
        public int Tch_id { get; set; } 
        public string Tch_Name { get; set; }

        [ForeignKey("User")]
        public int? User_id { get; set; }
        public User? User { get; set; } 
        public ICollection<TeacherClass>? TeacherClasses { get; set; }  = new HashSet<TeacherClass>();
    }
}
