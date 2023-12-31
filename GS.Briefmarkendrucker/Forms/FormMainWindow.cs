using Spire.Pdf;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace GS.Briefmarkendrucker
{
    public partial class FormMainWindow : Form
    {
        public static string? CurrentTime { get; set; }
        private static int AnzahlBriefmarken { get; set; } = 0;
        public FormMainWindow()
        {
            InitializeComponent();

            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                druckerAuswaehlenToolStripMenuItem1.Items.Add(printer);
            }
            txtBoxOutputPath.Text = Properties.Settings.Default.Zielpfad;
            druckerAuswaehlenToolStripMenuItem1.Text = Properties.Settings.Default.PrinterName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileName == "")
                {
                    MessageBox.Show("Bitte w�hlen Sie eine Briefmarke aus.");
                    return;
                }
                else if (Properties.Settings.Default.Zielpfad == "")
                {
                    MessageBox.Show("Bitte w�hlen Sie einen Ordner aus.");
                    return;
                }
                else if (Properties.Settings.Default.PrinterName == "")
                {
                    MessageBox.Show("Bitte w�hlen Sie einen Drucker aus.");
                    return;
                }
                else if (AnzahlBriefmarken == 0)
                {
                    MessageBox.Show("Kann keine Briefmarken im PDF erkennen. Bitte Datei �berpr�fen.");
                    return;
                }

                string pfadZurBriefmarke = openFileDialog1.FileName;
                string outputFolder = Properties.Settings.Default.Zielpfad;
                CurrentTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                string outputPdf = outputFolder + @$"\{CurrentTime}-output.pdf";

                string rotatedPdf = RotatePdf(pfadZurBriefmarke, outputPdf, 270);
                PrintPdf(rotatedPdf, outputFolder, AnzahlBriefmarken);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string RotatePdf(string inputPath, string outputPath, float angle)
        {
            PdfDocument pdfDocument = new PdfDocument();
            pdfDocument.LoadFromFile(inputPath);

            int pageCount = pdfDocument.Pages.Count;
            for (int pageNumber = 0; pageNumber < pageCount; pageNumber++)
            {
                PdfPageBase page = pdfDocument.Pages[pageNumber];
                int rotation = (int)page.Rotation;

                //Rotate the page 180 degrees clockwise based on the original rotation angle

                rotation += (int)PdfPageRotateAngle.RotateAngle270;
                page.Rotation = (PdfPageRotateAngle)rotation;
            }
            pdfDocument.SaveToFile(outputPath);
            return outputPath;
        }

        static void PrintPdf(string filePath, string outputPath, int anzahlBriefmarken)
        {
            using (PdfDocument doc = new PdfDocument())
            {
                doc.LoadFromFile(filePath);
                var image = doc.SaveAsImage(0, 300, 300);

                int labelsToBePrinted = anzahlBriefmarken;

                int xAbstandGross = 344;
                int yAbstandGross = 217;
                int breiteGross = 555;
                int hoeheGross = 1063;
                bool showedMessage = false;
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
                        graphics.DrawImage(image, new Rectangle(85, 0, breiteGross, hoeheGross), sourceRect, GraphicsUnit.Pixel);
                    }

                    bitmap.Save($@"{outputPath}\{CurrentTime}-briefmarke{i}.png", System.Drawing.Imaging.ImageFormat.Png);

                    ImagePrinter printer = new ImagePrinter(bitmap);
                    try
                    {
                        if (showedMessage == false)
                        {
                            MessageBox.Show("Druckauftrag wurde erfolgreich an den Drucker gesendet.");
                            showedMessage = true;
                        }
                        printer.Print();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return;
                    }
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
            var dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.Zielpfad = folderBrowserDialog1.SelectedPath;
                txtBoxOutputPath.Text = Properties.Settings.Default.Zielpfad;
            }
        }

        private void druckerAusw�hlenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void druckerAusw�hlenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrinterName = druckerAuswaehlenToolStripMenuItem1.SelectedIndex == -1 ? "" : druckerAuswaehlenToolStripMenuItem1.SelectedItem.ToString();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void druckerAuswaehlenToolStripMenuItem1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrinterName = druckerAuswaehlenToolStripMenuItem1.SelectedIndex == -1 ? "" : druckerAuswaehlenToolStripMenuItem1.SelectedItem.ToString();
        }

        private void FormMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Zielpfad = folderBrowserDialog1.SelectedPath == "" ? Properties.Settings.Default.Zielpfad : folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
        }

        private void lblOutputPath_Click(object sender, EventArgs e)
        {

        }

        private void �berToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programInfotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form programInfo = new FormProgrammInfo();
            programInfo.Show();
        }
    }
}