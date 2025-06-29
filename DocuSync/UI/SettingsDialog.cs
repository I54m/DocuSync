using DocuSync.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocuSync.UI
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }
        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            LocalPathValue.Text = Config.LocalPath;
            RemotePathValue.Text = Config.RemotePath;
            DryRunChk.Checked = Config.DryRun;
            PromptOnConflictChk.Checked = Config.PromptOnConflict;
            StartMinimizedChk.Checked = Config.StartMinimized;

            ExcludedFolderChkList.Items.Clear();
            foreach (var rel in Config.ExcludedFolders)
                ExcludedFolderChkList.Items.Add(rel);

            ExcludedFilesChkList.Items.Clear();
            foreach (var rel in Config.ExcludedFiles)
                ExcludedFilesChkList.Items.Add(rel);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Config.LocalPath = LocalPathValue.Text;
            Config.RemotePath = RemotePathValue.Text;
            Config.DryRun = DryRunChk.Checked;
            Config.PromptOnConflict = PromptOnConflictChk.Checked;
            Config.StartMinimized = StartMinimizedChk.Checked;

            Config.ExcludedFolders = ExcludedFolderChkList.Items.Cast<string>().ToArray();
            Config.ExcludedFiles = ExcludedFilesChkList.Items.Cast<string>().ToArray();

            MessageBox.Show("Settings saved successfully!", "DocuSync", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddExcludedFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Config.LocalPath != null)
                dialog.InitialDirectory = Config.LocalPath;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string relPath = Config.GetRelativeLocalPath(dialog.SelectedPath);
                if (!ExcludedFolderChkList.Items.Contains(relPath))
                    ExcludedFolderChkList.Items.Add(relPath);
            }
        }

        private void RemoveExcludedFolderBtn_Click(object sender, EventArgs e)
        {
            if (ExcludedFolderChkList.CheckedItems != null)
            {
                var tempCopy = ExcludedFolderChkList.CheckedItems.Cast<string>().ToArray();
                foreach (var folder in tempCopy)
                {
                    ExcludedFolderChkList.Items.Remove(folder);
                }
            }
        }

        private void AddExcludedFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (Config.LocalPath != null)
                dialog.InitialDirectory = Config.LocalPath;

            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
                foreach (string file in dialog.FileNames)
                {
                    string relpath = Config.GetRelativeLocalPath(file);
                    if (!ExcludedFilesChkList.Items.Contains(relpath))
                        ExcludedFilesChkList.Items.Add(relpath);
                }
        }

        private void RemoveExcludedFileBtn_Click(object sender, EventArgs e)
        {
            if (ExcludedFilesChkList.CheckedItems != null)
            {
                var tempCopy = ExcludedFilesChkList.SelectedItems.Cast<string>().ToArray();
                foreach (var folder in tempCopy)
                {
                    ExcludedFilesChkList.Items.Remove(folder);
                }
            }
        }

        private void LocalPathBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Config.LocalPath != null)
                dialog.InitialDirectory = Config.LocalPath;

            if (dialog.ShowDialog() == DialogResult.OK)
                LocalPathValue.Text = dialog.SelectedPath;
        }

        private void RemotePathBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (Config.RemotePath != null)
                dialog.InitialDirectory = Config.RemotePath;

            if (dialog.ShowDialog() == DialogResult.OK)
                RemotePathValue.Text = dialog.SelectedPath;
        }
    }
}
