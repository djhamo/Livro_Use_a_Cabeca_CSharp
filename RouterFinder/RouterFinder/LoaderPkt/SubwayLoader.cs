using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouterFinder.SubwayPkt;
using System.IO;

namespace RouterFinder.LoaderPkt
{
    class SubwayLoader
    {
        //public Subway subway { get; private set; }

        public SubwayLoader()
        {
            //subway = new Subway();
        }

        public Subway loadFromFile(string subwayFile)
        {
            Subway subway;
            using (StreamReader reader = new StreamReader(subwayFile))
            {
                subway = new Subway();
                loadStation(subway, reader);
                string lineName = reader.ReadLine();
                while ((lineName != null) && (lineName.Length > 0) && !(reader.EndOfStream))
                {
                    loadLine(subway, reader, lineName);
                    lineName = reader.ReadLine();
                }
            }

            return subway;
        }

        private void loadStation(Subway subway, StreamReader reader)
        {
            string currentLine = reader.ReadLine();
            while (currentLine.Length > 0)
            {
                subway.addStation(currentLine);
                currentLine = reader.ReadLine();
            }
        }

        private void loadLine(Subway subway, StreamReader reader, String lineName)
        {
            string station1Name = reader.ReadLine();
            string station2Name = reader.ReadLine();

            while ((station2Name != null) && (station2Name.Length > 0))
            {
                subway.addConection(station1Name, station2Name, lineName);
                station1Name = station2Name;
                station2Name = reader.ReadLine();
            }
        }
    }
}
