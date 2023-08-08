using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Spire.Pdf;
using System.Drawing.Printing;
using System.Runtime.ExceptionServices;

namespace Augenleuchten.Postetiketten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pfad4Briefmarken = @"C:\Users\rgude\Downloads\Briefmarken.4Stk.29.07.2023_1317.pdf";
            string pfad1Briefmarke = @"C:\Users\rgude\Downloads\Briefmarken.1Stk.07.08.2023_2024.pdf";
            string output = @"C:\Users\rgude\Downloads\output.pdf";
            string output2 = @"C:\Users\rgude\Downloads\output2.pdf";

            RotatePdf(pfad4Briefmarken, output, 270);
            PrintPdf(output);
            Console.WriteLine("PDF rotated and saved successfully.");
        }

        public static void RotatePdf(string inputPath, string outputPath, float angle)
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
        }

        static void PrintPdf(string filePath)
        {
            

            

            //Print the document with the default printer 
            

            using (Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument(filePath))
            {             
                // Choose the page index you want to print
                int pageIndex = 0;

                // Set the desired area (in points) to be printed
                //165x104

                //PageArea = 595x842
                //RectangleF printArea = new RectangleF(82, 51, 135, 257); // Example coordinates and size

                // Get the selected page
                PdfPageBase page = doc.Pages[pageIndex];
                int labelsToBePrinted = 4;
                int xAbstand = 82;
                int yAbstand = 51;
                int breite = 135;
                int hoehe = 256;
                for (int i = 0; i < labelsToBePrinted; i++)
                {
                    using (Spire.Pdf.PdfDocument newDoc = new Spire.Pdf.PdfDocument())
                    {
                        if(i % 2 == 0)
                        {
                            yAbstand = yAbstand + hoehe;
                        } else
                        {
                            yAbstand = yAbstand - hoehe;
                        }
                        if(i % 2 == 0 && i != 0)
                        {
                            xAbstand = xAbstand + breite;
                        }
                        RectangleF printArea = new RectangleF(xAbstand, yAbstand, breite, hoehe); // Erste Briefmarke

                        //RectangleF printArea = new RectangleF(82, 51, 135, 257); // Erste Briefmarke links oben
                        PdfPageBase newPage = newDoc.Pages.Add(page.Size, new Spire.Pdf.Graphics.PdfMargins(0));

                        // Set the clip region to the desired area
                        newPage.Canvas.SetClip(printArea);

                        // Draw the clipped content onto the new page
                        newPage.Canvas.DrawTemplate(page.CreateTemplate(), PointF.Empty);

                        // Print the new page (which contains the clipped area)

                        newDoc.PrintSettings.PrinterName = @"OneNote for Windows 10";
                        newDoc.PrintSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 100, 100);
                        newDoc.Print();
                    }
                }
                
            }
        }
    }
}