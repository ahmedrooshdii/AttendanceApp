using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class DatabaseLog : Form
    {
        private readonly IBackupService _backupService;
        private CancellationTokenSource? _currentCts;

        // Controls: btnBackup, btnRestore, btnCancel, lblStatus
        public DatabaseLog(IBackupService backupService)
        {
            _backupService = backupService;
            InitializeComponent();

            btnCancel.Enabled = false;
        }

        #region Backup & Restore
        private void UpdateStatus(string text)
        {
            lblStatus.Text = text;
        }

        private async void Backup(object? sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "Backup files (*.bak)|*.bak",
                FileName = $"MyDb_{DateTime.Now:yyyyMMdd_HHmmss}.bak"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
            btnCancel.Enabled = true;

            _currentCts = new CancellationTokenSource();
            UpdateStatus("Backing up...");

            try
            {
                await _backupService.BackupAsync(sfd.FileName, _currentCts.Token);
                UpdateStatus("Backup completed.");
                MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                UpdateStatus("Backup cancelled.");
                MessageBox.Show("Backup was cancelled.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex) when (ex.Message.Contains("cancelled", StringComparison.OrdinalIgnoreCase))
            {
                UpdateStatus("Backup cancelled.");
                MessageBox.Show("Backup was cancelled.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                UpdateStatus("Backup failed.");
                MessageBox.Show("Backup failed: " + ex.Message, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBackup.Enabled = true;
                btnRestore.Enabled = true;
                btnCancel.Enabled = false;
                _currentCts?.Dispose();
                _currentCts = null;
            }
        }

        private async void Restore(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Backup files (*.bak)|*.bak"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            var confirm = MessageBox.Show("Restore will overwrite the current database. Continue?", "Confirm Restore",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
            btnCancel.Enabled = true;
            _currentCts = new CancellationTokenSource();
            UpdateStatus("Restoring...");

            try
            {
                await _backupService.RestoreAsync(ofd.FileName, _currentCts.Token);
                UpdateStatus("Restore completed.");
                MessageBox.Show("Restore completed successfully.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                UpdateStatus("Restore cancelled.");
                MessageBox.Show("Restore was cancelled.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex) when (ex.Message.Contains("cancelled", StringComparison.OrdinalIgnoreCase))
            {
                UpdateStatus("Restore cancelled.");
                MessageBox.Show("Restore was cancelled.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                UpdateStatus("Restore failed.");
                MessageBox.Show("Restore failed: " + ex.Message, "Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBackup.Enabled = true;
                btnRestore.Enabled = true;
                btnCancel.Enabled = false;
                _currentCts?.Dispose();
                _currentCts = null;
            }
        }

        private void Cancel(object? sender, EventArgs e)
        {
            if (_currentCts != null && !_currentCts.IsCancellationRequested)
            {
                _currentCts.Cancel();
                UpdateStatus("Cancelling...");
            }
        }
        #endregion
    }
}