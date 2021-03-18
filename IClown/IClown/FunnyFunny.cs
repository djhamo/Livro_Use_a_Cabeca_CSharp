using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IClown
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string FunnyThingIHave)
        {
            this.funnyThingIHave = FunnyThingIHave;
        }
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Honk Honk! IHave a " + funnyThingIHave; }
        }

        public void Honk()
        {
            MessageBox.Show(FunnyThingIHave);
        }
    }
}
