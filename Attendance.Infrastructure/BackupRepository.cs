using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Attendance.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class BackupRepository : IBackupRepository
{
    private readonly AttendanceDbContext _dbContext;
    private readonly string _maintenanceConnectionString;
    private readonly ILogger<BackupRepository> _logger;

    public BackupRepository(AttendanceDbContext dbContext, IConfiguration config, ILogger<BackupRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
        _maintenanceConnectionString = config.GetConnectionString("Maintenance")
            ?? throw new InvalidOperationException("Maintenance connection string is missing in configuration.");
    }

    public async Task BackupDatabaseAsync(string backupPath, CancellationToken cancellationToken = default)
    {
        var dbName = _dbContext.Database.GetDbConnection().Database;
        _logger.LogInformation("BackupAsync: DB={Db}, Path={Path}", dbName, backupPath);

        await using var conn = new SqlConnection(_maintenanceConnectionString);
        await conn.OpenAsync(cancellationToken);

        await using var cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = @"BACKUP DATABASE [" + dbName + @"] TO DISK = @path WITH INIT, NAME = @name;";
        cmd.Parameters.AddWithValue("@path", backupPath);
        cmd.Parameters.AddWithValue("@name", $"Full Backup of {dbName} @ {DateTime.UtcNow:O}");

        await cmd.ExecuteNonQueryAsync(cancellationToken);
        _logger.LogInformation("BackupAsync completed for DB={Db}", dbName);
    }

    public async Task RestoreDatabaseAsync(string backupPath, CancellationToken cancellationToken = default)
    {
        var dbName = _dbContext.Database.GetDbConnection().Database;
        _logger.LogInformation("RestoreAsync: DB={Db}, Path={Path}", dbName, backupPath);

        await using var conn = new SqlConnection(_maintenanceConnectionString);
        await conn.OpenAsync(cancellationToken);

        await using var cmd = conn.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = $@"
            ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{dbName}] FROM DISK = @path WITH REPLACE;
            ALTER DATABASE [{dbName}] SET MULTI_USER;
            ";
        cmd.Parameters.AddWithValue("@path", backupPath);

        await cmd.ExecuteNonQueryAsync(cancellationToken);
        _logger.LogInformation("RestoreAsync completed for DB={Db}", dbName);
    }
}
