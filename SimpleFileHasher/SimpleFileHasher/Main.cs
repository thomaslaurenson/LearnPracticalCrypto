using System;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FileHasher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // Bind combobox to dictionary
            Dictionary<int, string> test = new Dictionary<int, string>
            {
                { 1, "MD5" },
                { 2, "SHA-1" },
                { 3, "SHA-256" },
                { 4, "SHA-512" }
            };
            hashAlgorithmSelection.DataSource = new BindingSource(test, null);
            hashAlgorithmSelection.DisplayMember = "Value";
            hashAlgorithmSelection.ValueMember = "Key";

            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog
            {
                Title = "Open File Dialog",
                InitialDirectory = @"c:\",
                Filter = "All files (*.*)|*.*|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                targetFileBox.Text = fdlg.FileName;
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Read in background worker arguments and set variables
            List<string> genericlist = e.Argument as List<string>;
            string targetFile = genericlist[0];
            string selectedAlgorithm = genericlist[1];

            // Create the hash algorithm objects based on argument
            HashAlgorithm hashAlgorithm;
            if (selectedAlgorithm == "MD5")
                hashAlgorithm = MD5.Create();
            else if (selectedAlgorithm == "SHA-1")
                hashAlgorithm = SHA1.Create();
            else if (selectedAlgorithm == "SHA-256")
                hashAlgorithm = SHA256.Create();
            else if (selectedAlgorithm == "SHA-512")
                hashAlgorithm = SHA512.Create();
            else
                hashAlgorithm = MD5.Create();

            // Variables for hashing
            byte[] buffer;
            byte[] oldBuffer;
            int bytesRead;
            int oldBytesRead;
            long size;
            long totalBytesRead = 0;

            // Start the file hashing progress
            using (Stream stream = File.OpenRead(targetFile))
            {
                using (hashAlgorithm)
                {
                    size = stream.Length;
                    buffer = new byte[4096];

                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    totalBytesRead += bytesRead;

                    do
                    {
                        oldBytesRead = bytesRead;
                        oldBuffer = buffer;

                        buffer = new byte[4096];
                        bytesRead = stream.Read(buffer, 0, buffer.Length);

                        totalBytesRead += bytesRead;

                        if (bytesRead == 0)
                        {
                            hashAlgorithm.TransformFinalBlock(oldBuffer, 0, oldBytesRead);
                        }
                        else
                        {
                            hashAlgorithm.TransformBlock(oldBuffer, 0, oldBytesRead, oldBuffer, 0);
                        }

                        // Convert progress to integer for progress bar updates 
                        int currentProgress = Convert.ToInt32(totalBytesRead * 100 / size);
                        backgroundWorker1.ReportProgress(currentProgress);
                    } while (bytesRead != 0);

                    // Set progress bar back to zero
                    backgroundWorker1.ReportProgress(0);

                    // Add result to the event 
                    e.Result = hashAlgorithm.Hash;
                }
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Convert the bytes to hexidecimal
            foreach (byte b in (byte[])e.Result)
            {
                sb.AppendFormat("{0:X2}", b);
            }

            // Finally, add the hash value to the Hash Value text box
            hashValueBox.Text = sb.ToString();

        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }


        private void TargetFileBox_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void TargetFileBox_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
            targetFileBox.Text = fileName.First();
        }

        private void GenerateHashValueButton_Click(object sender, EventArgs e)
        {
            // First, try find hash algroithm value from combo box dictionary
            int selectedAlgorithmIndex = Convert.ToInt32(hashAlgorithmSelection.SelectedValue);
            if (selectedAlgorithmIndex >= 1 && selectedAlgorithmIndex <= 4)
            {
                if (string.IsNullOrWhiteSpace(targetFileBox.Text))
                {
                    // Check the user eneter something in the string/password box
                    string message = "Please load a file...";
                    string title = "ERROR";
                    MessageBox.Show(message, title);
                }
                else
                {
                    // Fetch the target file and selected hash algorithm from the form
                    string targetFile = targetFileBox.Text;
                    string hashAlgorithm = ((KeyValuePair<int, string>)hashAlgorithmSelection.SelectedItem).Value;

                    // Build a list of arguments for the background worker
                    List<string> arguments = new List<string>
                    {
                        targetFile,
                        hashAlgorithm
                    };

                    // Run the background worker to hash the file
                    backgroundWorker1.RunWorkerAsync(arguments);
                }
            }
            else
            {
                // Show error dialog for incorrent hashing algorithm selection
                string message = "Please select a valid hashing algoritm...";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }
    }
}
