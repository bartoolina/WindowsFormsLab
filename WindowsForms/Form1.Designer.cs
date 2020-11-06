namespace WindowsForms
{
    partial class Form1
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
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.btnOpenDir1 = new System.Windows.Forms.Button();
            this.btnTreeDir1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(138, 65);
            this.btnOpenFile1.TabIndex = 0;
            this.btnOpenFile1.Text = "Otwórz plik...";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // btnOpenDir1
            // 
            this.btnOpenDir1.Location = new System.Drawing.Point(156, 12);
            this.btnOpenDir1.Name = "btnOpenDir1";
            this.btnOpenDir1.Size = new System.Drawing.Size(138, 65);
            this.btnOpenDir1.TabIndex = 0;
            this.btnOpenDir1.Text = "Otwórz katalog...";
            this.btnOpenDir1.UseVisualStyleBackColor = true;
            this.btnOpenDir1.Click += new System.EventHandler(this.btnOpenDir1_Click);
            // 
            // btnTreeDir1
            // 
            this.btnTreeDir1.Location = new System.Drawing.Point(300, 12);
            this.btnTreeDir1.Name = "btnTreeDir1";
            this.btnTreeDir1.Size = new System.Drawing.Size(138, 65);
            this.btnTreeDir1.TabIndex = 0;
            this.btnTreeDir1.Text = "Otwórz drzewo...";
            this.btnTreeDir1.UseVisualStyleBackColor = true;
            this.btnTreeDir1.Click += new System.EventHandler(this.btnTreeDir1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTreeDir1);
            this.Controls.Add(this.btnOpenDir1);
            this.Controls.Add(this.btnOpenFile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Button btnOpenDir1;
        private System.Windows.Forms.Button btnTreeDir1;
    }
}

