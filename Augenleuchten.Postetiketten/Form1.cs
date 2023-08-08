using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Pdfa;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing.Imaging;
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
            string pfad4Briefmarken = @"C:\Users\guder\Downloads\Briefmarken.4Stk.29.07.2023_1317.pdf";
            string pfad1Briefmarke = @"C:\Users\guder\Downloads\Briefmarken.1Stk.07.08.2023_2024.pdf";
            string output = @"C:\Users\guder\Downloads\output.pdf";
            //string output2 = @"C:\Users\guder\Downloads\output2.pdf";

            RotatePdf(pfad4Briefmarken, output, 270);
            PrintPdf(output);
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
            using (Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument())
            {
                doc.LoadFromFile(filePath);

                var image = doc.SaveAsImage(0, 300, 300);
                image.Save(@"C:\Users\guder\Downloads\test.png", System.Drawing.Imaging.ImageFormat.Png);

                int xAbstand = 82;
                int yAbstand = 51;
                int breite = 135;
                int hoehe = 256;

                int xAbstandGross = 344;
                int yAbstandGross = 217;
                int breiteGross = 555;
                int hoeheGross = 1063;

                Rectangle sourceRect = new Rectangle(xAbstandGross, yAbstandGross, breiteGross, hoeheGross);

                Bitmap bitmap = new Bitmap(780,1169);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    //graphics.DrawImage(image, 0, 0, sourceRect, GraphicsUnit.Pixel);
                    graphics.DrawImage(image, new Rectangle(85,0,breiteGross,hoeheGross), sourceRect, GraphicsUnit.Pixel);
                }

                bitmap.Save(@"C:\Users\guder\Downloads\cutoutbitmap.png", System.Drawing.Imaging.ImageFormat.Png);

                ImagePrinter printer = new ImagePrinter(bitmap);
                printer.Print();


                // Choose the page index you want to print
                int pageIndex = 0;

                // Set the desired area (in points) to be printed
                //165x104

                //PageArea = 595x842
                //RectangleF printArea = new RectangleF(82, 51, 135, 257); // Example coordinates and size

                // Get the selected page
                //PdfPageBase page = doc.Pages[pageIndex];
                //int labelsToBePrinted = 1;
                
                //for (int i = 0; i < labelsToBePrinted; i++)
                //{
                //    using (Spire.Pdf.PdfDocument newDoc = new Spire.Pdf.PdfDocument())
                //    {
                //        if (i % 2 == 0)
                //        {
                //            yAbstand = yAbstand + hoehe;
                //        }
                //        else
                //        {
                //            yAbstand = yAbstand - hoehe;
                //        }
                //        if (i % 2 == 0 && i != 0)
                //        {
                //            xAbstand = xAbstand + breite;
                //        }
                //        //var docdoc = page.Document.Pages[0].ExtractImages();
                //        RectangleF printArea = new RectangleF(xAbstand, yAbstand, breite, hoehe); // Print Briefmarken

                //        //Create a PdfUnitConvertor instance
                //        PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
                //        //Convert the custom size in inches to points
                //        float width = unitCvtr.ConvertUnits(3.937f, PdfGraphicsUnit.Inch, PdfGraphicsUnit.Point);
                //        float height = unitCvtr.ConvertUnits(5.906f, PdfGraphicsUnit.Inch, PdfGraphicsUnit.Point);
                //        //Create a new SizeF instance from the custom size, then it will be used as the page size of the new PDF
                //        SizeF size = new SizeF(width, height);

                //        //RectangleF printArea = new RectangleF(82, 51, 135, 257); // Erste Briefmarke links oben
                //        PdfPageBase newPage = newDoc.Pages.Add(page.Size, new Spire.Pdf.Graphics.PdfMargins(0));

                //        // Set the clip region to the desired area


                //        // Draw the clipped content onto the new page
                //        //newPage.Canvas.DrawTemplate(page.CreateTemplate(), PointF.Empty);

                //        // Calculate scaling factors to fit the clip area to the new page
                //        float scaleX = newPage.Size.Width / printArea.Width;
                //        float scaleY = newPage.Size.Height / printArea.Height;
                //        float scale = Math.Min(scaleX, scaleY);

                //        newPage.Canvas.SetClip(printArea);
                //        var state = newPage.Canvas.Save();

                //        // Draw the clipped content onto the new page with the calculated scaling
                //        //newPage.Canvas.ScaleTransform(scale, scale);

                //        newPage.Canvas.DrawTemplate(page.CreateTemplate(), PointF.Empty);



                //        // Print the new page (which contains the clipped area)

                //        newDoc.PrintSettings.SelectSinglePageLayout(Spire.Pdf.Print.PdfSinglePageScalingMode.FitSize, true);
                //        newDoc.PrintSettings.PrinterName = @"OneNote for Windows 10";



                //        //PaperSize is set in hundreds of inches -> 10x15 cm = 3.937x5.906 inches
                //        //newDoc.PrintSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 393, 590);
                //        newDoc.Print();
                //    }
                //}

            }
        }
    }
}