using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Internal;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;

namespace PDF_Sample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // Variation 1: Draw a watermark as a text string
            try
            {
                // Source File
                string sourceFile = txtFilePath.Text;

                // Take in pdf from the form
                PdfDocument document = PdfReader.Open(sourceFile);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

                // Watermark String text
                string watermark = txtWatermark.Text;

                for (int idx = 0; idx < document.Pages.Count; idx++)
                {
                    var page = document.Pages[idx];

                    // Get an XGraphics object for drawing beneath the existing content
                    var gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append);

                    // Get the size (in points) of the text
                    var size = gfx.MeasureString(watermark, font);

                    // Define a rotation transformation at the center of the page
                    gfx.TranslateTransform(page.Width / 2, page.Height / 2);
                    gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
                    gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);

                    // Create a string format
                    var format = new XStringFormat();
                    format.Alignment = XStringAlignment.Near;
                    format.LineAlignment = XLineAlignment.Near;

                    // Create a dimmed red brush
                    int redColor;
                    int greenColor;
                    int blueColor;

                    if (rbRed.Checked==true)
                    {
                        redColor = 255;
                        greenColor = 102;
                        blueColor = 102;
                    }else if (rbOrange.Checked == true)
                    {
                        redColor = 255;
                        greenColor = 204;
                        blueColor = 153;
                    }
                    else if(rbBlue.Checked==true)
                    {
                        redColor = 0;
                        greenColor = 128;
                        blueColor = 255;
                    }
                    else if (rbPurple.Checked == true)
                    {
                        redColor = 204;
                        greenColor = 153;
                        blueColor = 255;
                    }
                    else
                    {
                        redColor = 255;
                        greenColor = 153;
                        blueColor = 255;
                    }
                    XBrush brush = new XSolidBrush(XColor.FromArgb(0, redColor, greenColor, blueColor));

                    // Draw the string
                    gfx.DrawString(watermark, font, brush,
                    new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2), format);

                }

                PdfSecuritySettings ss = document.SecuritySettings;
                // Setting one of the passwords automatically sets the security level to
                // PdfDocumentSecurityLevel.Encrypted128Bit.
                ss.UserPassword = "";
                ss.OwnerPassword = "mHfb6A7Rwp&b^$z2";

                // Restrict some rights
                ss.PermitAccessibilityExtractContent = false;
                ss.PermitAnnotations = false;
                ss.PermitAssembleDocument = false;
                ss.PermitExtractContent = false;
                ss.PermitFormsFill = true;
                ss.PermitFullQualityPrint = true;
                ss.PermitModifyDocument = false;
                ss.PermitPrint = true;
                string newFileName = sourceFile.Substring(0,sourceFile.Length-4) + " - WM.pdf";
                
                // Save document
                document.Save(newFileName);
                
                // Release the document from memory
                document.Close();

                // Messagebox to show completed
                MessageBox.Show("PDF Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open PDF on completion
                if (chkOpen.Checked == true)
                {
                    Process.Start(newFileName);
                }
                else
                {
                    return;
                }
             }
            catch (Exception ex)
            {
                // Trap any error messages
                MessageBox.Show($"There was an error: '{ex}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
                                  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Default watermark string, loaded every time
            string watermarkText = "RADIAN H.A. Limited";
            txtWatermark.Text = watermarkText;
            chkOpen.Checked = true;
            rbRed.Checked = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Open file dialogue
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse PDF Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "pdf",
                Filter = "pdf files (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Select the file path and put in textbox
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application and release recources
            Application.Exit();
        }
    }
}
