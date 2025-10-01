using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class Student
    {
        [Key]
        public int St_id { get; set; }   
        public string St_Name { get; set; }

        [ForeignKey("User")]
        public int? User_id { get; set; }
        public User? User { get; set; }
        [ForeignKey("Class")]
        public int? Class_Id { get; set; }
        public Class? Class { get; set; }  
        public ICollection<Atendance>? Atendances { get; set; } = new HashSet<Atendance>();

    }
}
