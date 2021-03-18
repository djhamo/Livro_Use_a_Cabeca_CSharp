using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFWinforms;

namespace NeoCRUD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

                entityDataSource1.SaveChanges();
     
        }

        private void entityDataSource1_DataError(object sender, DataErrorEventArgs e)
        {
            MessageBox.Show("Error Detected:\r\n" + e.Exception.Message);
            entityDataSource1.CancelChanges();
            e.Handled = true;
        }
    }
}
