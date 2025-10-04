using System.Threading;
using System.Threading.Tasks;

public interface IBackupRepository
{
    Task BackupDatabaseAsync(string backupPath, CancellationToken cancellationToken = default);
    Task RestoreDatabaseAsync(string backupPath, CancellationToken cancellationToken = default);
}
