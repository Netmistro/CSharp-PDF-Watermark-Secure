using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDF_Sample
{
    public partial class frmNewFoler : Form
    {
        public frmNewFoler()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMain f1 = new frmMain();
            f1.Show();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            try
            {
                String myDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String filePath = myDesktop + "\\" + txtFolderName.Text;

                // Determine whether the directory exists.
                if (Directory.Exists(filePath))
                {
                    DialogResult dialogResult = MessageBox.Show("The Directory Already Exists", "Failure", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK) 
                    {

                        this.Hide();
                        frmMain f1 = new frmMain();
                        f1.Show();
                    }
                    
                }
                else
                {

                    // Try to create the directory.
                    DirectoryInfo myFolder = Directory.CreateDirectory(filePath);
                    DialogResult dialogResult = MessageBox.Show("The directory was created successfully", "Success", MessageBoxButtons.OK);

                    if (dialogResult == DialogResult.OK)
                    {
                        this.Hide();
                        frmMain f1 = new frmMain();
                        f1.Show();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("The process failed: {0}", ex.ToString());

            }

        }
    }
}
