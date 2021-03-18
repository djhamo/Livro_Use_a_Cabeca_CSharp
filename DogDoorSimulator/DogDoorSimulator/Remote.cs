﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorSimulator
{
    class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("Pressionando o botão do controle remoto...");
            if (door.isOpen())
            {
                door.close();
            }
            else
            {
                door.open();
            }
        }
    }
}
