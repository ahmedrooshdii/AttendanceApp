using Attendance.Domain.Entities;
using Attendance.Infrastructure.DataSeed;
using Attendance.Infrastructure.RepositoryImplementation;
using Attendance.Presentation.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Attendance.Presentation
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            await Task.Yield(); // ensure async path

            // Configure DI in background
            var services = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            services.AddSingleton<IConfiguration>(configuration);

            services.AddDbContext<AttendanceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserServices>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IClassServices, ClassServices>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IAttendanceService, AttendanceService>();

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

            // Run WinForms on STA thread
            var thread = new Thread(() =>
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var loginForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            });

            thread.SetApartmentState(ApartmentState.STA); // required for DataGridView ComboBox etc.
            thread.Start();
            thread.Join();
        }
    }
}
