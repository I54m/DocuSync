using System;
using System.Diagnostics;
using System.Windows.Forms;
using DocuSyncShared;

namespace DocuSyncWatchDog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Logger.SetLogFile(".\\Log", "DocuSync_");
            Logger.Info("DocuSyncWatchDog started.");

            while (true)
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "DocuSync.exe",
                        UseShellExecute = false
                    }
                };

                Logger.Info("Launching DocuSync...");
                proc.Start();
                proc.WaitForExit();
                Logger.Info($"DocuSync exited with code {proc.ExitCode}");

                var result = MessageBox.Show(
                    $"DocuSync exited (code {proc.ExitCode}). Restart?",
                    "DocuSync WatchDog",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    Logger.Info("User chose not to restart DocuSync.");
                    break;
                }
            }

            Logger.Info("DocuSyncWatchDog shutting down.");
        }
    }
}