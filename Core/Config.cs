using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Core
{
    public static class Config
    {

        public static IReadOnlyCollection<String> ExcludedFolders
        {
            get => Properties.Settings.Default.ExcludedFolders?.Cast<string>().ToList() ?? new List<string>();
            set
            {
                Properties.Settings.Default.ExcludedFolders.Clear();
                foreach (var folder in value)
                {
                    Properties.Settings.Default.ExcludedFolders.Add(folder);
                }
                Properties.Settings.Default.Save();
            }
        }
        public static IReadOnlyCollection<String> ExcludedFiles
        {
            get => Properties.Settings.Default.ExcludedFiles?.Cast<string>().ToList() ?? new List<string>();
            set
            {
                Properties.Settings.Default.ExcludedFiles.Clear();
                foreach (var folder in value)
                {
                    Properties.Settings.Default.ExcludedFiles.Add(folder);
                }
                Properties.Settings.Default.Save();
            }
        }

        public static string LocalPath
        {
            get => Environment.ExpandEnvironmentVariables(Properties.Settings.Default.LocalPath ?? "");
            set
            {
                Properties.Settings.Default.LocalPath = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string RemotePath
        {
            get => Environment.ExpandEnvironmentVariables(Properties.Settings.Default.RemotePath ?? "");
            set
            {
                Properties.Settings.Default.RemotePath = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool DryRun
        {
            get => Properties.Settings.Default.DryRun;
            set
            {
                Properties.Settings.Default.DryRun = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool PromptOnConflict
        {
            get => Properties.Settings.Default.PromptOnConflict;
            set
            {
                Properties.Settings.Default.PromptOnConflict = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool StartMinimized
        {
            get => Properties.Settings.Default.StartMinimized;
            set
            {
                Properties.Settings.Default.StartMinimized = value;
                Properties.Settings.Default.Save();
            }
        }

        public static string GetAbsoluteLocalPath(string relativePath) => Path.GetFullPath(Path.Combine(LocalPath, relativePath));

        public static string GetRelativeLocalPath(string fullPath)
        {
            var docs = Path.GetFullPath(LocalPath);
            var rel = Path.GetRelativePath(docs, fullPath);
            return rel.Replace('\\', '/'); // Normalize
        }

        public static string GetAbsoluteRemotePath(string relativePath) => Path.GetFullPath(Path.Combine(RemotePath, relativePath));

        public static string GetRelativeRemotePath(string fullPath)
        {
            var docs = Path.GetFullPath(RemotePath);
            var rel = Path.GetRelativePath(docs, fullPath);
            return rel.Replace('\\', '/'); // Normalize
        }
    }
}
