using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderMaker
{
    public partial class FolderMaker : Form
    {
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
                TB_FileDestination.Text = folder.SelectedPath;
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
    }
}
