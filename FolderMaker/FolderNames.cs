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
    public partial class FolderNames : Form
    {
        private readonly FolderMaker fm;
        public string MFName;
        public string SFName;
        public FolderNames(FolderMaker FM)
        {
            InitializeComponent();
            fm = FM;
        }

        private void FolderNames_Load(object sender, EventArgs e)
        {
            TB_MainFolderName.Text = Path.GetFileName(fm.newFolder);
        }

       

        private void BTN_ChangeFolderName_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(fm.newFolder))
                {
                    Directory.Move(fm.newFolder, Path.Combine(fm.folderPath, TB_MainFolderName.Text));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("An error occurred while updating folder names.");
            }
        }

        private void BTN_Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
