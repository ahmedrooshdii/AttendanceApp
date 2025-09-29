
using Microsoft.Extensions.Logging;

namespace Attendance.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Load configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Register IConfiguration itself
            services.AddSingleton<IConfiguration>(configuration);

            // Configure EF Core
            services.AddDbContext<AttendanceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Register Repositories
            //services.AddScoped<IAttendanceRepository, AttendanceRepository>();

            // Register Services
            //services.AddScoped<IAttendanceService, AttendanceService>();

            // Register Forms
            services.AddScoped<LoginForm>();

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                try
                {
                    var db = scope.ServiceProvider.GetRequiredService<AttendanceDbContext>();
                    db.Database.Migrate(); // Apply migrations automatically
                    //AttendanceAppSeed.Seed(db);
                }
                catch (Exception ex)
                {
                    // Handle exceptions that occur during migration
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<AttendanceDbContext>>();
                    logger.LogError(ex, "An error occurred while migrating or seeding the database.");
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            ApplicationConfiguration.Initialize();
            Application.Run(loginForm);
        }
    }
}