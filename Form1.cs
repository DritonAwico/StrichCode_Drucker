using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using ZXing;

namespace StrichCode_Drucker
{
    public partial class Form1 : Form
    {
        private Bitmap barcodeBitmap;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            tBoxEbNummer.Text = "EB12345678912";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxEbNummer.Text))
            {
                MessageBox.Show("Keine EB-Nummer eingetragen");
            }

            else if (!string.IsNullOrEmpty(tBoxEbNummer.Text) && comboBox1.SelectedIndex == 2)
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.CODE_128;
                barcodeWriter.Options.Height = 300;
                barcodeWriter.Options.Width = 295;
                barcodeWriter.Options.PureBarcode = true;
                barcodeBitmap = barcodeWriter.Write(tBoxEbNummer.Text);

                Bitmap topLogo = Properties.Resources.logo;
                Bitmap bottomLogo = Properties.Resources.logo;

                // Top Logo um 180° Drehen
                topLogo.RotateFlip(RotateFlipType.Rotate180FlipNone);

                // Kombiniertes Bild erstellen (gleiche Größe wie vorher)
                int combinedHeight = 420;
                int combinedWidth = 295;
                Bitmap combinedBitmap = new Bitmap(combinedWidth, combinedHeight);
                using (Graphics g = Graphics.FromImage(combinedBitmap))
                {
                    // 0. Hintergrund weiß
                    g.Clear(Color.White);
                    // 1. Toplogo 180°
                    g.DrawImage(topLogo, 100, 10, 100, 50);
                    // 2. String 180°
                    g.TranslateTransform(150, 90); // Ursprung verschieben
                    g.RotateTransform(180); // Text drehen
                    using (Font font = new Font("Arial", 12, FontStyle.Bold))
                    using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center })
                    {
                        g.DrawString(tBoxEbNummer.Text, font, Brushes.Black, 0, 0, format);
                    }
                    g.ResetTransform(); // Zurücksetzen der Transformation
                    // 3. Barcode
                    g.DrawImage(barcodeBitmap, 0, 95, 295, 240);
                    // 4. String
                    using (Font font = new Font("Arial", 12, FontStyle.Bold))
                    using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center })
                    {
                        g.DrawString(tBoxEbNummer.Text, font, Brushes.Black, combinedWidth / 2, 340, format);
                    }
                    // 5. Botlogo
                    g.DrawImage(bottomLogo, 100, 370, 100, 50);
                }
                barcodeBitmap = combinedBitmap;
                MessageBox.Show("Barcode erfolgreich erstellt!");
            }

            else if (!string.IsNullOrEmpty(tBoxEbNummer.Text) && comboBox1.SelectedIndex == 1)
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.CODE_128;
                barcodeWriter.Options.Height = 300;
                barcodeWriter.Options.Width = 295;
                barcodeWriter.Options.PureBarcode = true;
                barcodeBitmap = barcodeWriter.Write(tBoxEbNummer.Text);

                // Kombiniertes Bild erstellen (gleiche Größe wie vorher)
                int combinedHeight = 420;
                int combinedWidth = 295;
                Bitmap combinedBitmap = new Bitmap(combinedWidth, combinedHeight);
                using (Graphics g = Graphics.FromImage(combinedBitmap))
                {
                    // 0. Hintergrund weiß
                    g.Clear(Color.White);
                    // 1. String 180°
                    g.TranslateTransform(150, 35); // Ursprung verschieben
                    g.RotateTransform(180); // Text drehen
                    using (Font font = new Font("Arial", 12, FontStyle.Bold))
                    using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center })
                    {
                        g.DrawString(tBoxEbNummer.Text, font, Brushes.Black, 0, 0, format);
                    }
                    g.ResetTransform(); // Zurücksetzen der Transformation
                    // 3. Barcode
                    g.DrawImage(barcodeBitmap, 0, 45, 295, 340);
                    // 4. String
                    using (Font font = new Font("Arial", 12, FontStyle.Bold))
                    using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center })
                    {
                        g.DrawString(tBoxEbNummer.Text, font, Brushes.Black, combinedWidth / 2, 395, format);
                    }
                }
                barcodeBitmap = combinedBitmap;
                MessageBox.Show("Barcode erfolgreich erstellt!");
            }

            else if (!string.IsNullOrEmpty(tBoxEbNummer.Text) && comboBox1.SelectedIndex == 0)
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.CODE_128;
                barcodeWriter.Options.Height = 300;
                barcodeWriter.Options.Width = 295;
                barcodeWriter.Options.PureBarcode = true;
                barcodeBitmap = barcodeWriter.Write(tBoxEbNummer.Text);

                // Kombiniertes Bild erstellen (gleiche Größe wie vorher)
                int combinedHeight = 420;
                int combinedWidth = 295;
                Bitmap combinedBitmap = new Bitmap(combinedWidth, combinedHeight);
                using (Graphics g = Graphics.FromImage(combinedBitmap))
                {
                    // 0. Hintergrund weiß
                    g.Clear(Color.White);
                    // 1. Barcode
                    g.DrawImage(barcodeBitmap, 0, 15, 295, 400);
                }
                barcodeBitmap = combinedBitmap;
                MessageBox.Show("Barcode erfolgreich erstellt!");
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (barcodeBitmap == null)
            {
                MessageBox.Show("Bitte generieren Sie zuerst einen Barcode, bevor Sie drucken!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Abbrechen, wenn kein Barcode vorhanden ist
            }
            try
            {
                PrintDocument printDocument = new PrintDocument();

                if (comboBox2.SelectedIndex == 0)
                {
                    printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                }

                else if (comboBox2.SelectedIndex == 1)
                {
                    printDocument.PrinterSettings.PrinterName = "RICOH Aficio MP C2800";
                }

                else if (comboBox2.SelectedIndex == 2)
                {
                    printDocument.PrinterSettings.PrinterName = "SATO S84-ex 305dpi";
                }

                printDocument.PrintPage += (object printSender, PrintPageEventArgs printArgs) =>
                {
                    printArgs.Graphics.DrawImage(barcodeBitmap, -75, 10, 370, 420);
                };

                // Druck starten
                printDocument.Print();
            }

            catch (Exception ex)
            {
                // Allgemeiner Fehler beim Drucken
                MessageBox.Show($"Fehler beim Drucken: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
