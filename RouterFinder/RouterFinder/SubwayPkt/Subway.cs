using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.SubwayPkt
{
    class Subway
    {
        private List<Station> stations;
        private List<Conection> conections;

        public Subway()
        {
            stations = new List<Station>();
            conections = new List<Conection>();
        }

        public void addStation(string station)
        {
            if (!(this.hasStation(station)))
            {
                Station stat = new Station(station);
                stations.Add(stat);
            }
        }

        public bool hasStation(String station)
        {
            return stations.Contains(new Station(station));
        }

        public void addConection(String station1Name, String station2Name, String lineName)
        {
            if ((this.hasStation(station1Name))
                && (this.hasStation(station2Name)))
            {
                Station st1 = new Station(station1Name);
                Station st2 = new Station(station2Name);
                Conection ct1 = new Conection(st1, st2, lineName);
                conections.Add(ct1);
                Conection ct2 = new Conection(st2, st1, lineName);
                conections.Add(ct2);
            }
            else
            {
                throw new ArgumentException("Conexão Inválida");
            }
        }

        public bool hasConection(string station1Name, string station2Name, string lineName)
        {
            Station st1 = new Station(station1Name);
            Station st2 = new Station(station2Name);

            foreach (Conection con in conections)
            {
                if (con.LineName.ToLower() == lineName.ToLower())
                {
                    if (con.Station1 == st1 && con.Station2 == st2)
                    {
                        return true;
                    }
                } 
            }
            return false;
        }

        public void showStations()
        {
            Console.WriteLine("Stations:");
            foreach (Station st in stations)
            {
                Console.WriteLine("  {0}", st.Name);
            }
        }
    }
}
