using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderMaker
{
    public partial class FolderMaker : Form
    {
        public string folderPath = null;
        public string folderName = null;
        FolderBrowserDialog folder;
        public FolderMaker()
        {
            InitializeComponent();
            folder = new FolderBrowserDialog();
        }

        private void BTN_FindLocation_Click(object sender, EventArgs e)
        {
             DialogResult result = folder.ShowDialog();
            if(result == DialogResult.OK)
            {
                folderPath = folder.SelectedPath;
                TB_FileDestination.Text = folderPath;
            }
        }

        private void CB_SubFolders_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_SubFolders.Checked)
            {
                GB_SubFolders.Enabled = true;
            }
            else
            {
                GB_SubFolders.Enabled = false;
            }
        }
        private void BTN_CreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderPath == null)
                {
                    MessageBox.Show("Please select a folder location first.");
                    return;
                }

                folderName = TB_FolderName.Text;
                string newFolder = folderPath + "\\" + folderName;

                int fa = int.Parse(TB_FolderAmount.Text);

                if (fa > 1)
                {
                    for (int i = 1; i <= fa; i++)
                    {
                        newFolder = folderPath + "\\" + folderName + " (" + i + ")";
                        if (!Directory.Exists(newFolder))
                        {
                            Directory.CreateDirectory(newFolder);
                        }
                        else
                        {
                            MessageBox.Show("Folder already exists at this location.");
                            return;
                        }
                    }
                }
                else
                {
                    newFolder = folderPath + "\\" + folderName;
                    if (!Directory.Exists(newFolder))
                    {
                        Directory.CreateDirectory(newFolder);
                    }
                    else
                    {
                        MessageBox.Show("Folder already exists at this location.");
                        return;
                    }
                }
               

                if(fa == 1) 
                {
                    MessageBox.Show("Folder created successfully!");
                }
                else
                {
                    MessageBox.Show("All Folders created successfully!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while creating the folders.");
            }
            

        }

        private void FolderMaker_Load(object sender, EventArgs e)
        {
            TB_FolderName.Text = "New Folder";
            TB_SubFolderName.Text = "New Sub-Folder";
            TB_FolderAmount.Text = "1";
        }

       
    }
}
