using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MDIProject
{
    public partial class EntityDataGrid : Form
    {
        public EntityDataGrid()
        {
            InitializeComponent();
        }

        private void EntityDataGrid_Load(object sender, EventArgs e)
        {
            AWCurrencyEntities currContext = new AWCurrencyEntities();
            DataContext db = new DataContext(currContext.Database);
            BindingSource bi = new BindingSource();
            bi.DataSource = currContext.Database.;
            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }
    }
}
