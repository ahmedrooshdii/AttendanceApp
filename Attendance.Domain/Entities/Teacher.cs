using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table("Teacher")]
    public class Teacher
    {
        [ Key]
        public int TeacherId { get; set; } 
        public string TeacherName { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; } 
        public ICollection<TeacherClass>? TeacherClasses { get; set; }  = new HashSet<TeacherClass>();
    }
}
