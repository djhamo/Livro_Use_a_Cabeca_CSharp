using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExplorer
{
    class Outside : Location        
    {
        public Outside(string name, bool isHot)
            : base(name)
        {
            this.hot = isHot;
        }
        private bool hot;
        public bool Hot { get { return hot; } }

        public override string Description
        {
            get { return base.Description + "\n It's very hot here."; }
        
        }
    }
}
