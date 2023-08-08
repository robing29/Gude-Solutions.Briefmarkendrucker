using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augenleuchten.Postetiketten
{
    internal class ImagePrinter
    {
        private Image imageToPrint;

        public ImagePrinter(Image image)
        {
            imageToPrint = image;
        }

        public void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPageHandler;

            // Set paper size to 10x15 cm
            PaperSize paperSize = new PaperSize("Custom", 394, 591); // In Inches
            pd.DefaultPageSettings.PaperSize = paperSize;

            // Set printing margins to zero
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            pd.PrinterSettings.PrinterName =  FormMainWindow.PrinterName == null ? "MUNBYN itpp 130b" : FormMainWindow.PrinterName;
            // Print the document
            pd.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Calculate scaling factors
            //float scaleX = (float)e.MarginBounds.Width / imageToPrint.Width;
            //float scaleY = (float)e.MarginBounds.Height / imageToPrint.Height;
            //float scale = Math.Min(scaleX, scaleY);

            //// Calculate the position to center the image
            //float xPos = e.MarginBounds.Left + (e.MarginBounds.Width - imageToPrint.Width * scale) / 2;
            //float yPos = e.MarginBounds.Top + (e.MarginBounds.Height - imageToPrint.Height * scale) / 2;

            //// Draw the scaled image
            //e.Graphics.DrawImage(imageToPrint, xPos, yPos, imageToPrint.Width * scale, imageToPrint.Height * scale);
            e.Graphics.DrawImage(imageToPrint, e.MarginBounds);

            e.HasMorePages = false; // No more pages to print
        }
    }
}
