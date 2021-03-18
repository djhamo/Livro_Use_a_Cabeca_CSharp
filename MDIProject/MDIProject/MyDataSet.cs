using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDIProject
{
    public partial class MyDataSet : Form
    {
        public MyDataSet()
        {
            InitializeComponent();
        }

        private void MyDataSet_Load(object sender, EventArgs e)
        {
            string connString = @" server=BLONDIE\BLONDIESQL; database=AdventureWorks; Integrated Security=true";

            string sql = @"select Name,ProductNumber
                            from Production.Product
                            where SafetyStockLevel > 600";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();

                da.Fill(ds, "Production.Product");

                gvProduct.DataSource = ds.Tables["Production.Product"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
