using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;

namespace VolandoBoy_printer
{
    public class Printer
    {
        private class PrintHelper
        {
            private float paperWidth;
            private Graphics graphics;
            private float lastPrintedY = 0;

            private Brush blackBrush = new SolidBrush(Color.Black);

            public PrintHelper(Graphics graphics)
            {
                this.graphics = graphics;

                PrinterSettings settings = new PrinterSettings { PrinterName = Program.Form_main().printer.printerName };
                paperWidth = settings.DefaultPageSettings.Bounds.Right;
            }

            public void Write(string text, int fontSize = 10, FontStyle fontStyle = FontStyle.Regular)
            {
                Font font = new Font("Helvetica", fontSize, fontStyle);

                float textHeight = graphics.MeasureString(text, font, new SizeF(paperWidth, 0)).Height;

                RectangleF area = new RectangleF(0, lastPrintedY, paperWidth, textHeight);
                lastPrintedY += textHeight;

                graphics.DrawString(text, font, blackBrush, area);
            }

            public void NewLine()
            {
                Write("\n", 10);
            }

            public void FeedPaper(float distance = 20)
            {
                graphics.DrawString(".", new Font("Helvetica", 1), blackBrush, new PointF(0, lastPrintedY + distance));
                lastPrintedY += distance;
            }

            public void WriteLogo()
            {
                Font font = new Font("Helvetica", 16, FontStyle.Regular);

                string line = "~ VolandoBoy ~";

                float oneLineHeight = graphics.MeasureString(line, font, new SizeF(paperWidth, 0)).Height;
                while (graphics.MeasureString(" "+line+" ", font, new SizeF(paperWidth, 0)).Height == oneLineHeight) line = " " + line + " ";

                Write(line, 16, FontStyle.Bold);

                NewLine();
            }

            public void WriteLine(string lineStyle = "_", int fontSize = 12)
            {
                //graphics.DrawLine(new Pen(blackBrush), new Point(0, Convert.ToInt32(lastPrintedY)), new Point(Convert.ToInt32(paperWidth), Convert.ToInt32(lastPrintedY)));

                Font font = new Font("Helvetica", fontSize);

                string line = lineStyle;

                float oneLineHeight = graphics.MeasureString(line, font, new SizeF(paperWidth, 0)).Height;
                while (graphics.MeasureString(line + lineStyle, font, new SizeF(paperWidth, 0)).Height == oneLineHeight) line += lineStyle;

                Write(line, fontSize);
            }
        }


        private string printerName;

        public Printer(string printerName)
        {
            this.printerName = printerName;
        }

        private void Print(PrintPageEventHandler printHandler)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = printerName;
            doc.PrintPage += new PrintPageEventHandler(printHandler);
            doc.Print();
        }

        public void PrintTest()
        {
            void printHandler(object sender, PrintPageEventArgs e)
            {
                PrintHelper printHelper = new PrintHelper(e.Graphics);

                printHelper.WriteLogo();
                printHelper.Write("Test impresora", 14);
                printHelper.Write("Setze jutges d'un jutjat mengen fetge d'un penjat i el penjat era un bon metge, que per heretge havien condemnat. Setze jutges d'un jutjat mengen fetge d'un penjat.Si el penjat es despenja, es menja els setze fetges dels jutges del jutjat que l'han penjat.", 8);
                printHelper.NewLine();
                printHelper.Write("test acabat", 12);
            }

            Print(printHandler);
        }

        public void PrintText(string text, int fontSize = 10, FontStyle fontStyle = FontStyle.Regular)
        {
            void printHandler(object sender, PrintPageEventArgs e)
            {
                PrintHelper printHelper = new PrintHelper(e.Graphics);

                printHelper.Write(text, fontSize, fontStyle);
            }

            Print(printHandler);
        }

        public void PrintCommand(VolandoBoy.Command comm)
        {
            void printHandler(object sender, PrintPageEventArgs e)
            {
                PrintHelper ph = new PrintHelper(e.Graphics);

                ph.WriteLogo();
                ph.Write(Program.Form_main().volandoBoy.restaurant.name, 12);
                ph.NewLine();
                ph.Write(comm.tag);
                ph.Write(comm.time_init);

                ph.WriteLine();

                foreach (VolandoBoy.Command.Line line in comm.lines)
                {
                    ph.NewLine();

                    string product_name = "- " + line.product.name.es + " " + line.price + "€";
                    if (line.product.variant != null) product_name += " (" + line.product.variant.name.es + ")";
                    ph.Write(product_name, 10, FontStyle.Bold);

                    if (line.removedIngredients().Count > 0)
                    {
                        string toRemove = "Sin: ";
                        toRemove += string.Join(", ", line.removedIngredients().Select(ing => ing.name.es));
                        ph.Write(toRemove, 8);
                    }
                    if (line.addedIngredients().Count > 0)
                    {
                       
                        string extras = "Con: ";
                        extras += string.Join(", ", line.addedIngredients().Select(ing => ing.name.es + ing.price + "€ "));
                        ph.Write(extras, 8);
                    }

                    if (line.comment != null && line.comment.Length > 0) ph.Write("\"" + line.comment + "\"", 8, FontStyle.Italic);
                }

                ph.WriteLine("-");
                if (comm.coupon != null && comm.coupon.id_restaurant != null) ph.Write("Cupón \"" + comm.coupon.code + "\": -" + comm.discount + "€", 8);
                ph.Write("Total: " + comm.restaurantPrice() + "€", 12, FontStyle.Bold);
                ph.FeedPaper();
            }

            Print(printHandler);
        }

    }
}
