using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;


namespace TestPrint
{
    class PDoc : System.Drawing.Printing.PrintDocument
    {
        static int curChar = 0; 

        private string _text;
        public string TextToPrint
        {
            get { return _text; }
            set { _text = value; }
        }

        private Font _font;        
        public Font PrinterFont
        {
            get { return _font; }
            set { _font = value; }
            
        }

        public PDoc() : base()
        {
            _text = string.Empty;
        }

        public PDoc(string str) : base()
        {
            TextToPrint = str;
        }

        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);

            if (_font == null)
            {
                _font = new Font("Times New Roman", 10);
            }
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            int printHeight;
            int printWidth;
            int leftMargin;
            int rightMargin;
            Int32 lines;
            Int32 chars;
            /*
            {
                printHeight = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                printWidth = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                leftMargin = base.DefaultPageSettings.Margins.Left; 
                rightMargin = base.DefaultPageSettings.Margins.Top; 
            }
            */
            {
                printHeight = 200;
                printWidth = 500;
                leftMargin = 300;
                rightMargin = 500;
            }

            if (base.DefaultPageSettings.Landscape)
            {
                int tmp = printHeight;
                printHeight = printWidth;
                printHeight = tmp;
            }

            //Now we need to determine the total number of lines
            //we're going to be printing
            Int32 numLines = (int)printHeight / PrinterFont.Height;

            //Create a rectangle printing are for our document
            RectangleF printArea = new RectangleF(leftMargin, rightMargin, printWidth, printHeight);

            //Use the StringFormat class for the text layout of our document
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);

            //Fit as many characters as we can into the print area     
            e.Graphics.MeasureString(_text, PrinterFont, new SizeF(printWidth, printHeight), format, out chars, out lines);

            //Print the page
            e.Graphics.DrawString(_text, PrinterFont, Brushes.Black, printArea, format);

            //Increase current char count
            curChar += chars;
 
            //Detemine if there is more text to print, if
            //there is the tell the printer there is more coming
            if (curChar < _text.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                curChar = 0;
            }

        }

        public int RemoveZeros(int value)
        {
            switch(value)
            {
                case 0:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
