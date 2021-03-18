using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RouterFinder.LoaderPkt;
using RouterFinder.SubwayPkt;

namespace RouterFinder.Test
{
    [TestClass]
    public class UnitTester
    {
        [TestMethod]
        public void LoadTester()
        {
            try
            {
                SubwayLoader loader1 = new SubwayLoader();
                Subway objectville = loader1.loadFromFile(@".\LoaderPkt\ObjecVille.txt");

                Console.WriteLine("Testando Estações");
                bool result = ((objectville.hasStation("DRY Drive"))
                    && objectville.hasStation("Weather-O-Rama, inc.")
                    && objectville.hasStation("Boards 'R' Us"));
                Assert.AreEqual(true, result);
                if (result)   
                {
                    Console.WriteLine("As estações DRY Drive, Weather-O-Rama, inc. e Boards 'R' Us foram encontradas");
                }
                else
                {
                    Console.WriteLine("Falha no teste da estação");
                }

                Console.WriteLine("Testando Conexões");
                result = (objectville.hasConection("DRY Drive", "Head First Theater", "Meyer Line")
                    && objectville.hasConection("UML Walk", "HTML Heights", "Wirfs-Brock Line")
                    && objectville.hasConection("Head First Theater", "Infinite Circle", "Rumbaugh Line"));
                Assert.AreEqual(true, result);
                if (result)
                {
                    Console.WriteLine("Teste de conexão executado com sucesso");
                }
                else
                {
                    Console.WriteLine("Falha no teste de Conexão");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        [TestMethod]
        public void ShowStations()
        {
            SubwayLoader loader1 = new SubwayLoader();
            Subway objectville = loader1.loadFromFile(@".\LoaderPkt\ObjecVille.txt");

            objectville.showStations();
        }
    }
}
