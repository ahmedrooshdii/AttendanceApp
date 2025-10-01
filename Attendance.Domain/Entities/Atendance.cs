using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class Atendance
    {
        [Key]
        public int Attend_Id { get; set; }
        [ForeignKey("Student")]
        public int? St_id { get; set; }
     
        public Student? Student { get; set; }

        public DateTime Date { get;  }=DateTime.Now;    
        public string Notes { get; set; }   



    }
}
