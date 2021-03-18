using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld
{
    class Inventory
    {
        private List<Instrument> instruments = new List<Instrument>();

        public void addInstument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument inst = new Instrument(serialNumber, price, spec);            
            instruments.Add(inst);
        }

        public void addInstument(Instrument inst)
        {
            instruments.Add(inst);
        }

        public Instrument get(string serialNumber)
        {
            Instrument result = instruments.Find(
                delegate(Instrument inst) 
                { return inst.serialNumber == serialNumber; });
            if (result != null)
                return result;
            else
                return null;
        }

        public List<Instrument> search(InstrumentSpec searchInstrument)
        {

            List<Instrument> result = new List<Instrument>();

            foreach (Instrument gt in instruments)
            {
                InstrumentSpec mSpec = (InstrumentSpec)gt.spec;
                if (mSpec == searchInstrument)
                    result.Add(gt);
            }
            return result;
        }

    }
}
