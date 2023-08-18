using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GS.Briefmarkendrucker
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

            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PrintPageHandler;

                // Set paper size to 10x15 cm
                PaperSize paperSize = new PaperSize("Custom", 394, 591); // In Inches
                pd.DefaultPageSettings.PaperSize = paperSize;

                // Set printing margins to zero
                pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

                pd.PrinterSettings.PrinterName = Properties.Settings.Default.PrinterName;
                // Print the document
                pd.Print();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(imageToPrint, e.MarginBounds);

            e.HasMorePages = false; // No more pages to print
        }
    }
}
