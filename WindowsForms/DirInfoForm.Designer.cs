namespace WindowsForms
{
    partial class DirInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDirDateModInfo1 = new System.Windows.Forms.Label();
            this.lblDirNameInfo1 = new System.Windows.Forms.Label();
            this.lblDirPathInfo1 = new System.Windows.Forms.Label();
            this.lblDirDateMod1 = new System.Windows.Forms.Label();
            this.lblDirName1 = new System.Windows.Forms.Label();
            this.lblDirPath1 = new System.Windows.Forms.Label();
            this.lbDirs = new System.Windows.Forms.ListBox();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDirDateModInfo1
            // 
            this.lblDirDateModInfo1.AutoSize = true;
            this.lblDirDateModInfo1.Location = new System.Drawing.Point(147, 43);
            this.lblDirDateModInfo1.Name = "lblDirDateModInfo1";
            this.lblDirDateModInfo1.Size = new System.Drawing.Size(51, 17);
            this.lblDirDateModInfo1.TabIndex = 3;
            this.lblDirDateModInfo1.Text = "dsfgdg";
            // 
            // lblDirNameInfo1
            // 
            this.lblDirNameInfo1.AutoSize = true;
            this.lblDirNameInfo1.Location = new System.Drawing.Point(147, 26);
            this.lblDirNameInfo1.Name = "lblDirNameInfo1";
            this.lblDirNameInfo1.Size = new System.Drawing.Size(51, 17);
            this.lblDirNameInfo1.TabIndex = 4;
            this.lblDirNameInfo1.Text = "dsfgdg";
            // 
            // lblDirPathInfo1
            // 
            this.lblDirPathInfo1.AutoSize = true;
            this.lblDirPathInfo1.Location = new System.Drawing.Point(147, 9);
            this.lblDirPathInfo1.Name = "lblDirPathInfo1";
            this.lblDirPathInfo1.Size = new System.Drawing.Size(51, 17);
            this.lblDirPathInfo1.TabIndex = 7;
            this.lblDirPathInfo1.Text = "dsfgdg";
            // 
            // lblDirDateMod1
            // 
            this.lblDirDateMod1.AutoSize = true;
            this.lblDirDateMod1.Location = new System.Drawing.Point(12, 43);
            this.lblDirDateMod1.Name = "lblDirDateMod1";
            this.lblDirDateMod1.Size = new System.Drawing.Size(115, 17);
            this.lblDirDateMod1.TabIndex = 8;
            this.lblDirDateMod1.Text = "Data modyfikacji:";
            // 
            // lblDirName1
            // 
            this.lblDirName1.AutoSize = true;
            this.lblDirName1.Location = new System.Drawing.Point(12, 26);
            this.lblDirName1.Name = "lblDirName1";
            this.lblDirName1.Size = new System.Drawing.Size(112, 17);
            this.lblDirName1.TabIndex = 9;
            this.lblDirName1.Text = "Nazwa katalogu:";
            // 
            // lblDirPath1
            // 
            this.lblDirPath1.AutoSize = true;
            this.lblDirPath1.Location = new System.Drawing.Point(12, 9);
            this.lblDirPath1.Name = "lblDirPath1";
            this.lblDirPath1.Size = new System.Drawing.Size(118, 17);
            this.lblDirPath1.TabIndex = 10;
            this.lblDirPath1.Text = "Ścieszka katalgu:";
            // 
            // lbDirs
            // 
            this.lbDirs.FormattingEnabled = true;
            this.lbDirs.ItemHeight = 16;
            this.lbDirs.Location = new System.Drawing.Point(12, 63);
            this.lbDirs.Name = "lbDirs";
            this.lbDirs.Size = new System.Drawing.Size(436, 324);
            this.lbDirs.TabIndex = 11;
            this.lbDirs.SelectedIndexChanged += new System.EventHandler(this.lbDirs_SelectedIndexChanged);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.Location = new System.Drawing.Point(248, 393);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(200, 45);
            this.btn_OpenFolder.TabIndex = 12;
            this.btn_OpenFolder.Text = "Otwórz folder";
            this.btn_OpenFolder.UseVisualStyleBackColor = true;
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(12, 393);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(200, 45);
            this.btn_OpenFile.TabIndex = 12;
            this.btn_OpenFile.Text = "Otwórz plik";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // DirInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_OpenFolder);
            this.Controls.Add(this.lbDirs);
            this.Controls.Add(this.lblDirDateModInfo1);
            this.Controls.Add(this.lblDirNameInfo1);
            this.Controls.Add(this.lblDirPathInfo1);
            this.Controls.Add(this.lblDirDateMod1);
            this.Controls.Add(this.lblDirName1);
            this.Controls.Add(this.lblDirPath1);
            this.Name = "DirInfoForm";
            this.Text = "DirInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDirDateModInfo1;
        private System.Windows.Forms.Label lblDirNameInfo1;
        private System.Windows.Forms.Label lblDirPathInfo1;
        private System.Windows.Forms.Label lblDirDateMod1;
        private System.Windows.Forms.Label lblDirName1;
        private System.Windows.Forms.Label lblDirPath1;
        private System.Windows.Forms.ListBox lbDirs;
        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.Button btn_OpenFile;
    }
}