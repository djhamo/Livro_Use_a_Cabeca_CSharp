using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIProject
{
    public partial class LINQtoObjects : Form
    {
        public LINQtoObjects()
        {
            InitializeComponent();
        }

        private void LINQtoObjects_Load(object sender, EventArgs e)
        {
            string[] names = {   "Life is Beaultiful",
                                 "Seven Pounds",
                                 "Arshika Agarwal",
                                 "Rupali Agarwai",
                                 "Pearl Solutions",
                                 "Vamika Agarwal",
                                 "Vidya Vrat Agarwal",
                                 "Lionbridge Tecnologies"
                             };
            IEnumerable<string> namesOfPeople = from name in names
                                                where name.Length <= 16
                                                select name;

            foreach (var name in namesOfPeople)
            {
                txtDisplay.AppendText(name + "\n");
            }
        }
    }
}
