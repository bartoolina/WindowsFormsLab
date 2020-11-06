namespace WindowsForms
{
    partial class FileInfoForm
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
            this.lblFilePath1 = new System.Windows.Forms.Label();
            this.lblFilePathInfo1 = new System.Windows.Forms.Label();
            this.lblFileName1 = new System.Windows.Forms.Label();
            this.lblFileNameInfo1 = new System.Windows.Forms.Label();
            this.lblFileDateMod1 = new System.Windows.Forms.Label();
            this.lblFileDateModInfo1 = new System.Windows.Forms.Label();
            this.lblFileDateRead1 = new System.Windows.Forms.Label();
            this.lblFileDateReadInfo = new System.Windows.Forms.Label();
            this.lblFileSize1 = new System.Windows.Forms.Label();
            this.lblFileSizeInfo1 = new System.Windows.Forms.Label();
            this.btnFileCopy1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilePath1
            // 
            this.lblFilePath1.AutoSize = true;
            this.lblFilePath1.Location = new System.Drawing.Point(12, 9);
            this.lblFilePath1.Name = "lblFilePath1";
            this.lblFilePath1.Size = new System.Drawing.Size(101, 17);
            this.lblFilePath1.TabIndex = 0;
            this.lblFilePath1.Text = "Ścieszka pliku:";
            // 
            // lblFilePathInfo1
            // 
            this.lblFilePathInfo1.AutoSize = true;
            this.lblFilePathInfo1.Location = new System.Drawing.Point(147, 9);
            this.lblFilePathInfo1.Name = "lblFilePathInfo1";
            this.lblFilePathInfo1.Size = new System.Drawing.Size(0, 17);
            this.lblFilePathInfo1.TabIndex = 0;
            // 
            // lblFileName1
            // 
            this.lblFileName1.AutoSize = true;
            this.lblFileName1.Location = new System.Drawing.Point(12, 26);
            this.lblFileName1.Name = "lblFileName1";
            this.lblFileName1.Size = new System.Drawing.Size(87, 17);
            this.lblFileName1.TabIndex = 0;
            this.lblFileName1.Text = "Nazwa pliku:";
            // 
            // lblFileNameInfo1
            // 
            this.lblFileNameInfo1.AutoSize = true;
            this.lblFileNameInfo1.Location = new System.Drawing.Point(147, 26);
            this.lblFileNameInfo1.Name = "lblFileNameInfo1";
            this.lblFileNameInfo1.Size = new System.Drawing.Size(0, 17);
            this.lblFileNameInfo1.TabIndex = 0;
            // 
            // lblFileDateMod1
            // 
            this.lblFileDateMod1.AutoSize = true;
            this.lblFileDateMod1.Location = new System.Drawing.Point(12, 43);
            this.lblFileDateMod1.Name = "lblFileDateMod1";
            this.lblFileDateMod1.Size = new System.Drawing.Size(115, 17);
            this.lblFileDateMod1.TabIndex = 0;
            this.lblFileDateMod1.Text = "Data modyfikacji:";
            // 
            // lblFileDateModInfo1
            // 
            this.lblFileDateModInfo1.AutoSize = true;
            this.lblFileDateModInfo1.Location = new System.Drawing.Point(147, 43);
            this.lblFileDateModInfo1.Name = "lblFileDateModInfo1";
            this.lblFileDateModInfo1.Size = new System.Drawing.Size(0, 17);
            this.lblFileDateModInfo1.TabIndex = 0;
            // 
            // lblFileDateRead1
            // 
            this.lblFileDateRead1.AutoSize = true;
            this.lblFileDateRead1.Location = new System.Drawing.Point(12, 60);
            this.lblFileDateRead1.Name = "lblFileDateRead1";
            this.lblFileDateRead1.Size = new System.Drawing.Size(95, 17);
            this.lblFileDateRead1.TabIndex = 0;
            this.lblFileDateRead1.Text = "Data odczytu:";
            // 
            // lblFileDateReadInfo
            // 
            this.lblFileDateReadInfo.AutoSize = true;
            this.lblFileDateReadInfo.Location = new System.Drawing.Point(147, 60);
            this.lblFileDateReadInfo.Name = "lblFileDateReadInfo";
            this.lblFileDateReadInfo.Size = new System.Drawing.Size(0, 17);
            this.lblFileDateReadInfo.TabIndex = 0;
            // 
            // lblFileSize1
            // 
            this.lblFileSize1.AutoSize = true;
            this.lblFileSize1.Location = new System.Drawing.Point(12, 77);
            this.lblFileSize1.Name = "lblFileSize1";
            this.lblFileSize1.Size = new System.Drawing.Size(97, 17);
            this.lblFileSize1.TabIndex = 0;
            this.lblFileSize1.Text = "Rozmiar pliku:";
            // 
            // lblFileSizeInfo1
            // 
            this.lblFileSizeInfo1.AutoSize = true;
            this.lblFileSizeInfo1.Location = new System.Drawing.Point(147, 77);
            this.lblFileSizeInfo1.Name = "lblFileSizeInfo1";
            this.lblFileSizeInfo1.Size = new System.Drawing.Size(0, 17);
            this.lblFileSizeInfo1.TabIndex = 0;
            // 
            // btnFileCopy1
            // 
            this.btnFileCopy1.Location = new System.Drawing.Point(622, 12);
            this.btnFileCopy1.Name = "btnFileCopy1";
            this.btnFileCopy1.Size = new System.Drawing.Size(139, 88);
            this.btnFileCopy1.TabIndex = 1;
            this.btnFileCopy1.Text = "Skpiuj plik";
            this.btnFileCopy1.UseVisualStyleBackColor = true;
            this.btnFileCopy1.Click += new System.EventHandler(this.btnFileCopy1_Click);
            // 
            // FileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 112);
            this.Controls.Add(this.btnFileCopy1);
            this.Controls.Add(this.lblFileSizeInfo1);
            this.Controls.Add(this.lblFileDateReadInfo);
            this.Controls.Add(this.lblFileDateModInfo1);
            this.Controls.Add(this.lblFileNameInfo1);
            this.Controls.Add(this.lblFileSize1);
            this.Controls.Add(this.lblFileDateRead1);
            this.Controls.Add(this.lblFilePathInfo1);
            this.Controls.Add(this.lblFileDateMod1);
            this.Controls.Add(this.lblFileName1);
            this.Controls.Add(this.lblFilePath1);
            this.Name = "FileInfoForm";
            this.Text = "FileInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath1;
        private System.Windows.Forms.Label lblFilePathInfo1;
        private System.Windows.Forms.Label lblFileName1;
        private System.Windows.Forms.Label lblFileNameInfo1;
        private System.Windows.Forms.Label lblFileDateMod1;
        private System.Windows.Forms.Label lblFileDateModInfo1;
        private System.Windows.Forms.Label lblFileDateRead1;
        private System.Windows.Forms.Label lblFileDateReadInfo;
        private System.Windows.Forms.Label lblFileSize1;
        private System.Windows.Forms.Label lblFileSizeInfo1;
        private System.Windows.Forms.Button btnFileCopy1;
    }
}