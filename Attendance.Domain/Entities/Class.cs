using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();   
        public ICollection<TeacherClass>? TeacherClasses { get; set; } = new HashSet<TeacherClass>();
        
    }
}
