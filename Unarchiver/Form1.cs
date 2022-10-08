using System.IO.Compression;
using System.Security.Cryptography;
using System.Windows.Forms;
using Unarchiver.FileExstensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unarchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize File Dialog
            MainOpenFileDialog.InitialDirectory = "c:\\";
            MainOpenFileDialog.Filter = "zip files (*.zip)|*.zip|rar files (*.rar)|*.rar|iso files (*.iso)|*.iso";
            MainOpenFileDialog.FilterIndex = 2;
            MainOpenFileDialog.RestoreDirectory = true;
            MainOpenFileDialog.Multiselect = false;

            OpenFolderToUnarchive.InitialDirectory = "c:\\";
            OpenFolderToUnarchive.Filter = "Folders|\n";
            OpenFolderToUnarchive.AddExtension = false;
            OpenFolderToUnarchive.CheckFileExists = false;
            OpenFolderToUnarchive.DereferenceLinks = true;
            OpenFolderToUnarchive.Multiselect = false;
        }

        public void StartExctraction()
        {
            string fileToUnarchiveLocation = chooseFileToUnarchiveBox.Text;
            if (!string.IsNullOrEmpty(fileToUnarchiveLocation))
            {
                if (string.IsNullOrEmpty(chooseLocationToUnarchiveBox.Text))
                {
                    string[] fileItems = fileToUnarchiveLocation.Split('\\').SkipLast(1).ToArray();
                    foreach (string item in fileItems)
                        chooseLocationToUnarchiveBox.Text += item + '\\';
                    string locationToSave = chooseLocationToUnarchiveBox.Text;
                    chooseLocationToUnarchiveBox.Text = locationToSave.Remove(locationToSave.Length - 1);
                }

                for (int i = MainProgressBar.Minimum; i <= MainProgressBar.Maximum; i++)
                {
                    MainProgressBar.Value = i;
                    Thread.Sleep(10);
                }

                try
                {
                    // get extenstion of file and call right method
                    string ext = Path.GetExtension(chooseFileToUnarchiveBox.Text);
                    switch(ext)
                    {
                        case "rar":
                            RAR.Unrar(@"D:\data", $@"{fileToUnarchiveLocation}");
                            break;
                        case "zip":
                            ZipFile.ExtractToDirectory(chooseFileToUnarchiveBox.Text, chooseLocationToUnarchiveBox.Text);
                            break;
                        case "iso":
                            ISO.Extract(chooseFileToUnarchiveBox.Text, chooseLocationToUnarchiveBox.Text);
                            break;
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Something went wrong with your file. Please try again!");
                }

                string fileName = Path.GetFileName(chooseFileToUnarchiveBox.Text);

                MainProgressBar.Value = MainProgressBar.Minimum;
                MessageBox.Show($"{fileName} has been extracted successfully!");
            }
            else
            {
                MessageBox.Show("Plesae select file to unarchive!");
            }
        }

        private void button1_Click(object sender, EventArgs e) => StartExctraction();
        private void extractToolStripMenuItem_Click(object sender, EventArgs e) => StartExctraction();


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainSaveFileDialog.ShowDialog();
        }

        private void ArchiveFileSelection_Click(object sender, EventArgs e)
        {
            if(MainOpenFileDialog.ShowDialog() == DialogResult.OK)
                chooseFileToUnarchiveBox.Text = MainOpenFileDialog.FileName;   
        }

        private void LocationToUnarchiveButton_Click(object sender, EventArgs e)
        {

            if (OpenFolderToUnarchive.ShowDialog() == DialogResult.OK)
                chooseLocationToUnarchiveBox.Text = MainOpenFileDialog.FileName;
        }

    }
}