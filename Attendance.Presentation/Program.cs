using Attendance.Domain.Entities;
using Attendance.Infrastructure.DataSeed;
using Attendance.Presentation.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
namespace Attendance.Presentation
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            var services = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<AttendanceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthService, AuthService>();

            // Register only LoginForm, dashboards are created with user object
            services.AddScoped<LoginForm>();

            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                try
                {
                    var db = scope.ServiceProvider.GetRequiredService<AttendanceDbContext>();
                    db.Database.Migrate();
                    await AttendanceDbContextSeed.SeedAsync(db);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}