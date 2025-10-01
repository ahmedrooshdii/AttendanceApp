using Attendance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Attendance.Infrastructure.Config
{
    public class TeacherClassConfig : IEntityTypeConfiguration<TeacherClass>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TeacherClass> builder)
        {
            builder.HasKey(tc => new { tc.Tch_id, tc.Class_Id });
           

        }
    }
}
