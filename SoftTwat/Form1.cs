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
        // Member variable to hold the "Select Folder" dialog
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        public MainForm()
        {
            InitializeComponent();
            // Set the default directory for the "Select Folder" dialog
            folderBrowserDialog.SelectedPath = @"C:\";
            // Add the predefined paths and their aliases to the drop-down menus
            folderComboBox1.Items.Add(@"C:\Program Files (x86)\Steam\steamapps\common");
            folderComboBox1.Items.Add(@"C:\Program Files\Epic Games");
            folderComboBox1.Items.Add(@"C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher\games\");
            folderComboBox2.Items.Add(@"C:\Program Files (x86)\Steam\steamapps\common");
            folderComboBox2.Items.Add(@"C:\Program Files\Epic Games");
            folderComboBox2.Items.Add(@"C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher\games");
            folderComboBox3.Items.Add(@"C:\Program Files (x86)\Steam\steamapps\common");
            folderComboBox3.Items.Add(@"C:\Program Files\Epic Games");
            folderComboBox3.Items.Add(@"C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher\games\");
            // Set the default selected items in the drop-down menus
            folderComboBox1.SelectedIndex = -1;
            folderComboBox2.SelectedIndex = -1;
            folderComboBox3.SelectedIndex = -1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the initial value of the folder text box
            //folderComboBox1.Text = @"C:\";
        }
       
        private void listButton_Click_1(object sender, EventArgs e)
        {
            // Get the directories specified by the user
            List<string> directories = new List<string>();
            if (folderComboBox1.SelectedItem != null)
            {
                directories.Add(folderComboBox1.SelectedItem.ToString());
            }
            if (folderComboBox2.SelectedItem != null)
            {
                directories.Add(folderComboBox2.SelectedItem.ToString());
            }
            if (folderComboBox3.SelectedItem != null)
            {
                directories.Add(folderComboBox3.SelectedItem.ToString());
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
                saveDialog.DefaultFileName = "mygames.txt";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the folder path from the text box
                    // string folder = folderComboBox1.Text;

                    // Get a list of all the folders in the specified folder
                    //string[] folderNames = Directory.GetDirectories(folder);

                    // Write the list of folder names to a text file
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        // Iterate over the directories specified by the user
                        foreach (string directory in directories)
                        {
                            // Get the list of directories in the current directory
                            string[] subdirectories = Directory.GetDirectories(directory);

                            // Iterate over the directories in the current directory
                            foreach (string subdirectory in subdirectories)
                            {
                                // Check if the user selected the Show Aliases radio button
                                if (showAliasesCheckBox.Checked)
                                {
                                    // Get the name of the current folder
                                    string folderName = Path.GetFileName(subdirectory);

                                    // Get the PathItem object for the current subdirectory from the first ComboBox
                                    PathItem pathItem = folderComboBox1.Items.OfType<PathItem>().FirstOrDefault(x => x.Path == subdirectory);

                                    // If the PathItem object was not found in the first ComboBox, try the second ComboBox
                                    if (pathItem == null)
                                    {
                                        pathItem = folderComboBox2.Items.OfType<PathItem>().FirstOrDefault(x => x.Path == subdirectory);
                                    }

                                    // If the PathItem object was not found in the second ComboBox, try the third ComboBox
                                    if (pathItem == null)
                                    {
                                        pathItem = folderComboBox3.Items.OfType<PathItem>().FirstOrDefault(x => x.Path == subdirectory);
                                    }

                                    // Write the folder name and its alias to the output file
                                    if (!string.IsNullOrEmpty(pathItem?.Alias))
                                    {
                                        writer.WriteLine($"{folderName} ({pathItem?.Alias})");
                                    }
                                    else
                                    {
                                        writer.WriteLine(folderName);
                                    }
                                }
                                else
                                {
                                    // Write the folder name to the output file
                                    writer.WriteLine(Path.GetFileName(subdirectory));
                                }
                            }
                        }
                    }

                }

                MessageBox.Show("Folder names written to " + saveDialog.FileName);
            }
        }

        private void selectFolderButton1_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new PathItem object for the selected folder
               /* PathItem pathItem = folderBrowserDialog.SelectedPath)
                {
                    Alias = "My Folder", // Set the default alias to "My Folder"
                };*/

                // Add the PathItem object to the first ComboBox
                folderComboBox1.Items.Add(folderBrowserDialog.SelectedPath);

                // Select the added PathItem object in the first ComboBox
                folderComboBox1.SelectedItem = folderBrowserDialog.SelectedPath;
            }
        }
        private void selectFolderButton2_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new PathItem object for the selected folder
                /*PathItem pathItem = folderBrowserDialog.SelectedPath)
                {
                    Alias = "My Folder", // Set the default alias to "My Folder"
                };
                */
                // Add the PathItem object to the first ComboBox
                folderComboBox2.Items.Add(folderBrowserDialog.SelectedPath);

                // Select the added PathItem object in the first ComboBox
                folderComboBox2.SelectedItem = folderBrowserDialog.SelectedPath;
            }
        }
        private void selectFolderButton3_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new PathItem object for the selected folder
                /*PathItem pathItem = folderBrowserDialog.SelectedPath)
                {
                    Alias = "My Folder", // Set the default alias to "My Folder"
                };*/

                // Add the PathItem object to the first ComboBox
                folderComboBox3.Items.Add(folderBrowserDialog.SelectedPath);

                // Select the added PathItem object in the first ComboBox
                folderComboBox3.SelectedItem = folderBrowserDialog.SelectedPath;
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
                            saveDialog.DefaultFileName = "ourgames.txt";

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
                        saveDialog.DefaultFileName = "mygames.txt";

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
