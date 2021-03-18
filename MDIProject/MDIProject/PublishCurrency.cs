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
    public partial class PublishCurrency : Form
    {
        public PublishCurrency()
        {
            InitializeComponent();
        }

        private void PublishCurrency_Load(object sender, EventArgs e)
        {
            try
            {
                AWCurrencyEntities currContext = new AWCurrencyEntities();
                foreach (var cr in currContext.Currencies)
                {
                    txtCurrency.AppendText(cr.ModifiedDate.ToString());
                    txtCurrency.AppendText("\t\t");
                    txtCurrency.AppendText(cr.CurrencyCode.ToString());
                    txtCurrency.AppendText("\t\t");
                    txtCurrency.AppendText(cr.Name.ToString());
                    txtCurrency.AppendText("\t\r\n");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
    }
}
