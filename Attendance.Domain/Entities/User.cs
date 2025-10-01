using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class User
    {
        [Key]
        public int User_id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int? Role_Id { get; set; }
        public Role? Role { get; set; }

    }
}
