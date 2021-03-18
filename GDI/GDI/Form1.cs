using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        bool JahFoiDesenho1 = false;
        bool JahFoiDesenho2 = false;

        private void Form1_Click(object sender, EventArgs e)
        {
            Desenhar();
        }

        private void Desenho1()
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(Brushes.WhiteSmoke, this.ClientRectangle);

                g.DrawLine(Pens.Blue, 30, 10, 100, 45);
                g.DrawLine(Pens.Blue, new Point(30, 45), new Point(100, 10));

                //g.FillRectangle(Brushes.SlateGray, new Rectangle(150, 15, 140, 90));
                g.DrawRectangle(Pens.SkyBlue, new Rectangle(150, 15, 140, 90));

                g.FillEllipse(Brushes.DarkGray, new Rectangle(45, 65, 200, 100));
                g.FillEllipse(Brushes.Silver, new Rectangle(40, 60, 200, 100));

                using (Font arial24Bold = new Font("Arial", 24, FontStyle.Bold))
                {
                    g.DrawString("Hi THere!", arial24Bold, Brushes.Red, 50, 75);
                }
            }
        }

        private void Desenho2()
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.FillRectangle(Brushes.SkyBlue, this.ClientRectangle);

                g.DrawImage(Properties.Resources.Bee_animation_1, 50, 20, 75, 75);
                g.DrawImage(Properties.Resources.Flower, 10, 130, 100, 150);

                using (Pen thickBlackPen = new Pen(Brushes.Black, 3.0f))
                {
                    g.DrawLines(thickBlackPen, new Point[] {
                        new Point(130, 110), new Point(120, 160), new Point(155, 163) });
                    g.DrawCurve(thickBlackPen, new Point[] {
                        new Point(120, 160), new Point(175, 120), new Point(215, 70) });

                    using (Font font = new Font("Arial", 16, FontStyle.Italic))
                    {
                        SizeF size = g.MeasureString("Nectar Here", font);
                        g.DrawString("Nectar Here", font, Brushes.Red, 
                            new Point(215 - (int)size.Width / 2, 70 - (int)size.Height));
                    }
                }
            }
        }

        private void Form1_Click(object sender, PaintEventArgs e)
        {
            Desenhar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (JahFoiDesenho2)
            {
                Grade();
                JahFoiDesenho2 = false;
            }
            else
            {
                Desenhar();
                JahFoiDesenho2 = true;
            }
        }

        private void Desenhar()
        {
            if (JahFoiDesenho1)
            {
                Desenho2();
                JahFoiDesenho1 = false;
            }
            else
            {
                Desenho1();
                JahFoiDesenho1 = true;
            }
        }

        private void Grade()
        {
            using (Graphics g = this.CreateGraphics())
                using (Font f = new Font("Arial", 6, FontStyle.Regular)) 
                {
                    for (int x = 0; x < this.Width; x += 20)
                    {
                        g.DrawLine(Pens.Black, x, 0, x, this.Height);
                        g.DrawString(x.ToString(), f, Brushes.Black, x, 0);
                    }
                    for (int y = 0; y < this.Height; y += 20)
                    {
                        g.DrawLine(Pens.Black, 0, y, this.Width, y);
                        g.DrawString(y.ToString(), f, Brushes.Black, 0, y);
                        
                    }
                }
        }
    }
}
