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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objWA = new Login();
            objWA.MdiParent = this;
            objWA.Show();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo objUI = new UserInfo();
            objUI.MdiParent = this;
            objUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void myDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyDataSet objMyDataSet = new MyDataSet();
            objMyDataSet.MdiParent = this;
            objMyDataSet.Show();
        }

        private void modifyDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyDataTable pbjMod = new ModifyDataTable();
            pbjMod.MdiParent = this;
            pbjMod.Show();
        }

        private void lINQToObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoObjects objLINQ = new LINQtoObjects();
            objLINQ.MdiParent = this;
            objLINQ.Show();
        }

        private void lINQToSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoSQL onjLSQL = new LINQtoSQL();
            onjLSQL.MdiParent = this;
            onjLSQL.Show();
        }

        private void publishCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublishCurrency objCur = new PublishCurrency();
            objCur.MdiParent = this;
            objCur.Show();
        }

        private void currencyToGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityDataGrid objEntG = new EntityDataGrid();
            objEntG.MdiParent = this;
            objEntG.Show();
        }
    }
}
