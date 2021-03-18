using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
//Para o conection state
using System.Data;

//Tem que adicionar o DBLinq.dll e o DBLing.MySQL.dll como extensão
//C:\DbLinq>dbmetal /server:127.0.0.1 /user:root /password: /provider:MySql /database:cdcol /language:C# /code saida.cs
//C:\DbLinq>dbmetal /server:127.0.0.1 /user:root /password: /provider:MySql /database:cdcol /language:C# /dbml saida.dbml

namespace CRMySQLRaw
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MySqlConnection mConn = new MySqlConnection(" Persist Security Info=False;server=Rocket;database=cdcol;uid=root;pwd=;");
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
                        Console.WriteLine("Erro de conexão com o banco de dados" + ex.ToString());
                        break;
                }
                mConn.Close();
            }
            if (mConn.State == ConnectionState.Open)
            {
                CdCol context = new CdCol(mConn);

                var query = from it in context.CdS
                            orderby it.ID
                            select it;

                foreach (CdS comp in query)
                {
                    Console.WriteLine("{0} - {1} | {2}", comp.ID, comp.TItel, comp.Interpret);
                    
                }
                Console.ReadLine();
                mConn.Close();
            }

        }
    }
}
