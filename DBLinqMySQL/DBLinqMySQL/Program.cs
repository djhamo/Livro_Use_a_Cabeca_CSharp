using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBLinqMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=prosam;uid=root;pwd=;");

            try
            {
                mConn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine("Erro de conexão com o banco de dados {0}", ex.ToString());
                        break;
                }
                mConn.Close();
            }

                CdCol context = new CdCol(mConn);
                var query = from it in context.CdS
                            orderby it.ID
                            select it;
                foreach (CdS disk in query)
                {
                    Console.WriteLine("{0} - {1} | {2} - Year {3}", disk.ID, disk.TItel, disk.Interpret, disk.JAhR);
                    //comp.ShowAll();
                }

                Console.ReadLine();
                CdS first = context.CdS.First();

                Console.WriteLine("{0} - {1} | {2} - Year {3}", first.ID, first.TItel, first.Interpret, first.JAhR);
                mConn.Close();

        }
    }
}
