using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance.Domain.Entities
{
    public class TeacherClass
    {
        public int? Tch_id { get; set; }
        public Teacher? Teacher { get; set; }

        public int ?Class_Id { get; set; }

        public Class? Class { get; set; }       

    }
}
