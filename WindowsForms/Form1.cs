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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnOpenFile1_Click(object sender, EventArgs e)
        {
            OpenSaveFile.OpenFile();
        }

        public void btnOpenDir1_Click(object sender, EventArgs e)
        {
            OpenSaveFile.OpenFolder();
        }

        private void btnTreeDir1_Click(object sender, EventArgs e)
        {
            OpenSaveFile.OpenTree();
        }
    }
}
