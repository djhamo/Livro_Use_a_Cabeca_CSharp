using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExplorer
{
    class Room : Location
    {
        public Room(string name, string decoration)
            : base(name) 
        {
            this.decoration = decoration;
        }

        private string decoration;
        public string Decoration
        {
            get { return decoration; }

        }
        public override string Description
        {
            get { return base.Description + "\n You see " + Decoration + " here."; }

        }
    }
}
