using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDoc printer = new PDoc();
            printer.PrinterFont = new Font("Verdana", 15);
            printer.TextToPrint = textBox1.Text;
            printer.Print();
        }
    }
}
