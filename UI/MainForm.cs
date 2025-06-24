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

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            trayIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { trayIcon.Visible = false; }
        }

        private void trayIconContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
