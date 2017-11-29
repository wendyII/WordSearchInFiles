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


namespace WordSearchInFiles
{
    public partial class Form1 : Form
    {
        private bool searching = true;

        public Form1()
        {
            InitializeComponent();
            lstFilesFound.DoubleClick += new EventHandler(lstFilesFound_DoubleClick);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtSearchFolder.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lstFilesFound.Items.Clear();
            lstFilesNotFound.Items.Clear();

            if (btnSearch.Text == "Search")
            {
                if (string.IsNullOrEmpty(txtSearchWord.Text) && string.IsNullOrEmpty(txtSearchFolder.Text))
                {
                    lblErrorMessage.Text = "Please enter Search Word and Search Folder";
                    return;
                }

                //Start searching
                searching = true;
                //Allow user to cancel search
                btnSearch.Text = "Cancel";

                searchFolder(txtSearchFolder.Text);

                btnSearch.Text = "Search";
                lblErrorMessage.Text = "Search Complete";
            }
            else
            {
                searching = false;
                btnSearch.Text = "Search";
                lblErrorMessage.Text = "Search Cancelled..";
            }
        }

        private void searchFolder(string FolderName)
        {
            int lineNumber = 0;
            //Get Files
            string[] fileList = Directory.GetFiles(FolderName);
            //search each file

            foreach (string filename in fileList)
            {
                lineNumber = searchFile(filename);
                if (lineNumber > 0)
                {
                    lstFilesFound.Items.Add(filename + " Line " + lineNumber.ToString());
                }
                else
                {
                    lstFilesNotFound.Items.Add(filename);
                }
                Application.DoEvents();
            }

            if (searching == false)
            {
                return;
            }

            //Get Folders
            string[] folderList = Directory.GetDirectories(FolderName);

            foreach(string foldername in folderList)
            {
                searchFolder(foldername);
            }
        }
        

        private int searchFile(string Filename)
        {
            int lineNumber = 0;
            int lineCount = 0;

            try
            {
                StreamReader sr = new StreamReader(Filename);

                while (!sr.EndOfStream)
                {
                    string thisLine = sr.ReadLine();
                    lineCount++;

                    if (thisLine.ToLower().IndexOf(txtSearchWord.Text.ToLower()) > 0)
                    {
                        lineNumber = lineCount;
                        break;
                    }
                }

                sr.Close();
            }
            catch (Exception err)
            {
                lstFilesNotFound.Items.Add("Error: " + Filename + " " + err.ToString());
            }            

            return lineNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Search" && lstFilesFound.Items.Count > 0)
            {
                folderBrowserDialog1.ShowDialog();
                string saveToFolder = folderBrowserDialog1.SelectedPath;

                StreamWriter sw = new StreamWriter(saveToFolder + @"\WordSearch-" + txtSearchWord.Text + ".txt");

                sw.WriteLine("Searched For: " + txtSearchWord.Text);
                sw.WriteLine("Searched In: " + txtSearchFolder.Text);

                foreach(ListViewItem filename in lstFilesFound.Items)
                {
                    sw.WriteLine(filename.Text);
                }

                sw.Close();

                MessageBox.Show("File Saved");
            }
            else
            {
                MessageBox.Show("Cannot Save File at this time");
            }

        }

        void lstFilesFound_DoubleClick(object sender, EventArgs e)
        {
            if (lstFilesFound.SelectedItem != null)
            {
                string fileToOpen = lstFilesFound.SelectedItem.ToString().Substring(0, lstFilesFound.SelectedItem.ToString().IndexOf(" Line"));

                MessageBox.Show(fileToOpen);

                System.Diagnostics.Process.Start(fileToOpen);
            }
        }

    }
}
