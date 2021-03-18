using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExplorer
{
    class RoomWithDoor : RoomWithHiddingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidindNamePlace)
            : base(name, decoration, hidindNamePlace) 
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;
        public string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;
        public Location DoorLocation {
            get { return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
