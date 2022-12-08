using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftTwat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the initial value of the folder text box
            folderTextBox1.Text = @"C:\";
        }
        private void listButton_Click_1(object sender, EventArgs e)
        {
            // Get the directories specified by the user
            List<string> directories = new List<string>();
            if (!string.IsNullOrEmpty(folderTextBox1.Text))
            {
                directories.Add(folderTextBox1.Text);
            }
            if (!string.IsNullOrEmpty(folderTextBox2.Text))
            {
                directories.Add(folderTextBox2.Text);
            }
            if (!string.IsNullOrEmpty(folderTextBox3.Text))
            {
                directories.Add(folderTextBox3.Text);
            }

            // Get a list of the names of all the folders in the directories
            List<string> folders = new List<string>();
            foreach (string directory in directories)
            {
                folders.AddRange(Directory.GetDirectories(directory));
            }
            // Alphabetize the list of folder names
            folders.Sort();

            // Show the "Save File" dialog
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the folder path from the text box
                    // string folder = folderTextBox1.Text;

                    // Get a list of all the folders in the specified folder
                    //string[] folderNames = Directory.GetDirectories(folder);

                    // Write the list of folder names to a text file
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        foreach (string folderName in folders)
                        {
                            writer.WriteLine(Path.GetFileName(folderName));
                        }
                    }

                    MessageBox.Show("Folder names written to " + saveDialog.FileName);
                }
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (compareButton.Enabled == false)
            {
                // Do not execute the method again
                return;
            }

            // Disable the "Compare" button to prevent multiple executions
            compareButton.Enabled = false;

            // Show the "Open File" dialog
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.Multiselect = true;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the contents of the selected files
                    List<string[]> linesList = new List<string[]>();
                    foreach (string fileName in openDialog.FileNames)
                    {
                        linesList.Add(File.ReadAllLines(fileName));
                    }
                    List<string> matchingLines = new List<string>();
                    HashSet<string> matchingLinesSet = new HashSet<string>();
                    bool match = true;
                    foreach (string[] lines in linesList)
                    {
                        foreach (string line in lines)
                        {
                            match = true;
                            foreach (string[] otherLines in linesList)
                            {
                                if (!Array.Exists(otherLines, element => element == line))
                                {
                                    match = false;
                                    break;
                                }
                            }

                            if (match && !matchingLinesSet.Contains(line))
                            {
                                matchingLines.Add(line);
                                matchingLinesSet.Add(line);
                            }
                        }

                        // Show the "Save File" dialog
                        using (SaveFileDialog saveDialog = new SaveFileDialog())
                        {
                            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                            saveDialog.FilterIndex = 1;
                            saveDialog.RestoreDirectory = true;

                            if (saveDialog.ShowDialog() == DialogResult.OK)
                            {
                                // Write the list of matching lines to the selected file
                                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                                {
                                    foreach (string matchingLine in matchingLines)
                                    {
                                        writer.WriteLine(matchingLine);
                                    }
                                }

                                MessageBox.Show("Matching lines written to " + saveDialog.FileName);

                            }

                        }
                    }
                    compareButton.Enabled = true;
                }
            }
        }
        private void combineButton_Click_1(object sender, EventArgs e)
        {
            // Show the "Open File" dialog
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.Multiselect = true;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the contents of the selected files
                    List<string> lines = new List<string>();
                    foreach (string fileName in openDialog.FileNames)
                    {
                        lines.AddRange(File.ReadAllLines(fileName));
                    }
                    // Remove duplicate lines
                    HashSet<string> linesSet = new HashSet<string>(lines);
                    lines = new List<string>(linesSet);
                    // Sort the lines alphabetically
                    lines.Sort();

                    // Show the "Save File" dialog
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveDialog.FilterIndex = 1;
                        saveDialog.RestoreDirectory = true;

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Write the combined and alphabetized lines to the selected file
                            using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                            {
                                foreach (string line in lines)
                                {
                                    writer.WriteLine(line);
                                }
                            }

                            MessageBox.Show("Combined and alphabetized lines written to " + saveDialog.FileName);
                        }
                    }
                }
            }
        }
    }
}