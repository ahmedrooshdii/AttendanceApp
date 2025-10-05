using Attendance.Domain.Entities;
using Attendance.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Attendance.Presentation.Forms
{
    public partial class Preference : Form
    {
        private readonly PreferenceService _service;
        private Attendance.Domain.Entities.Preference? _currentPreference;
        public Preference(IServiceProvider service)
        {
            InitializeComponent();
            _service = service.GetRequiredService<PreferenceService>();
            this.Load += Preference_Load;
            save.Click += Save_Click;
        }

        private async void Preference_Load(object sender, EventArgs e)
        {
            _currentPreference = await _service.GetPreference();
            cmbLanguage.SelectedItem = _currentPreference?.Language;
            cmbDateFormat.SelectedItem = _currentPreference?.DateFormat;
            cmbTheme.SelectedItem = _currentPreference?.Theme;
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            var updated = new Attendance.Domain.Entities.Preference
            {
                Language = cmbLanguage.SelectedItem?.ToString() ?? "Arabic",
                DateFormat = cmbDateFormat.SelectedItem?.ToString() ?? "dd/MM/yyyy",
                Theme = cmbTheme.SelectedItem?.ToString() ?? "Light"
            };
            var result = await _service.UpdatePreference(updated);
            if (result != null)
            {
                _currentPreference = result;
                cmbLanguage.SelectedItem = _currentPreference.Language;
                cmbDateFormat.SelectedItem = _currentPreference.DateFormat;
                cmbTheme.SelectedItem = _currentPreference.Theme;
                MessageBox.Show("Preferences updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update preferences.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDateFormat_Click(object sender, EventArgs e) { }
        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
