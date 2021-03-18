using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.SubwayPkt
{
    class Conection
    {
        public Station Station1 { get; private set; }
        public Station Station2 { get; private set; }
        public string LineName { get; private set; }

        public Conection(Station station1, Station station2, string lineName)
        {
            this.Station1 = station1;
            this.Station2 = station2;
            this.LineName = lineName;
        }

        public override string ToString()
        {
            string saida = String.Format("Linha {0}: {1} -> {2}", LineName, Station1.Name, Station2.Name);
            return saida;
        }
    }
}
