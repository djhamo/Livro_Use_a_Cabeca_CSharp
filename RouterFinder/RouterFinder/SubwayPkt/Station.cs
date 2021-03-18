using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouterFinder.SubwayPkt
{
    class Station
    {
        public string Name { get; private set; }

        public Station(string name)
        {
            this.Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Station)
            {
                Station otherSt = obj as Station;
                return this.Name.ToLower() == otherSt.Name.ToLower();
            }
            return false;
        }

        public static bool operator ==(Station x, Station y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(Station x, Station y)
        {
            return !(x.Equals(y));
        }

        public override int GetHashCode()
        {
            return this.Name.ToLower().GetHashCode();
        }
    }
}
