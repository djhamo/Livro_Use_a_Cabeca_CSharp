using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORDesignerWalkthrough
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NorthwindDataContext northwindDataContext1 = new NorthwindDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            customersBindingSource.DataSource = northwindDataContext1.Customers;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                northwindDataContext1.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
