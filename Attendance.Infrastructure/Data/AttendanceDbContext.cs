namespace Attendance.Infrastructure.Data
{
    public class AttendanceDbContext : DbContext
    {

     
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Attendence> Attendances { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }
        public DbSet<Preference> Preferences { get; set; }



        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AttendanceDbContext).Assembly);
    }
}
