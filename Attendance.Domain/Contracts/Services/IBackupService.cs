using System.Threading;
using System.Threading.Tasks;

public interface IBackupService
{
    Task BackupAsync(string backupPath, CancellationToken cancellationToken = default);
    Task RestoreAsync(string backupPath, CancellationToken cancellationToken = default);
}
