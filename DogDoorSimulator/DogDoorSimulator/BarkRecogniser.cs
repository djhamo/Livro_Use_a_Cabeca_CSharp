using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorSimulator
{
    class BarkRecogniser
    {
        private DogDoor door;

        public BarkRecogniser(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(Bark bark)
        {
            Console.WriteLine(" Bark Recognizer: Ouvi um '" + bark.sound + "'");
            List<Bark> allowedBarks = door.allowedBarks;
            foreach (Bark tbark in allowedBarks)
            {
                if (tbark == bark)
                {
                    door.open();
                    return;
                }
            }
            Console.WriteLine("Este cachorro não está cadastrado.");
        }
    }
}
