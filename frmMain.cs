using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;



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
            PdfCanvas canvas;
            int n = pdfDoc.GetNumberOfPages();
            for (int i = 1; i <= n; i++)
            {
                PdfPage page = pdfDoc.GetPage(i);
                //Draw watermark
                canvas = new PdfCanvas(page);
                String P = txtWatermark.Text;

                string[] lines = P.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                int fontSize = 25;
                int x = 0;
                int y = 0;
                int angle = 45;
                int noOfLines = lines.Length;


                foreach (string line in lines)
                {

                    if (rbRed.Checked == true)
                    {
                        Paragraph p = new Paragraph(line)
                           .SetFontSize(fontSize)
                           .SetFontColor(ColorConstants.RED);
                        canvas.SaveState();
                        PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                        canvas.SetExtGState(gs1);

                        //Note starting position or centre pf paper - 280 x 375
                        document.ShowTextAligned(p, (250 - (noOfLines * 7)) + x, 400 + y, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, angle);
                        x += +18;
                        y += -10;
                        noOfLines -= 1;
                    }
                    else if (rbOrange.Checked == true)
                    {
                        Paragraph p = new Paragraph(line)
                            .SetFontSize(fontSize)
                            .SetFontColor(ColorConstants.ORANGE);
                        canvas.SaveState();
                        PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                        canvas.SetExtGState(gs1);

                        //Note starting position or centre pf paper - 280 x 375
                        document.ShowTextAligned(p, (250 - (noOfLines * 7)) + x, 400 + y, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, angle);
                        x += +18;
                        y += -10;
                        noOfLines -= 1;
                    }
                    else if (rbBlue.Checked == true)
                    {
                        Paragraph p = new Paragraph(line)
                          .SetFontSize(fontSize)
                          .SetFontColor(ColorConstants.BLUE);
                        canvas.SaveState();
                        PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                        canvas.SetExtGState(gs1);

                        //Note starting position or centre pf paper - 280 x 375
                        document.ShowTextAligned(p, (250 - (noOfLines * 7)) + x, 400 + y, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, angle);
                        x += +18;
                        y += -10;
                        noOfLines -= 1;
                    }
                    else if (rbBlack.Checked == true)
                    {
                        Paragraph p = new Paragraph(line)
                          .SetFontSize(fontSize)
                          .SetFontColor(ColorConstants.BLACK);
                        canvas.SaveState();
                        PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                        canvas.SetExtGState(gs1);

                        //Note starting position or centre pf paper - 280 x 375
                        document.ShowTextAligned(p, (250 - (noOfLines * 7)) + x, 400 + y, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, angle);
                        x += +18;
                        y += -10;
                        noOfLines -= 1;
                    }
                    else if (rbMagenta.Checked == true)
                    {
                        Paragraph p = new Paragraph(line)
                          .SetFontSize(fontSize)
                          .SetFontColor(ColorConstants.MAGENTA);
                        canvas.SaveState();
                        PdfExtGState gs1 = new PdfExtGState().SetFillOpacity(0.2f);
                        canvas.SetExtGState(gs1);

                        //Note starting position or centre pf paper - 280 x 375
                        document.ShowTextAligned(p, (250 - (noOfLines * 7)) + x, 400 + y, pdfDoc.GetPageNumber(page), TextAlignment.CENTER, VerticalAlignment.MIDDLE, angle);
                        x += +18;
                        y += -10;
                        noOfLines -= 1;
                    }
                }

                canvas.RestoreState();
            }
            pdfDoc.Close();

            // Secure PDF file
            PdfReader pdfReader = new PdfReader(newNonSecureFile);
            WriterProperties writerProperties = new WriterProperties();
            writerProperties.SetStandardEncryption(USERPASS, OWNERPASS, EncryptionConstants.ALLOW_PRINTING, EncryptionConstants.ENCRYPTION_AES_128);
            PdfWriter pdfWriter = new PdfWriter(new FileStream(newSecureFile, FileMode.Create), writerProperties);
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

            // Default loaded every time

            chkOpen.Checked = true;
            rbRed.Checked = true;
            rbFront.Checked = true;
        }
        private void PrintProductVersion()
        {
            lblVersionNumber.Text = "A.Bradshaw - Ver#: " + Application.ProductVersion;
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

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewFoler f2 = new frmNewFoler();
            f2.ShowDialog();

        }
    }
}
