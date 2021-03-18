using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlTest
{
    public partial class MySqlTest : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public MySqlTest()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();

            mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=prosam;uid=root;pwd=;");

            try
            {
                mConn.Open(); 
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Erro de conexão com o banco de dados" + ex.ToString());
                        break;
                }
                mConn.Close();
            }
            if (mConn.State == ConnectionState.Open)
            {

                mAdapter = new MySqlDataAdapter("SELECT * FROM paciente ORDER By ID", mConn);
                mAdapter.Fill(mDataSet, "paciente");
                dataGridView1.DataSource = mDataSet;
                dataGridView1.DataMember = "paciente";

                mConn.Close();
            }

        }

        private void bt_carrega_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedRows[0].Index
            //MessageBox.Show(mDataSet.Tables["paciente"].Rows[]);
            //foreach (DataTable table in mDataSet.Tables)
            //    foreach (DataRow row in table.Rows)
            //        foreach (DataColumn column in table.Columns)
            //            if (row[column] != null)
            //                Console.WriteLine(row[column]);

            try
            {
                DataRow row = mDataSet.Tables["paciente"].Rows[dataGridView1.SelectedRows[0].Index];
                MessageBox.Show(row["Nome_Paciente"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o banco de dados" + ex.ToString() + "\n Você carregou a tabela ?");
            }
        }
    }
}
