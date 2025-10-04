using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class BackupService : IBackupService
{
    private readonly IBackupRepository _repo;
    private readonly ILogger<BackupService> _logger;

    public BackupService(IBackupRepository repo, ILogger<BackupService> logger)
    {
        _repo = repo;
        _logger = logger;
    }

    public async Task BackupAsync(string backupPath, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Starting backup to {Path}", backupPath);
        await _repo.BackupDatabaseAsync(backupPath, cancellationToken);
        _logger.LogInformation("Backup finished: {Path}", backupPath);
    }

    public async Task RestoreAsync(string backupPath, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Starting restore from {Path}", backupPath);
        await _repo.RestoreDatabaseAsync(backupPath, cancellationToken);
        _logger.LogInformation("Restore finished: {Path}", backupPath);
    }
}
