using DocuSync.Core;
using DocuSync.UI;
using DocuSyncShared;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace DocuSync
{
    public partial class MainForm : Form
    {
        private HeartBeatWriter? _heartBeat;
        private System.Windows.Forms.Timer _heartBeatTimer;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = AppIcons.TrayIcon;
            StartHeartBeat();
        }

        public void StartHeartBeat()
        {
            Logger.SetLogFile(".\\Log", "DocuSync_");
            Logger.Info("DocuSync started.");
            _heartBeat = new HeartBeatWriter();
            _heartBeatTimer = new System.Windows.Forms.Timer();
            _heartBeatTimer.Interval = 5000;
            _heartBeatTimer.Tick += (s, e) =>
            {
                _heartBeat.Beat();
            };
            _heartBeatTimer.Start();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _heartBeatTimer?.Stop();
            _heartBeat?.Dispose();
        }

        private void SimAppHangBtn_Click(object sender, EventArgs e)
        {
            _heartBeatTimer?.Stop();
        }
    }
}
