using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorStarbuzz.Interface
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string getDescription() 
        {
            return description;
        }

        public abstract decimal cost();

        public override string ToString()
        {
            return getDescription() + " $" + this.cost().ToString();
        }
    }
}
