using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GamblePrint
{
    public partial class Form1 : Form
    {
        List<RectangleF> print_numbers = new List<RectangleF>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            PaperSize paperSize = new PaperSize("Loto", 310, 529);
            document.DefaultPageSettings.PaperSize = paperSize;

            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            document.Print();
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            //centimeters = pixels * 2.54 / 96
            //pixel = ( cm * 96 ) / 2.54

            buid_Lotomania();

            Graphics g = e.Graphics;
            List<int> numbers = new List<int>();

            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(12);
            numbers.Add(14);
            numbers.Add(15);
            numbers.Add(16);
            numbers.Add(17);
            numbers.Add(18);
            numbers.Add(19);
            numbers.Add(21);
            numbers.Add(23);
            numbers.Add(24);
            numbers.Add(25);
            numbers.Add(27);
            numbers.Add(28);
            numbers.Add(30);
            numbers.Add(42);
            numbers.Add(43);
            numbers.Add(44);
            numbers.Add(46);
            numbers.Add(48);
            numbers.Add(50);
            numbers.Add(52);
            numbers.Add(54);
            numbers.Add(56);
            numbers.Add(57);
            numbers.Add(59);
            numbers.Add(60);
            numbers.Add(61);
            numbers.Add(64);
            numbers.Add(65);
            numbers.Add(67);
            numbers.Add(68);
            numbers.Add(70);
            numbers.Add(72);
            numbers.Add(73);
            numbers.Add(75);
            numbers.Add(77);
            numbers.Add(79);
            numbers.Add(82);
            numbers.Add(83);
            numbers.Add(86);
            numbers.Add(88);
            numbers.Add(89);

            foreach (int num in numbers)
            {
                int posOK = num - 1;
                g.FillRectangle(Brushes.Black, print_numbers[posOK]);
            }
            
                    
        }

        void buid_Lotomania()
        {
            float leftMargin = 0;
            //Teste de SVN
            float topMargin = 0;

            const float ALt1 = 3.2F;
            const float Lag1 = 8.2F;
            float altura = (ALt1 * 96F) / 2.54F;
            float largura = (Lag1 * 96F) / 2.54F;

            //g.DrawRectangle(Pens.Black, leftMargin, topMargin, largura, altura);

            topMargin += altura;

            const float ALt2 = 0.5F;
            altura = (ALt2 * 96F) / 2.54F;

            // Linha 1 128,5 x 45,4
            float iniAlt = 124.724409449F - 11.338582677F;
            float iniLag = 45.354330709F - 3.779527559F;

            float mAltura = iniAlt;
            for (int i = 0; i < 10; i++)
            {
                float quadAlt = 7.559055118F;
                float quadLag = 11.338582677F;
                //Quadradinho 113,4F x 75,6

                // espaço lateral 26,5
                //float pitlag = 26.456692913F;
                float pitlag = 24.856692913F;
                // espaço altura = 19,6
                float pitalt = 18.897637795F;
                float mLarg = iniLag + 245.669291339F;

                for (int i2 = 0; i2 < 10; i2++)
                {
                    print_numbers.Add(new RectangleF(mLarg, mAltura, quadLag, quadAlt));
                    mLarg += pitlag;
                }

                mAltura += pitalt;
            }
        }
    }
}
