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
    public partial class FileInfoForm : Form
    {
        string _filePath;
        public FileInfoForm()
        {
            InitializeComponent();
        }

        public void ShowFileInfo(string filePath)
        {
            _filePath = filePath;
            // nazwę, ścieżkę, datę ostatniego zapisu,datę ostatniego odczytu,rozmiar pliku
            var fileInfo = new FileInfo(filePath);
            lblFilePathInfo1.Text = fileInfo.FullName;
            lblFileNameInfo1.Text = fileInfo.Name;
            lblFileDateModInfo1.Text = fileInfo.LastWriteTime.ToString();
            lblFileDateReadInfo.Text = fileInfo.LastAccessTime.ToString();
            lblFileSizeInfo1.Text = fileInfo.Length.ToString();
        }

        private void btnFileCopy1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(_filePath, saveFileDialog.FileName, true);
            }
        }
    }
}
