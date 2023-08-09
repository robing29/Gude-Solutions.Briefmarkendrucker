using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Pdfa;
using Org.BouncyCastle.Bcpg;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Augenleuchten.Postetiketten
{
    public partial class FormMainWindow : Form
    {
        public static string CurrentTime { get; set; }
        public static string PrinterName { get; set; }
        private static int AnzahlBriefmarken { get; set; } = 0;
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pfad4Briefmarken = @"C:\Users\guder\Downloads\Briefmarken.4Stk.29.07.2023_1317.pdf";
            //string pfad1Briefmarke = @"C:\Users\guder\Downloads\Briefmarken.1Stk.07.08.2023_2024.pdf";
            //string output = @"C:\Users\guder\Downloads\output.pdf";
            //string output2 = @"C:\Users\guder\Downloads\output2.pdf";

            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Bitte wählen Sie eine Briefmarke aus.");
                return;
            }
            else if (folderBrowserDialog1.SelectedPath == "")
            {
                MessageBox.Show("Bitte wählen Sie einen Ordner aus.");
                return;
            }

            string pfadZurBriefmarke = openFileDialog1.FileName;
            string outputFolder = folderBrowserDialog1.SelectedPath;
            CurrentTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string outputPdf = outputFolder + @$"\{CurrentTime}-output.pdf";
            //Potenzieller Bug, wenn 10 Briefmarken gleichzeitig gedruckt werden würden, da dann die 1 nicht mehr im Pfad steht


            string rotatedPdf = RotatePdf(pfadZurBriefmarke, outputPdf, 270);
            PrintPdf(rotatedPdf, outputFolder, AnzahlBriefmarken);
        }

        public static string RotatePdf(string inputPath, string outputPath, float angle)
        {
            using (var pdfReader = new PdfReader(inputPath))
            using (var pdfWriter = new PdfWriter(outputPath))
            using (var pdfDocument = new iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter))
            {
                int pageCount = pdfDocument.GetNumberOfPages();
                for (int pageNumber = 1; pageNumber <= pageCount; pageNumber++)
                {
                    PdfPage page = pdfDocument.GetPage(pageNumber);
                    page.SetRotation((page.GetRotation() + (int)angle) % 360);
                }
            }
            return outputPath;
        }

        static void PrintPdf(string filePath, string outputPath, int anzahlBriefmarken)
        {
            using (Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument())
            {
                doc.LoadFromFile(filePath);

                var image = doc.SaveAsImage(0, 300, 300);
                //image.Save(@"C:\Users\guder\Downloads\test.png", System.Drawing.Imaging.ImageFormat.Png);

                int labelsToBePrinted = anzahlBriefmarken;

                int xAbstandGross = 344;
                int yAbstandGross = 217;
                int breiteGross = 555;
                int hoeheGross = 1063;

                for (int i = 0; i < labelsToBePrinted; i++)
                {
                    if (i % 2 == 0)
                    {
                        yAbstandGross = yAbstandGross + hoeheGross;
                    }
                    else
                    {
                        yAbstandGross = yAbstandGross - hoeheGross;
                    }
                    if (i % 2 == 0 && i != 0)
                    {
                        xAbstandGross = xAbstandGross + breiteGross;
                    }
                    Rectangle sourceRect = new Rectangle(xAbstandGross, yAbstandGross, breiteGross, hoeheGross);

                    Bitmap bitmap = new Bitmap(780, 1169);

                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        //graphics.DrawImage(image, 0, 0, sourceRect, GraphicsUnit.Pixel);
                        graphics.DrawImage(image, new Rectangle(85, 0, breiteGross, hoeheGross), sourceRect, GraphicsUnit.Pixel);
                    }

                    bitmap.Save($@"{outputPath}\{CurrentTime}-briefmarke{i}.png", System.Drawing.Imaging.ImageFormat.Png);

                    ImagePrinter printer = new ImagePrinter(bitmap);
                    printer.Print();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AnzahlBriefmarken = AnzahlBriefmarkenExtrahieren(openFileDialog1.FileName);
            txtBoxErkannteBriefmarken.Text = AnzahlBriefmarken.ToString();
        }

        private int AnzahlBriefmarkenExtrahieren(string filepath)
        {
            string regex = @".\.(?<number>\d+)Stk";
            MatchCollection matches = Regex.Matches(filepath, regex);
            int anzahlBriefmarken = 0;
            if (matches.Count > 0)
            {
                Match lastmatch = matches[matches.Count - 1];
                anzahlBriefmarken = int.Parse(lastmatch.Groups["number"].Value);
            }
            return anzahlBriefmarken;
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtBoxCurrentFile.Text = openFileDialog1.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtBoxOutputPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void druckerAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void druckerAuswählenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            PrinterName = printDialog1.PrinterSettings.PrinterName;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }
    }
}