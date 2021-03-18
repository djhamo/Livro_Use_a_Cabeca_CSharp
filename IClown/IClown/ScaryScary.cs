using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IClown
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string FunnyThingIHave, int numberOfScaryThings)
            : base (FunnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;

        public string ScaryThingIHave
        {
            get
            {
                return "I Have " + numberOfScaryThings + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha. You can't have my " + base.funnyThingIHave);
        }
    }
}
