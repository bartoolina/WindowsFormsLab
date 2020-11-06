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

namespace WindowsForms
{
    public partial class DirInfoForm : Form
    {
        public DirInfoForm()
        {
            InitializeComponent();
        }


        public void ShowDirInfo(string dirPath)
        {
            var directoryInfo = new DirectoryInfo(dirPath);
            //nazwę, ścieżkę, datę ostatniej modyfikacji
            lblDirPathInfo1.Text =  directoryInfo.FullName;
            lblDirNameInfo1.Text = directoryInfo.Name;
            lblDirDateModInfo1.Text = directoryInfo.LastAccessTime.ToString();

            lbDirs.DisplayMember = "Name";

            
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                lbDirs.Items.Add(dir);
            }

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                lbDirs.Items.Add(file);
            }
            

        }

        private void lbDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lbDirs.SelectedItem;

            if (selectedItem is FileInfo)
            {
                //Console.WriteLine("jest plikiem");
                btn_OpenFile.Enabled = true;
                btn_OpenFolder.Enabled = false;
            }

            if (selectedItem is DirectoryInfo)
            {
                //Console.WriteLine("jest katalogiem");
                btn_OpenFile.Enabled = false;
                btn_OpenFolder.Enabled = true;
            }
            

        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            var selectedItem = (FileInfo)lbDirs.SelectedItem;
            OpenSaveFile.OpenFile(selectedItem.FullName);
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            var selectedItem = (DirectoryInfo) lbDirs.SelectedItem;
            OpenSaveFile.OpenFolder(selectedItem.FullName);
        }
    }
}
