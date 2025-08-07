namespace DocuSync.UI
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            LocalPathLabel = new Label();
            LocalPathValue = new TextBox();
            RemotePathValue = new TextBox();
            RemotePathLabel = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
            DryRunChk = new CheckBox();
            DryRunLabel = new Label();
            PromptOnConflictLabel = new Label();
            PromptOnConflictChk = new CheckBox();
            StartMinimizedLabel = new Label();
            StartMinimizedChk = new CheckBox();
            ExcludedFolderChkList = new CheckedListBox();
            ExcludedFilesChkList = new CheckedListBox();
            AddExcludedFolderBtn = new Button();
            AddExcludedFileBtn = new Button();
            RemoveExcludedFolderBtn = new Button();
            RemoveExcludedFileBtn = new Button();
            ExcludedFoldersLabel = new Label();
            ExcludedFilesLabel = new Label();
            LocalPathBrowseBtn = new Button();
            RemotePathBrowseBtn = new Button();
            SettingsDialogToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // LocalPathLabel
            // 
            LocalPathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LocalPathLabel.AutoSize = true;
            LocalPathLabel.Location = new Point(21, 34);
            LocalPathLabel.Name = "LocalPathLabel";
            LocalPathLabel.Size = new Size(62, 15);
            LocalPathLabel.TabIndex = 0;
            LocalPathLabel.Text = "Local Path";
            SettingsDialogToolTip.SetToolTip(LocalPathLabel, "Absolute path to the top level directory where the files are locally stored");
            // 
            // LocalPathValue
            // 
            LocalPathValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LocalPathValue.Location = new Point(108, 31);
            LocalPathValue.Name = "LocalPathValue";
            LocalPathValue.Size = new Size(587, 23);
            LocalPathValue.TabIndex = 1;
            SettingsDialogToolTip.SetToolTip(LocalPathValue, "Absolute path to the top level directory where the files are locally stored");
            // 
            // RemotePathValue
            // 
            RemotePathValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemotePathValue.Location = new Point(108, 71);
            RemotePathValue.Name = "RemotePathValue";
            RemotePathValue.Size = new Size(587, 23);
            RemotePathValue.TabIndex = 3;
            SettingsDialogToolTip.SetToolTip(RemotePathValue, "Absolute path to the top level directory where the files are locally stored");
            // 
            // RemotePathLabel
            // 
            RemotePathLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemotePathLabel.AutoSize = true;
            RemotePathLabel.Location = new Point(21, 74);
            RemotePathLabel.Name = "RemotePathLabel";
            RemotePathLabel.Size = new Size(75, 15);
            RemotePathLabel.TabIndex = 2;
            RemotePathLabel.Text = "Remote Path";
            SettingsDialogToolTip.SetToolTip(RemotePathLabel, "Absolute path to the top level directory where the files are locally stored");
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveBtn.Location = new Point(553, 426);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(78, 23);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SettingsDialogToolTip.SetToolTip(SaveBtn, "Save changes and return to main window");
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.Location = new Point(637, 426);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(85, 23);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            SettingsDialogToolTip.SetToolTip(CancelBtn, "Discard changes and return to main window");
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DryRunChk
            // 
            DryRunChk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DryRunChk.AutoSize = true;
            DryRunChk.Location = new Point(76, 120);
            DryRunChk.Name = "DryRunChk";
            DryRunChk.Size = new Size(15, 14);
            DryRunChk.TabIndex = 6;
            SettingsDialogToolTip.SetToolTip(DryRunChk, "Don't copy or link any files, intead log operations. Used to test that your setup is working");
            DryRunChk.UseVisualStyleBackColor = true;
            // 
            // DryRunLabel
            // 
            DryRunLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DryRunLabel.AutoSize = true;
            DryRunLabel.Location = new Point(21, 119);
            DryRunLabel.Name = "DryRunLabel";
            DryRunLabel.Size = new Size(49, 15);
            DryRunLabel.TabIndex = 7;
            DryRunLabel.Text = "Dry Run";
            SettingsDialogToolTip.SetToolTip(DryRunLabel, "Don't copy or link any files, intead log operations. Used to test that your setup is working");
            // 
            // PromptOnConflictLabel
            // 
            PromptOnConflictLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PromptOnConflictLabel.AutoSize = true;
            PromptOnConflictLabel.Location = new Point(112, 119);
            PromptOnConflictLabel.Name = "PromptOnConflictLabel";
            PromptOnConflictLabel.Size = new Size(111, 15);
            PromptOnConflictLabel.TabIndex = 9;
            PromptOnConflictLabel.Text = "Prompt On Conflict";
            SettingsDialogToolTip.SetToolTip(PromptOnConflictLabel, "Prompt on File/Folder conflict or attempt to auto resolve");
            // 
            // PromptOnConflictChk
            // 
            PromptOnConflictChk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PromptOnConflictChk.AutoSize = true;
            PromptOnConflictChk.Location = new Point(229, 120);
            PromptOnConflictChk.Name = "PromptOnConflictChk";
            PromptOnConflictChk.Size = new Size(15, 14);
            PromptOnConflictChk.TabIndex = 8;
            SettingsDialogToolTip.SetToolTip(PromptOnConflictChk, "Prompt on File/Folder conflict or attempt to auto resolve");
            PromptOnConflictChk.UseVisualStyleBackColor = true;
            // 
            // StartMinimizedLabel
            // 
            StartMinimizedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StartMinimizedLabel.AutoSize = true;
            StartMinimizedLabel.Location = new Point(273, 119);
            StartMinimizedLabel.Name = "StartMinimizedLabel";
            StartMinimizedLabel.Size = new Size(90, 15);
            StartMinimizedLabel.TabIndex = 13;
            StartMinimizedLabel.Text = "Start Minimized";
            SettingsDialogToolTip.SetToolTip(StartMinimizedLabel, "Start the application minimized to the notification area on start");
            // 
            // StartMinimizedChk
            // 
            StartMinimizedChk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StartMinimizedChk.AutoSize = true;
            StartMinimizedChk.Location = new Point(369, 120);
            StartMinimizedChk.Name = "StartMinimizedChk";
            StartMinimizedChk.Size = new Size(15, 14);
            StartMinimizedChk.TabIndex = 12;
            SettingsDialogToolTip.SetToolTip(StartMinimizedChk, "Start the application minimized to the notification area on start");
            StartMinimizedChk.UseVisualStyleBackColor = true;
            // 
            // ExcludedFolderChkList
            // 
            ExcludedFolderChkList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ExcludedFolderChkList.FormattingEnabled = true;
            ExcludedFolderChkList.Location = new Point(21, 180);
            ExcludedFolderChkList.Name = "ExcludedFolderChkList";
            ExcludedFolderChkList.Size = new Size(288, 166);
            ExcludedFolderChkList.TabIndex = 14;
            SettingsDialogToolTip.SetToolTip(ExcludedFolderChkList, "List of local folders that will be kept local and backed up to the remote when required");
            // 
            // ExcludedFilesChkList
            // 
            ExcludedFilesChkList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ExcludedFilesChkList.FormattingEnabled = true;
            ExcludedFilesChkList.Location = new Point(431, 180);
            ExcludedFilesChkList.Name = "ExcludedFilesChkList";
            ExcludedFilesChkList.Size = new Size(264, 166);
            ExcludedFilesChkList.TabIndex = 15;
            SettingsDialogToolTip.SetToolTip(ExcludedFilesChkList, "List of local folders that will be kept local and backed up to the remote when required");
            // 
            // AddExcludedFolderBtn
            // 
            AddExcludedFolderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddExcludedFolderBtn.Location = new Point(40, 359);
            AddExcludedFolderBtn.Name = "AddExcludedFolderBtn";
            AddExcludedFolderBtn.Size = new Size(102, 23);
            AddExcludedFolderBtn.TabIndex = 16;
            AddExcludedFolderBtn.Text = "Add Folder";
            SettingsDialogToolTip.SetToolTip(AddExcludedFolderBtn, "Add a folder to list");
            AddExcludedFolderBtn.UseVisualStyleBackColor = true;
            AddExcludedFolderBtn.Click += AddExcludedFolderBtn_Click;
            // 
            // AddExcludedFileBtn
            // 
            AddExcludedFileBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddExcludedFileBtn.Location = new Point(467, 359);
            AddExcludedFileBtn.Name = "AddExcludedFileBtn";
            AddExcludedFileBtn.Size = new Size(89, 23);
            AddExcludedFileBtn.TabIndex = 17;
            AddExcludedFileBtn.Text = "Add Files";
            SettingsDialogToolTip.SetToolTip(AddExcludedFileBtn, "Add file to list");
            AddExcludedFileBtn.UseVisualStyleBackColor = true;
            AddExcludedFileBtn.Click += AddExcludedFileBtn_Click;
            // 
            // RemoveExcludedFolderBtn
            // 
            RemoveExcludedFolderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveExcludedFolderBtn.Location = new Point(167, 359);
            RemoveExcludedFolderBtn.Name = "RemoveExcludedFolderBtn";
            RemoveExcludedFolderBtn.Size = new Size(111, 23);
            RemoveExcludedFolderBtn.TabIndex = 18;
            RemoveExcludedFolderBtn.Text = "Remove Folders";
            SettingsDialogToolTip.SetToolTip(RemoveExcludedFolderBtn, "Remove the selected folders from list");
            RemoveExcludedFolderBtn.UseVisualStyleBackColor = true;
            RemoveExcludedFolderBtn.Click += RemoveExcludedFolderBtn_Click;
            // 
            // RemoveExcludedFileBtn
            // 
            RemoveExcludedFileBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveExcludedFileBtn.Location = new Point(573, 359);
            RemoveExcludedFileBtn.Name = "RemoveExcludedFileBtn";
            RemoveExcludedFileBtn.Size = new Size(89, 23);
            RemoveExcludedFileBtn.TabIndex = 19;
            RemoveExcludedFileBtn.Text = "Remove Files";
            SettingsDialogToolTip.SetToolTip(RemoveExcludedFileBtn, "Remove selected files from list");
            RemoveExcludedFileBtn.UseVisualStyleBackColor = true;
            RemoveExcludedFileBtn.Click += RemoveExcludedFileBtn_Click;
            // 
            // ExcludedFoldersLabel
            // 
            ExcludedFoldersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ExcludedFoldersLabel.AutoSize = true;
            ExcludedFoldersLabel.Location = new Point(94, 162);
            ExcludedFoldersLabel.Name = "ExcludedFoldersLabel";
            ExcludedFoldersLabel.Size = new Size(126, 15);
            ExcludedFoldersLabel.TabIndex = 20;
            ExcludedFoldersLabel.Text = "Excluded Local Folders";
            SettingsDialogToolTip.SetToolTip(ExcludedFoldersLabel, "List of local folders that will be kept local and backed up to the remote when required");
            // 
            // ExcludedFilesLabel
            // 
            ExcludedFilesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ExcludedFilesLabel.AutoSize = true;
            ExcludedFilesLabel.Location = new Point(508, 162);
            ExcludedFilesLabel.Name = "ExcludedFilesLabel";
            ExcludedFilesLabel.Size = new Size(111, 15);
            ExcludedFilesLabel.TabIndex = 21;
            ExcludedFilesLabel.Text = "Excluded Local Files";
            SettingsDialogToolTip.SetToolTip(ExcludedFilesLabel, "List of local folders that will be kept local and backed up to the remote when required");
            // 
            // LocalPathBrowseBtn
            // 
            LocalPathBrowseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LocalPathBrowseBtn.Location = new Point(696, 32);
            LocalPathBrowseBtn.Name = "LocalPathBrowseBtn";
            LocalPathBrowseBtn.Size = new Size(26, 19);
            LocalPathBrowseBtn.TabIndex = 22;
            LocalPathBrowseBtn.Text = "...";
            SettingsDialogToolTip.SetToolTip(LocalPathBrowseBtn, "Browse");
            LocalPathBrowseBtn.UseVisualStyleBackColor = true;
            LocalPathBrowseBtn.Click += LocalPathBrowseBtn_Click;
            // 
            // RemotePathBrowseBtn
            // 
            RemotePathBrowseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemotePathBrowseBtn.Location = new Point(696, 75);
            RemotePathBrowseBtn.Name = "RemotePathBrowseBtn";
            RemotePathBrowseBtn.Size = new Size(26, 19);
            RemotePathBrowseBtn.TabIndex = 23;
            RemotePathBrowseBtn.Text = "...";
            SettingsDialogToolTip.SetToolTip(RemotePathBrowseBtn, "Browse");
            RemotePathBrowseBtn.UseVisualStyleBackColor = true;
            RemotePathBrowseBtn.Click += RemotePathBrowseBtn_Click;
            // 
            // SettingsDialogToolTip
            // 
            SettingsDialogToolTip.AutomaticDelay = 1000;
            // 
            // SettingsDialog
            // 
            AcceptButton = SaveBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(734, 461);
            Controls.Add(RemotePathBrowseBtn);
            Controls.Add(LocalPathBrowseBtn);
            Controls.Add(ExcludedFilesLabel);
            Controls.Add(ExcludedFoldersLabel);
            Controls.Add(RemoveExcludedFileBtn);
            Controls.Add(RemoveExcludedFolderBtn);
            Controls.Add(AddExcludedFileBtn);
            Controls.Add(AddExcludedFolderBtn);
            Controls.Add(ExcludedFilesChkList);
            Controls.Add(ExcludedFolderChkList);
            Controls.Add(StartMinimizedLabel);
            Controls.Add(StartMinimizedChk);
            Controls.Add(PromptOnConflictLabel);
            Controls.Add(PromptOnConflictChk);
            Controls.Add(DryRunLabel);
            Controls.Add(DryRunChk);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(RemotePathValue);
            Controls.Add(RemotePathLabel);
            Controls.Add(LocalPathValue);
            Controls.Add(LocalPathLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(750, 500);
            Name = "SettingsDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DocuSync Settings";
            Load += SettingsDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LocalPathLabel;
        private TextBox LocalPathValue;
        private TextBox RemotePathValue;
        private Label RemotePathLabel;
        private Button SaveBtn;
        private Button CancelBtn;
        private CheckBox DryRunChk;
        private Label DryRunLabel;
        private Label PromptOnConflictLabel;
        private CheckBox PromptOnConflictChk;
        private Label StartMinimizedLabel;
        private CheckBox StartMinimizedChk;
        private CheckedListBox ExcludedFolderChkList;
        private CheckedListBox ExcludedFilesChkList;
        private Button AddExcludedFolderBtn;
        private Button AddExcludedFileBtn;
        private Button RemoveExcludedFolderBtn;
        private Button RemoveExcludedFileBtn;
        private Label ExcludedFoldersLabel;
        private Label ExcludedFilesLabel;
        private Button LocalPathBrowseBtn;
        private Button RemotePathBrowseBtn;
        private ToolTip SettingsDialogToolTip;
    }
}