using DocuSync.Core;
using DocuSync.Monitoring;
using DocuSync.Resources;
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
            Environment.ExitCode = -1;
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
            if (Environment.ExitCode == 0) return;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(500);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                trayIcon.Visible = false;
            }
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsDialog settings = new SettingsDialog();
            settings.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            switch (e.CloseReason)
            {
                // User attempted to close app minimize instead
                case CloseReason.UserClosing:
                    {
                        if (Environment.ExitCode == 0) return;
                        e.Cancel = true;
                        this.WindowState = FormWindowState.Minimized;
                        return;
                    }
                // TrayIcon Exit option or exit called via other interal methods
                case CloseReason.ApplicationExitCall:
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.Show();
                            trayIcon.Visible = false;
                            this.WindowState = FormWindowState.Normal;
                        }
                        DialogResult result = MessageBox.Show(
                            $"DocuSync will now close",
                            "DocuSync",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);
                        if (result == DialogResult.Cancel)
                        {
                            Logger.Info("Close cancelled");
                            e.Cancel = true;
                            return;
                        }
                        else if (result == DialogResult.OK)
                        {
                            Logger.Info("User Closed Docusync");
                            Environment.ExitCode = 0;
                            this.Close();
                        }
                        break;
                    }
                // We are unsure what brought us here but close anyway
                default:
                    {
                        Environment.ExitCode = 1;
                        this.Close();
                        break;
                    }
            }
            // shutdown heartbeat regardless of closing reason (as long as we are actually closing and haven't returned already)
            _heartBeatTimer?.Stop();
            _heartBeat?.Dispose();
        }

        private void SimAppHangBtn_Click(object sender, EventArgs e)
        {
            _heartBeatTimer?.Stop();
        }
    }
}
