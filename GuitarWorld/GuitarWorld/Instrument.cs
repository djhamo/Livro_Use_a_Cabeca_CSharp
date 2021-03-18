using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld
{
    class Instrument
    {
        public String serialNumber { get; private set; }
        public double price { get; private set; }
        public InstrumentSpec spec { get; private set; }

        public Instrument(String serialNumber, double price, InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public override string ToString()
        {
            return String.Format("Nós temos {0} com as seguintes propriedades: \n SerialNuber# {1} \n{2} Ela pode ser sua por ${3} \n", spec.getProperty("InstrumentType"), serialNumber, spec, price);
        }
    }
}
