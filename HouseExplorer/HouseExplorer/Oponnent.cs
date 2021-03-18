using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExplorer
{
    class Oponnent
    {
        public Oponnent(Location startingLocation)
        {
            this.myLocation = startingLocation;
            random = new Random();
        }

        private Location myLocation;
        private Random random;
        //private int numberMoves = 10;

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                //Checa se Tem porta na saida e se vai passá-la
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                {
                    myLocation = LocationWithDoor.DoorLocation;
                }

                bool hidden = false;
                while (!hidden)
                {
                    //Escolhe aleatoramente uma saida
                    int rand = random.Next(myLocation.Exits.Length);
                    myLocation = myLocation.Exits[rand];
                    if (myLocation is IHidingPlace)
                        //Se tiver esconderíjio fica senão procura denovo
                        hidden = true;
                }
            }

        }

        public bool Check(Location newLocation)
        {
            return (myLocation == newLocation);
        }
    }
}
