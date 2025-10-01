namespace Attendance.Infrastructure.Data
{
    public class AttendanceDbContext : DbContext
    {

        #region DbSets
        // Write your DbSets here
        public DbSet<User> Users { get; set; }
        #endregion

        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AttendanceDbContext).Assembly);
    }
}
