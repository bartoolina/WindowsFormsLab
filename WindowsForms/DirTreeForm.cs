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
    public partial class DirTreeForm : Form
    {
        public DirTreeForm()
        {
            InitializeComponent();
        }

        public void ShowTree(string dirPath)
        {
            var directoryInfo = new DirectoryInfo(dirPath);
         
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                TreeNode node = new TreeNode(dir.Name);
                node.Tag = dir.FullName;
                treeView1.Nodes.Add(node);
                node.Nodes.Add(new TreeNode("empty"));
            }

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if ((e.Node.Nodes.Count == 1) && (e.Node.Nodes[0].Text == "empty"))
            {
                RecursiveDirWalk(e.Node);
            }

        }


        private TreeNode RecursiveDirWalk(TreeNode node)
        {
            string path = (string)node.Tag;
            node.Nodes.Clear();

            var directoryInfo = new DirectoryInfo(path);
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                TreeNode newDir = new TreeNode(dir.Name);
                newDir.Tag = dir.FullName;
                node.Nodes.Add(newDir);
                newDir.Nodes.Add(new TreeNode("empty"));
            }

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                TreeNode newFile = new TreeNode(file.Name);
                newFile.Tag = file.FullName;
                node.Nodes.Add(newFile);
            }

            return node;
        }
    }
}
