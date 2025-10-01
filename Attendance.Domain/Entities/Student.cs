using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }   
        public string StudentName { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }
        [ForeignKey("Class")]
        public int? ClassId { get; set; }
        public Class? Class { get; set; }  
        public ICollection<Attendence>? Atendances { get; set; } = new HashSet<Attendence>();

    }
}
