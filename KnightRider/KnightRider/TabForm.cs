using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightRider
{
    public partial class TabForm : Form
    {

        public TabForm()
        {
            InitializeComponent();
        }

        public Renderer Renderer { get; set; }

        private void TabForm_Paint(object sender, PaintEventArgs e)
        {
            Renderer.Render(e.Graphics);
        }
    }
}
