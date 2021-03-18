using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace FilesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PARTENOME = 1;

            string[] files = Directory.GetFiles(@"C:\Users\tiago\Downloads", "*.jpg", SearchOption.AllDirectories);

            // Display all the files.
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadLine();

            foreach (string file in Directory.EnumerateFiles(@"C:\Users\tiago\Downloads\MachineGun\Fam", "*.*", SearchOption.AllDirectories))
            {

                string teste = Path.GetFileNameWithoutExtension(file);
                if (teste.Contains(" - "))
                {
                    string[] words = Regex.Split(teste, @" - ");
                    string pdestino = words[PARTENOME];
                    string porig = Path.GetDirectoryName(file);
                    string fileini = Path.GetFileName(file);
                    string destino = porig + "\\" + pdestino;
                    string destinofile = porig + "\\" + pdestino + "\\" + fileini;
                    Console.WriteLine("{0} => {1}", file, destinofile);

                    if (!Directory.Exists(destino))
                    {
                        Console.WriteLine("Criando diretório {0}", destino);
                        Directory.CreateDirectory(destino);
                    }
                    Console.WriteLine("Movendo {0} => {1}", file, destinofile);
                    File.Move(file, destinofile);
                }
            }
            Console.ReadLine();

        }
    }
}
