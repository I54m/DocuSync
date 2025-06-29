using DocuSync.Core;
using DocuSync.UI;
using DocuSyncShared;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace DocuSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Icon = AppIcons.TrayIcon;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            trayIcon.BalloonTipTitle = "Window Minimized";
            trayIcon.BalloonTipText = "DocuSync is now running in the background";
            trayIcon.Text = "DocuSync";
            if (Config.StartMinimized && this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                trayIcon.Visible = true;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            { trayIcon.Visible = false; }
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsDialog settings = new SettingsDialog();
            settings.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                trayIcon.Visible = false;
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
