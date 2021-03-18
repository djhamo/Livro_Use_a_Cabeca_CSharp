using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExplorer
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool isHot, string hidingPlaceName)
            : base (name, isHot)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        private string hidingPlaceName;
        public string HidingPlaceName 
        {
            get { return hidingPlaceName; } 
        }

        public override string Description
        {
            get { return base.Description + " Someone could hide " + hidingPlaceName + "."; }

        }
    }
}
