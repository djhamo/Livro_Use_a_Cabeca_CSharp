using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    class Safe
    {
        private Jewels content = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
                return content;
            else
                return null;
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
