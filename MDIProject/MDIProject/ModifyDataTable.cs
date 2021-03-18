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
    public partial class ModifyDataTable : Form
    {
        public ModifyDataTable()
        {
            InitializeComponent();
        }

        private void ModifyDataTable_Load(object sender, EventArgs e)
        {
            string connString = @" server=BLONDIE\BLONDIESQL; database=AdventureWorks; Integrated Security=true";

            string sql = @"select AddressLine2, City, StateProvinceID, PostalCode
                            from Person.Address
                            where City = 'Bothell'";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                DataSet ds = new DataSet();
                da.Fill(ds, "Person.Address");

                DataTable dt = ds.Tables["Person.Address"];
                dt.Columns["AddressLine2"].AllowDBNull = true;
                dt.Rows[0]["City"] = "wilmington";

                DataRow newRow = dt.NewRow();
                newRow["PostalCode"] = "111111";
                newRow["StateProvinceID"] = "80";
                newRow["City"] = "Birmingham";
                dt.Rows.Add(newRow);

                gvAddress.DataSource = dt;
                gvAddress.Columns[0].Visible = false;
                gvAddress.Rows[1].DefaultCellStyle.BackColor = Color.Red;
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
