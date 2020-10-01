namespace Vanilla_Encryption_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateKeys = new System.Windows.Forms.Button();
            this.btnExportPubKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbJPG = new System.Windows.Forms.RadioButton();
            this.rbPNG = new System.Windows.Forms.RadioButton();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.rbDocx = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportPublic = new System.Windows.Forms.Button();
            this.btnGetPrivate = new System.Windows.Forms.Button();
            this.rbMP3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCreateKeys
            // 
            this.btnCreateKeys.Location = new System.Drawing.Point(445, 34);
            this.btnCreateKeys.Name = "btnCreateKeys";
            this.btnCreateKeys.Size = new System.Drawing.Size(175, 54);
            this.btnCreateKeys.TabIndex = 0;
            this.btnCreateKeys.Text = "Create Keys";
            this.btnCreateKeys.UseVisualStyleBackColor = true;
            this.btnCreateKeys.Click += new System.EventHandler(this.BtnCreateKeys_Click);
            // 
            // btnExportPubKey
            // 
            this.btnExportPubKey.Location = new System.Drawing.Point(445, 112);
            this.btnExportPubKey.Name = "btnExportPubKey";
            this.btnExportPubKey.Size = new System.Drawing.Size(175, 54);
            this.btnExportPubKey.TabIndex = 1;
            this.btnExportPubKey.Text = "Export Public Key";
            this.btnExportPubKey.UseVisualStyleBackColor = true;
            this.btnExportPubKey.Click += new System.EventHandler(this.BtnExportPubKey_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(445, 191);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(175, 54);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt File";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(445, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(175, 54);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt File";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select file type to encrypt:";
            // 
            // rbJPG
            // 
            this.rbJPG.AutoSize = true;
            this.rbJPG.Location = new System.Drawing.Point(27, 88);
            this.rbJPG.Name = "rbJPG";
            this.rbJPG.Size = new System.Drawing.Size(84, 17);
            this.rbJPG.TabIndex = 6;
            this.rbJPG.TabStop = true;
            this.rbJPG.Text = "JPEG Image";
            this.rbJPG.UseVisualStyleBackColor = true;
            // 
            // rbPNG
            // 
            this.rbPNG.AutoSize = true;
            this.rbPNG.Location = new System.Drawing.Point(27, 131);
            this.rbPNG.Name = "rbPNG";
            this.rbPNG.Size = new System.Drawing.Size(80, 17);
            this.rbPNG.TabIndex = 7;
            this.rbPNG.TabStop = true;
            this.rbPNG.Text = "PNG Image";
            this.rbPNG.UseVisualStyleBackColor = true;
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Location = new System.Drawing.Point(27, 173);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(65, 17);
            this.rbTxt.TabIndex = 8;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = "Text File";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // rbDocx
            // 
            this.rbDocx.AutoSize = true;
            this.rbDocx.Location = new System.Drawing.Point(27, 210);
            this.rbDocx.Name = "rbDocx";
            this.rbDocx.Size = new System.Drawing.Size(103, 17);
            this.rbDocx.TabIndex = 9;
            this.rbDocx.TabStop = true;
            this.rbDocx.Text = "Word Document";
            this.rbDocx.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(27, 254);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(65, 17);
            this.rbPDF.TabIndex = 10;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "PDF File";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(27, 290);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(70, 17);
            this.rbExcel.TabIndex = 11;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel File";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnImportPublic
            // 
            this.btnImportPublic.Location = new System.Drawing.Point(445, 352);
            this.btnImportPublic.Name = "btnImportPublic";
            this.btnImportPublic.Size = new System.Drawing.Size(175, 54);
            this.btnImportPublic.TabIndex = 12;
            this.btnImportPublic.Text = "Import Public Key";
            this.btnImportPublic.UseVisualStyleBackColor = true;
            this.btnImportPublic.Visible = false;
            this.btnImportPublic.Click += new System.EventHandler(this.BtnImportPublic_Click);
            // 
            // btnGetPrivate
            // 
            this.btnGetPrivate.Location = new System.Drawing.Point(445, 432);
            this.btnGetPrivate.Name = "btnGetPrivate";
            this.btnGetPrivate.Size = new System.Drawing.Size(175, 54);
            this.btnGetPrivate.TabIndex = 13;
            this.btnGetPrivate.Text = "Get Private Key";
            this.btnGetPrivate.UseVisualStyleBackColor = true;
            this.btnGetPrivate.Visible = false;
            this.btnGetPrivate.Click += new System.EventHandler(this.BtnGetPrivate_Click);
            // 
            // rbMP3
            // 
            this.rbMP3.AutoSize = true;
            this.rbMP3.Location = new System.Drawing.Point(27, 324);
            this.rbMP3.Name = "rbMP3";
            this.rbMP3.Size = new System.Drawing.Size(96, 17);
            this.rbMP3.TabIndex = 14;
            this.rbMP3.TabStop = true;
            this.rbMP3.Text = "MP3 Audio File";
            this.rbMP3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 501);
            this.Controls.Add(this.rbMP3);
            this.Controls.Add(this.btnGetPrivate);
            this.Controls.Add(this.btnImportPublic);
            this.Controls.Add(this.rbExcel);
            this.Controls.Add(this.rbPDF);
            this.Controls.Add(this.rbDocx);
            this.Controls.Add(this.rbTxt);
            this.Controls.Add(this.rbPNG);
            this.Controls.Add(this.rbJPG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnExportPubKey);
            this.Controls.Add(this.btnCreateKeys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateKeys;
        private System.Windows.Forms.Button btnExportPubKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbJPG;
        private System.Windows.Forms.RadioButton rbPNG;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.RadioButton rbDocx;
        private System.Windows.Forms.RadioButton rbPDF;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnImportPublic;
        private System.Windows.Forms.Button btnGetPrivate;
        private System.Windows.Forms.RadioButton rbMP3;
    }
}

