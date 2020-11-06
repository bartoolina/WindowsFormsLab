using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    static class OpenSaveFile
    {
        public static void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;



                    OpenFile(filePath);


                }
            }
        }

        public static void OpenFile(string filePath)
        {
            FileInfoForm fileInfoForm = new FileInfoForm();
            fileInfoForm.ShowFileInfo(filePath);
            fileInfoForm.Show();
        }

        public static void OpenFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string dirPath = folderBrowserDialog.SelectedPath;
                OpenFolder(dirPath);
                
            }
        }

        public static void OpenFolder(string dirPath)
        {
            DirInfoForm dirInfoForm = new DirInfoForm();
            dirInfoForm.ShowDirInfo(dirPath);
            dirInfoForm.Show();
        }

        public static void OpenTree()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string dirPath = folderBrowserDialog.SelectedPath;
                OpenTree(dirPath);

            }

        }

        private static void OpenTree(string dirPath)
        {
            DirTreeForm dirTreeForm = new DirTreeForm();
            dirTreeForm.ShowTree(dirPath);
            dirTreeForm.Show();
        }
    }
}
