
namespace PDF_Sample
{
    partial class frmNewFoler
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
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(12, 12);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(382, 27);
            this.txtFolderName.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(12, 83);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 35);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&Create";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(284, 83);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder Name ONLY";
            // 
            // frmNewFoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 131);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFolderName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewFoler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Folder Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}