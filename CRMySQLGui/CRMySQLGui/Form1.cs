using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmContext;


namespace CRMySQLGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrmDataContext context = new CrmDataContext();
            var query = from it in context.Companies
                        orderby it.CompanyID
                        select it;
            authorBindingSource.DataSource = query;
            authorDataGridView.DataSource = authorBindingSource;
            bindingNavigator1.BindingSource = authorBindingSource;

            bindingNavigator1.DataBindings.Add(new Binding("Text", authorBindingSource, "CompanyName", true));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void companyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
