using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FileCheckerWithTimer
{
    public partial class Form1 : Form
    {
        private string targetFilePath;
        private string lastContent;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 15000;
            timer.Tick += timer_Tick;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select Target File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                targetFilePath = openFileDialog.FileName;
                lblFilePath.Text = targetFilePath;
                lastContent = File.ReadAllText(targetFilePath);

                if (ValidateTargetFile(targetFilePath))
                {
                    timer.Start();
                }                
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetFilePath) && File.Exists(targetFilePath))
            {
                string newContent = File.ReadAllText(targetFilePath);
                string changes = GetChanges(lastContent, newContent);
                if (!string.IsNullOrEmpty(changes))
                {
                    txtChanges.AppendText(changes + Environment.NewLine);
                    lastContent = newContent;
                }
            }
        }

        private bool ValidateTargetFile(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && filePath.EndsWith(".txt"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a valid text file (.txt).", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string GetChanges(string oldContent, string newContent)
        {
            string[] oldLines = oldContent.Split(Environment.NewLine);
            string[] newLines = newContent.Split(Environment.NewLine);
            StringBuilder changes = new StringBuilder();

            int shortestLength = Math.Min(oldLines.Length, newLines.Length);

            for (int i = 0; i < shortestLength; i++)
            {
                if (oldLines[i] == newLines[i])
                {
                    continue;
                }

                if (string.IsNullOrEmpty(oldLines[i]))
                {
                    changes.Append($"Added: {newLines[i]}");
                }
                else if (string.IsNullOrEmpty(newLines[i]))
                {
                    changes.Append($"Removed: {oldLines[i]}");
                }
                else
                {
                    changes.Append($"Removed: {oldLines[i]}  Added: {newLines[i]}");                    
                }
            }

            for (int i = shortestLength; i < oldLines.Length; i++)
            {
                changes.Append($"Removed: {oldLines[i]}");
            }
            for (int i = shortestLength; i < newLines.Length; i++)
            {
                changes.Append($"Added: {newLines[i]}");
            }

            return changes.ToString();
        }
    }
}
