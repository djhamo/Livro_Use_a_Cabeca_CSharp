using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List 1.0\nWritten by: Tiago", "About");
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void peopleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactDBDataSet.People);

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            double val = 21;
            double val2 = Math.Cos(val);

            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                cont++; 
            }
            
            cont--;

            string result = "hello";
            result += " again " + result;
            MessageBox.Show(result);
            result = "the value is: " + cont;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
        }
    }
}
