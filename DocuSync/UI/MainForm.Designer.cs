namespace DocuSync
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            trayIcon = new NotifyIcon(components);
            trayIconContextMenu = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            SettingsBtn = new Button();
            SimAppHangBtn = new Button();
            trayIconContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = trayIconContextMenu;
            trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "trayIcon";
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // trayIconContextMenu
            // 
            trayIconContextMenu.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            trayIconContextMenu.Name = "contextMenuStrip1";
            trayIconContextMenu.Size = new Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // SettingsBtn
            // 
            SettingsBtn.Location = new Point(23, 21);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(75, 23);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
            SettingsBtn.UseVisualStyleBackColor = true;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // SimAppHangBtn
            // 
            SimAppHangBtn.Location = new Point(118, 21);
            SimAppHangBtn.Name = "SimAppHangBtn";
            SimAppHangBtn.Size = new Size(178, 23);
            SimAppHangBtn.TabIndex = 2;
            SimAppHangBtn.Text = "Simulate Application Hang";
            SimAppHangBtn.UseVisualStyleBackColor = true;
            SimAppHangBtn.Click += SimAppHangBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SimAppHangBtn);
            Controls.Add(SettingsBtn);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocuSync - Main Window";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            trayIconContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayIconContextMenu;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button SettingsBtn;
        private Button SimAppHangBtn;
    }
}
