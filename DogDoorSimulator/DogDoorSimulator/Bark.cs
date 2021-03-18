using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorSimulator
{
    class Bark
    {
        public string sound { get; private set; }
        public Bark(string bark)
        {
            this.sound = bark;
        }

        public static bool operator ==(Bark x, Bark y)
        {
            if (x.sound == y.sound)
                return true;
            return false;
        }

        public static bool operator !=(Bark x, Bark y)
        {
            return !(x == y);
        }
    }
}
