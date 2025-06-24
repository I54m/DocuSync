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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalPath = LocalPathValue.Text;
            Properties.Settings.Default.RemotePath = RemotePathValue.Text;
            Properties.Settings.Default.DryRun = DryRunChk.Checked;
            Properties.Settings.Default.PromptOnConflict = PromptOnConflictChk.Checked;

            //Properties.Settings.Default.ExcludedFolders = newList;

            Properties.Settings.Default.Save();
            MessageBox.Show("Settings saved successfully!", "DocuSync", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            LocalPathValue.Text = Config.LocalPath;
            RemotePathValue.Text = Config.RemotePath;
            DryRunChk.Checked = Config.DryRun;
            PromptOnConflictChk.Checked = Config.PromptOnConflict;
        }
    }
}
