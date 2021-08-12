namespace PDF_Sample
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPDF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersionNumber = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWatermark = new System.Windows.Forms.TextBox();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.rbMagenta = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.rbFront = new System.Windows.Forms.RadioButton();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(412, 573);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(110, 35);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "&Watermark";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(15, 48);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(358, 76);
            this.txtFilePath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // lblVersionNumber
            // 
            this.lblVersionNumber.AutoSize = true;
            this.lblVersionNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionNumber.Location = new System.Drawing.Point(26, 680);
            this.lblVersionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersionNumber.Name = "lblVersionNumber";
            this.lblVersionNumber.Size = new System.Drawing.Size(45, 13);
            this.lblVersionNumber.TabIndex = 1;
            this.lblVersionNumber.Text = "Version";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBrowse.Location = new System.Drawing.Point(14, 132);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 35);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(412, 615);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Watermark PDF Document";
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpen.Location = new System.Drawing.Point(417, 160);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(94, 24);
            this.chkOpen.TabIndex = 3;
            this.chkOpen.Text = "Open PDF";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtWatermark);
            this.groupBox2.Controls.Add(this.rbOrange);
            this.groupBox2.Controls.Add(this.rbMagenta);
            this.groupBox2.Controls.Add(this.rbBlack);
            this.groupBox2.Controls.Add(this.rbRed);
            this.groupBox2.Controls.Add(this.rbBlue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 423);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watermark";
            // 
            // txtWatermark
            // 
            this.txtWatermark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWatermark.Location = new System.Drawing.Point(13, 42);
            this.txtWatermark.Multiline = true;
            this.txtWatermark.Name = "txtWatermark";
            this.txtWatermark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWatermark.Size = new System.Drawing.Size(360, 338);
            this.txtWatermark.TabIndex = 7;
            this.txtWatermark.Text = "Issued From: - RADIAN H.A. Limited\r\nIssued To: - \r\nInvoice Date: - \r\nInvoice No.:" +
    " - \r\nPO No.: - \r\nDN No.: - \r\n";
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(76, 396);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(76, 24);
            this.rbOrange.TabIndex = 6;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            // 
            // rbMagenta
            // 
            this.rbMagenta.AutoSize = true;
            this.rbMagenta.Location = new System.Drawing.Point(287, 396);
            this.rbMagenta.Name = "rbMagenta";
            this.rbMagenta.Size = new System.Drawing.Size(86, 24);
            this.rbMagenta.TabIndex = 6;
            this.rbMagenta.TabStop = true;
            this.rbMagenta.Text = "Magenta";
            this.rbMagenta.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(224, 396);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(62, 24);
            this.rbBlack.TabIndex = 6;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(13, 396);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(53, 24);
            this.rbRed.TabIndex = 6;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(160, 396);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(56, 24);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBack);
            this.groupBox3.Controls.Add(this.rbFront);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(417, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select File";
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Location = new System.Drawing.Point(6, 53);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(58, 24);
            this.rbBack.TabIndex = 6;
            this.rbBack.TabStop = true;
            this.rbBack.Text = "Back";
            this.rbBack.UseVisualStyleBackColor = true;
            // 
            // rbFront
            // 
            this.rbFront.AutoSize = true;
            this.rbFront.Location = new System.Drawing.Point(6, 26);
            this.rbFront.Name = "rbFront";
            this.rbFront.Size = new System.Drawing.Size(61, 24);
            this.rbFront.TabIndex = 6;
            this.rbFront.TabStop = true;
            this.rbFront.Text = "Front";
            this.rbFront.UseVisualStyleBackColor = true;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFolder.Location = new System.Drawing.Point(412, 530);
            this.btnCreateFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(110, 35);
            this.btnCreateFolder.TabIndex = 7;
            this.btnCreateFolder.Text = "&Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = false;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 702);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVersionNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPDF);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark PDF";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersionNumber;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.RadioButton rbMagenta;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBack;
        private System.Windows.Forms.RadioButton rbFront;
        private System.Windows.Forms.TextBox txtWatermark;
        private System.Windows.Forms.Button btnCreateFolder;
    }
}

