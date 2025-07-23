using System;
using System.Diagnostics;
using System.Windows.Forms;
using DocuSyncShared;

namespace DocuSyncWatchDog
{
    static class Program
    {
        private static HeartBeatMonitor? _monitor;

        public static Process? DocuSync;
        public static bool RestartNeeded = false;

        [STAThread]
        static void Main()
        {
            try
            {
                Logger.SetLogFile(".\\Log", "DocuSync_");
                Logger.Info("DocuSyncWatchDog started.");
                bool _running = true;
                while (_running)
                {
                    RestartNeeded = false;
                    StartDocuSync();

                    _monitor = new HeartBeatMonitor();

                    Task.Run(() =>
                    {
                        DocuSync.WaitForExit();
                        Logger.Info($"DocuSync exited with code {DocuSync.ExitCode}");
                        if (DocuSync.ExitCode != 0) RestartNeeded = true;
                    });

                    if (!DocuSync.HasExited) _monitor.Start();

                    if (RestartNeeded)
                        if (RestartDocuSync())
                            continue;
                    _running = false;
                }




                Logger.Info("DocuSyncWatchDog shutting down.");
            }
            catch (Exception ex)
            {
                Logger.Error($"Docusync WatchDog encountered an Error: {ex.GetType().Name}: {ex.Message}");
                Logger.Error($"StackTrace: {ex.StackTrace}");
            }

        }

        public static bool RestartDocuSync()
        {
            if (_monitor == null || DocuSync == null) throw new InvalidOperationException("Cannot run DocuSync exit procedure as DocuSync is null or heartbeat monitor is null");
            _monitor = null;
            var result = MessageBox.Show(
                $"DocuSync exited (code {DocuSync.ExitCode}). Restart?",
                "DocuSync WatchDog",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            DocuSync.Dispose();
            DocuSync = null;
            if (result == DialogResult.Yes)
            {
                Logger.Info("User chose to restart Docusync.");
                return true;
            }
            else
            {
                Logger.Info("User chose not to restart DocuSync.");
                return false;
            }

        }

        public static void StartDocuSync()
        {
            if (DocuSync != null && !DocuSync.HasExited) throw new InvalidOperationException("Cannot start Docusync while an instance of the app is already running!!");
            DocuSync = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "DocuSync.exe",
                    UseShellExecute = false
                }

            };
            Logger.Info("Launching DocuSync...");
            DocuSync.Start();
        }
    }
}