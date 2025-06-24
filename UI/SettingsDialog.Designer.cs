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
            SuspendLayout();
            // 
            // LocalPathLabel
            // 
            LocalPathLabel.AutoSize = true;
            LocalPathLabel.Location = new Point(21, 34);
            LocalPathLabel.Name = "LocalPathLabel";
            LocalPathLabel.Size = new Size(62, 15);
            LocalPathLabel.TabIndex = 0;
            LocalPathLabel.Text = "Local Path";
            // 
            // LocalPathValue
            // 
            LocalPathValue.Location = new Point(108, 31);
            LocalPathValue.Name = "LocalPathValue";
            LocalPathValue.Size = new Size(653, 23);
            LocalPathValue.TabIndex = 1;
            // 
            // RemotePathValue
            // 
            RemotePathValue.Location = new Point(108, 71);
            RemotePathValue.Name = "RemotePathValue";
            RemotePathValue.Size = new Size(653, 23);
            RemotePathValue.TabIndex = 3;
            // 
            // RemotePathLabel
            // 
            RemotePathLabel.AutoSize = true;
            RemotePathLabel.Location = new Point(21, 74);
            RemotePathLabel.Name = "RemotePathLabel";
            RemotePathLabel.Size = new Size(75, 15);
            RemotePathLabel.TabIndex = 2;
            RemotePathLabel.Text = "Remote Path";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(605, 415);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 23);
            SaveBtn.TabIndex = 4;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(686, 415);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DryRunChk
            // 
            DryRunChk.AutoSize = true;
            DryRunChk.Location = new Point(108, 119);
            DryRunChk.Name = "DryRunChk";
            DryRunChk.Size = new Size(15, 14);
            DryRunChk.TabIndex = 6;
            DryRunChk.UseVisualStyleBackColor = true;
            // 
            // DryRunLabel
            // 
            DryRunLabel.AutoSize = true;
            DryRunLabel.Location = new Point(21, 119);
            DryRunLabel.Name = "DryRunLabel";
            DryRunLabel.Size = new Size(49, 15);
            DryRunLabel.TabIndex = 7;
            DryRunLabel.Text = "Dry Run";
            // 
            // PromptOnConflictLabel
            // 
            PromptOnConflictLabel.AutoSize = true;
            PromptOnConflictLabel.Location = new Point(181, 119);
            PromptOnConflictLabel.Name = "PromptOnConflictLabel";
            PromptOnConflictLabel.Size = new Size(111, 15);
            PromptOnConflictLabel.TabIndex = 9;
            PromptOnConflictLabel.Text = "Prompt On Conflict";
            // 
            // PromptOnConflictChk
            // 
            PromptOnConflictChk.AutoSize = true;
            PromptOnConflictChk.Location = new Point(313, 120);
            PromptOnConflictChk.Name = "PromptOnConflictChk";
            PromptOnConflictChk.Size = new Size(15, 14);
            PromptOnConflictChk.TabIndex = 8;
            PromptOnConflictChk.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "SettingsDialog";
            Text = "SettingsDialog";
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
    }
}