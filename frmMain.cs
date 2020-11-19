using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Font;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Annot;


namespace PDF_Sample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private static byte[] USERPASS = System.Text.Encoding.Default.GetBytes("");
        private static byte[] OWNERPASS = System.Text.Encoding.Default.GetBytes("mHfb6A7Rwp&b^$z2");

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // Source File
            string sourceFile = txtFilePath.Text;
            // New filename
            string newNonSecureFile = sourceFile.Substring(0, sourceFile.Length - 4) + " - Non-Secure.pdf";
            // New secure file
            string newSecureFile = sourceFile.Substring(0, sourceFile.Length - 4) + " - Secure.pdf";

            //Initialize PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(sourceFile), new PdfWriter(newNonSecureFile));
            Document document = new Document(pdfDoc);
            Rectangle pageSize;
            int n = pdfDoc.GetNumberOfPages();
            for (int i = 1; i <= n; i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                pageSize = page.GetPageSize();
                //Draw watermark
                Paragraph paragraph = new Paragraph(txtWatermark.Text).SetFontSize(30);
                PdfCanvas over = new PdfCanvas(pdfDoc.GetPage(i).NewContentStreamBefore(), new PdfResources(), pdfDoc);

                // Watermark color selection
                if (rbRed.Checked == true)
                {
                    over.SetFillColor(ColorConstants.RED);
                }
                else if (rbOrange.Checked == true)
                {
                    over.SetFillColor(ColorConstants.ORANGE);
                }
                else if (rbBlue.Checked == true)
                {
                    over.SetFillColor(ColorConstants.BLUE);
                }
                else if (rbBlack.Checked == true)
                {
                    over.SetFillColor(ColorConstants.BLACK);
                }
                else
                {
                    over.SetFillColor(ColorConstants.MAGENTA);
                }
                over.SaveState();
                Canvas canvasWatermark1 = new Canvas(over, pdfDoc.GetDefaultPageSize())
                    .ShowTextAligned(paragraph, pageSize.GetWidth() / 2, pageSize.GetHeight() / 2, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, 45);
                canvasWatermark1.Close();

                // Creating a dictionary that maps resource names to graphics state parameter dictionaries
                
                PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                over.SetExtGState(gs1);
                over.RestoreState();
            }
            pdfDoc.Close();

            // Secure PDF file
            PdfReader pdfReader = new PdfReader(newNonSecureFile);
            WriterProperties writerProperties = new WriterProperties();
            writerProperties.SetStandardEncryption(USERPASS, OWNERPASS, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128);
            PdfWriter pdfWriter = new PdfWriter(new FileStream(newSecureFile , FileMode.Create), writerProperties);
            PdfDocument pdfDocument = new PdfDocument(pdfReader, pdfWriter);
            pdfDocument.Close();

            // Messagebox to show completed
            MessageBox.Show("Secure PDF Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open PDF on completion
            if (chkOpen.Checked == true)
            {
                Process.Start(newSecureFile);
            }
            else
            {
                return;
            }

            // Delete non secure version of file
            File.Delete(newNonSecureFile);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load Product Version
            PrintProductVersion();

            // Default watermark string, loaded every time
            string watermarkText = "RADIAN H.A. Limited";
            txtWatermark.Text = watermarkText;
            chkOpen.Checked = true;
            rbRed.Checked = true;
            rbFront.Checked = true;            
        }
        private void PrintProductVersion()
        {
            lblVersionNumber.Text = "A. Bradshaw - Ver#: " + Application.ProductVersion;
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
