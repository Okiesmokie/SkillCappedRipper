using System.Diagnostics;

namespace SkillCappedRipper {
    public partial class MainForm : Form {
        private SkillCapped skillCapped = new SkillCapped();

        public MainForm() {
            InitializeComponent();

            var videoPath = Directory.GetCurrentDirectory() + @"\videos\";
            
            Directory.CreateDirectory(videoPath);
            fileSystemWatcher.Path = videoPath;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var files = Directory.GetFiles(fileSystemWatcher.Path, "*.m3u8");

            foreach(var file in files) {
                listBoxFiles.Items.Add(Path.GetFileName(file));
            }

            statusStrip.Text = "Ready";
        }

        private async void buttonDownloadVideo_Click(object sender, EventArgs e) {
            statusStripLabel.Text = "Downloading Video...";
            listBoxFiles.Enabled = false;
            buttonDownloadVideo.Enabled = false;
            statusStripProgressBar.Visible = true;

            bool success = false;

            await Task.Run(() => {
                success = skillCapped.GeneratePlaylist(textBoxSkillCappedURL.Text, textBoxWrathFilename.Text);
            });

            statusStripProgressBar.Visible = false;
            listBoxFiles.Enabled = true;
            buttonDownloadVideo.Enabled = true;
            textBoxSkillCappedURL.Text = "";

            if(success) {
                statusStripLabel.Text = "Complete";
            } else {
                statusStripLabel.Text = "Error: " + skillCapped.GetLastError();
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e) {
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e) {
            listBoxFiles.Items.Add(Path.GetFileName(e.FullPath));
        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) {
            listBoxFiles.Items.Remove(Path.GetFileName(e.FullPath));
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e) {
            listBoxFiles.Items.Remove(Path.GetFileName(e.OldFullPath));
            listBoxFiles.Items.Add(Path.GetFileName(e.FullPath));
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e) {
            if(listBoxFiles.SelectedItem != null) {
                var fileName = fileSystemWatcher.Path + listBoxFiles.SelectedItem.ToString();

                new Process {
                    StartInfo = new ProcessStartInfo(fileName) {
                        UseShellExecute = true
                    }
                }.Start();
            }
        }

        private void textBoxSkillCappedURL_Enter(object sender, EventArgs e) {
        }

        private void textBoxSkillCappedURL_Click(object sender, EventArgs e) {
            if(sender is not null) {
                (sender as TextBox)!.SelectAll();
                (sender as TextBox)!.Focus();
            }
        }
    }
}