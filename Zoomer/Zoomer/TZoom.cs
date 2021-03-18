using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoomer
{
    public partial class TZoom : UserControl
    {
        Bitmap photo = new Bitmap(@"C:\Users\tiago\Pictures\Fotos\Cremogema\DSC00319.JPG");

        public TZoom()
        {
            InitializeComponent();
        }

        private void TZoom_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);
            g.DrawImage(photo, 10, 10, trackBar1.Value, trackBar2.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
