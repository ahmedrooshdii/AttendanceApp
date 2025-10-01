using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class Class
    {
        [Key]
        public int Class_Id { get; set; }
        public string Class_Name { get; set; }
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();   
        public ICollection<TeacherClass>? TeacherClasses { get; set; } = new HashSet<TeacherClass>();
        
    }
}
