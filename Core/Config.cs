using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSync.Core
{
    public static class Config
    {
        public static string LocalPath => Environment.ExpandEnvironmentVariables(Properties.Settings.Default.LocalPath ?? "");
        public static string RemotePath => Environment.ExpandEnvironmentVariables(Properties.Settings.Default.RemotePath ?? "");
        public static IReadOnlyList<String> ExcludedFolders => Properties.Settings.Default.ExcludedFolders?.Cast<string>().ToList() ?? new List<string>();
        public static IReadOnlyList<String> ExcludedFiles => Properties.Settings.Default.ExcludedFiles?.Cast<string>().ToList() ?? new List<string>();
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
    }
}
