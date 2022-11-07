namespace SkillCappedRipper {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelSkillCappedURL = new System.Windows.Forms.Label();
            this.textBoxSkillCappedURL = new System.Windows.Forms.TextBox();
            this.buttonDownloadVideo = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.textBoxWrathFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSkillCappedURL
            // 
            this.labelSkillCappedURL.AutoSize = true;
            this.labelSkillCappedURL.Location = new System.Drawing.Point(12, 45);
            this.labelSkillCappedURL.Name = "labelSkillCappedURL";
            this.labelSkillCappedURL.Size = new System.Drawing.Size(101, 15);
            this.labelSkillCappedURL.TabIndex = 0;
            this.labelSkillCappedURL.Text = "Skill-Capped URL:";
            // 
            // textBoxSkillCappedURL
            // 
            this.textBoxSkillCappedURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSkillCappedURL.Location = new System.Drawing.Point(119, 41);
            this.textBoxSkillCappedURL.Name = "textBoxSkillCappedURL";
            this.textBoxSkillCappedURL.Size = new System.Drawing.Size(238, 23);
            this.textBoxSkillCappedURL.TabIndex = 1;
            this.textBoxSkillCappedURL.Click += new System.EventHandler(this.textBoxSkillCappedURL_Click);
            this.textBoxSkillCappedURL.Enter += new System.EventHandler(this.textBoxSkillCappedURL_Enter);
            // 
            // buttonDownloadVideo
            // 
            this.buttonDownloadVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadVideo.Location = new System.Drawing.Point(363, 41);
            this.buttonDownloadVideo.Name = "buttonDownloadVideo";
            this.buttonDownloadVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadVideo.TabIndex = 2;
            this.buttonDownloadVideo.Text = "Download";
            this.buttonDownloadVideo.UseVisualStyleBackColor = true;
            this.buttonDownloadVideo.Click += new System.EventHandler(this.buttonDownloadVideo_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.statusStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 341);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(450, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(435, 17);
            this.statusStripLabel.Spring = true;
            this.statusStripLabel.Text = "Ready";
            this.statusStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripProgressBar
            // 
            this.statusStripProgressBar.Name = "statusStripProgressBar";
            this.statusStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.statusStripProgressBar.Visible = false;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 80);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(426, 244);
            this.listBoxFiles.TabIndex = 3;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.Filter = "*.m3u8";
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // textBoxWrathFilename
            // 
            this.textBoxWrathFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWrathFilename.Location = new System.Drawing.Point(119, 12);
            this.textBoxWrathFilename.Name = "textBoxWrathFilename";
            this.textBoxWrathFilename.Size = new System.Drawing.Size(319, 23);
            this.textBoxWrathFilename.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filename:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWrathFilename);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.labelSkillCappedURL);
            this.Controls.Add(this.textBoxSkillCappedURL);
            this.Controls.Add(this.buttonDownloadVideo);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "Skill-Capped Video Ripper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSkillCappedURL;
        private TextBox textBoxSkillCappedURL;
        private Button buttonDownloadVideo;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusStripLabel;
        private ListBox listBoxFiles;
        private FileSystemWatcher fileSystemWatcher;
        private ToolStripProgressBar statusStripProgressBar;
        private Label label1;
        private TextBox textBoxWrathFilename;
    }
}