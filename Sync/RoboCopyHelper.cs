using DocuSync.Core;
using DocuSyncShared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Sync
{
    public static class RobocopyHelper
    {
        public class RobocopyResult
        {
            public int ExitCode { get; set; }
            public string Output { get; set; }
            public string Error { get; set; }
            public bool Success => ExitCode <= 7; // per robocopy docs
        }



        private static RobocopyResult Copy(string source, string destination, string options = "/MIR /FFT /Z /XA:H /W:5")
        {
            var result = new RobocopyResult();

            var psi = new ProcessStartInfo
            {
                FileName = "robocopy",
                Arguments = $"\"{source}\" \"{destination}\" {options}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var process = new Process { StartInfo = psi };

            var outputBuilder = new StringBuilder();
            var errorBuilder = new StringBuilder();

            process.OutputDataReceived += (s, e) => { if (e.Data != null) outputBuilder.AppendLine(e.Data); };
            process.ErrorDataReceived += (s, e) => { if (e.Data != null) errorBuilder.AppendLine(e.Data); };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            result.ExitCode = process.ExitCode;
            result.Output = outputBuilder.ToString();
            result.Error = errorBuilder.ToString();

            return result;
        }

        public static bool MoveFolderToRemote(string localPath)
        {
            // Base options: /MOVE moves files + deletes source, /E includes empty folders
            string options = "/MOVE /E /NFL /NDL /W:2 /R:2";

            string remotePath = Config.RemotePath;
            List<string> excludedFileNames = Config.ExcludedFiles.ToList();
            List<string> excludedFolderNames = Config.ExcludedFolders.ToList();

            // Exclude specific files
            if (excludedFileNames != null && excludedFileNames.Count > 0)
            {
                string xfArgs = string.Join(" ", excludedFileNames.Select(name => $"\"{name}\""));
                options += $" /XF {xfArgs}";
            }

            // Exclude specific folders
            if (excludedFolderNames != null && excludedFolderNames.Count > 0)
            {
                string xdArgs = string.Join(" ", excludedFolderNames.Select(name => $"\"{name}\""));
                options += $" /XD {xdArgs}";
            }

            var result = Copy(localPath, remotePath, options);

            if (!result.Success)
            {
                Logger.Error($"Robocopy failed (code {result.ExitCode}):\n{result.Error}");
                return false;
            }

            Logger.Info($"Successfully moved folder to: {remotePath}");
            return true;
        }
    }
}
