using System.Diagnostics;
using System.Security.Principal;

namespace DocuSync.Core
{
    public static class PrivilegeHelper
    {
        public static bool IsElevated()
        {
            using var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void RelaunchAsAdmin()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = Application.ExecutablePath,
                UseShellExecute = true,
                Verb = "runas"
            };

            try
            {
                Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("Administrator privileges are required.", "Elevation Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0);
        }

        public static void CreateScheduledTaskIfMissing(string pathToExe, string taskName = "DocuSyncElevated")
        {
            AppDomain.CurrentDomain.ProcessExit += (s, e) => RemoveDocuSyncTask();
            Application.ApplicationExit += (s, e) => RemoveDocuSyncTask();

            var checkTask = new ProcessStartInfo
            {
                FileName = "schtasks",
                Arguments = $"/Query /TN \"{taskName}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using var check = Process.Start(checkTask);
                check.WaitForExit();

                if (check.ExitCode == 0)
                    return; // Task already exists
            }
            catch { /* Treat as task not existing */ }

            var createTask = new ProcessStartInfo
            {
                FileName = "schtasks",
                Arguments = $"/Create /F /RL HIGHEST /SC ONCE /TN \"{taskName}\" /TR \"{pathToExe}\"",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var proc = Process.Start(createTask);
            proc.WaitForExit();

            if (proc.ExitCode != 0)
            {
                Logger.Error("Scheduled Task creatation failed for docusync app using command:");
                Logger.Error($"schtasks /Create /F /RL HIGHEST /SC ONDEMAND /TN \"{taskName}\" /TR \"\\\"{pathToExe}\\\"\"");
                MessageBox.Show("Failed to create scheduled task for DocuSync.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveDocuSyncTask()
        {
            var deleteTask = new ProcessStartInfo
            {
                FileName = "schtasks",
                Arguments = "/Delete /TN \"DocuSyncElevated\" /F",
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                var proc = Process.Start(deleteTask);
                proc.WaitForExit();

                if (proc.ExitCode == 0)
                    Logger.Info("Scheduled task 'DocuSyncElevated' removed.");
                else
                    Logger.Warning("Failed to remove scheduled task. It may not have existed or required elevation.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while removing scheduled task: {ex.Message}");
            }
        }
    }
}
