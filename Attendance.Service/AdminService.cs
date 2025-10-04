using Attendance.Domain.Contracts.Services;

public class AdminService
{
    private readonly IBackupService _backupService;

    public AdminService(IBackupService backupService)
    {
        _backupService = backupService;
    }

    public void Backup(string path) => _backupService.BackupAsync(path);
    public void Restore(string path) => _backupService.RestoreAsync(path);
}
