using DocuSync.UI;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace DocuSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            trayIcon.BalloonTipTitle = "Window Minimized";
            trayIcon.BalloonTipText = "DocuSync is now running in the background";
            trayIcon.Text = "DocuSync";
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            trayIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
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

        private void trayIconContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsDialog settings = new SettingsDialog();
            settings.ShowDialog();
        }
    }
}
