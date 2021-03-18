using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DogDoorSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Config mConfig = INIFile.getConfig;

            int sleepTime = mConfig.TimeAutoClose + 1000;

            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido late para sair...");
            remote.pressButton();
            Console.WriteLine("Fido saiu...");
            remote.pressButton();
            Console.WriteLine("Fido já terminou...");
            remote.pressButton();
            Console.WriteLine("Fido voltou pra dentro...");
            remote.pressButton();
            Console.ReadLine();

            Console.WriteLine("Teste de fechamento automático");
            Console.WriteLine("Fido late para sair...");
            remote.pressButton();
            Console.WriteLine("Aguarde 30s");
            Thread.Sleep(sleepTime); 
            Console.ReadLine();

            Console.WriteLine("Teste de fechamento automático com cachorro lá fora");
            Console.WriteLine("Fido late para sair...");
            remote.pressButton();
            Console.WriteLine("Aguarde 30s");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Fido já terminou...");
            remote.pressButton();
            Console.WriteLine("Aguarde 30s");
            Thread.Sleep(sleepTime);
            Console.ReadLine();

            Bark mBark = new Bark("Au");
            door.allowedBarks.Add(new Bark("Rolf"));
            door.allowedBarks.Add(new Bark("Auuuuuuu"));
            door.allowedBarks.Add(mBark);
            
            BarkRecogniser recognizer = new BarkRecogniser(door);
            Console.WriteLine("Fido Comerça a Latir...");
            recognizer.recognize(mBark);
            Console.WriteLine("Fido já terminou...");
            Thread.Sleep(sleepTime);
            Console.WriteLine("... mas ele está preso lá fora!");
            Console.WriteLine("Fido Comerça a Latir...");
            recognizer.recognize(mBark);
            Console.WriteLine("Fido voltou pra dentro...");
            Console.ReadLine();

            Console.WriteLine("Maria DogSimulator...");
            DogDoor door2 = new DogDoor();
            door2.allowedBarks.Add(new Bark("rolf"));
            door2.allowedBarks.Add(new Bark("rowlf"));
            door2.allowedBarks.Add(new Bark("rooowlf"));
            door2.allowedBarks.Add(new Bark("rawlf"));
            door2.allowedBarks.Add(new Bark("woolf"));

            BarkRecogniser recognizer2 = new BarkRecogniser(door2);
            Remote remote2 = new Remote(door2);

            Console.WriteLine("Bruce começa a latir..");
            recognizer2.recognize(new Bark("rolf"));
            Console.WriteLine("Bruce saiu...");
            Thread.Sleep(sleepTime);

            Console.WriteLine("Bruce já terminou");
            Console.WriteLine("... mas ele está preso lá fora...");

            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("Um cachorro começa a latir");
            recognizer2.recognize(smallDogBark);
            Thread.Sleep(sleepTime);

            Console.WriteLine("Bruce começa a latir..");
            recognizer2.recognize(new Bark("rooolf"));
            Console.WriteLine("Bruce voltou para dentro...");
            
            Console.ReadLine();

        }
    }
}
