using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    [Table("Attendance")]
    public class Attendence
    {
        [Key]
        public int AttendanceId { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
     
        public Student? Student { get; set; }

        public DateTime Date { get;  }=DateTime.Now;    
        public string Notes { get; set; }   



    }
}
