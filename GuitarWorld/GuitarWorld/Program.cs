using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GuitarWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            InitializeInventory(inventory);

            InstrumentSpec whatErinLike = Factory.newGuitarSpec(Builder.FENDER, "StratoCastor", TypeGuitar.ELECTRIC, 6, Wood.ALDER, Wood.ALDER);

            List<Instrument> guitarSearch = inventory.search(whatErinLike);
            if (guitarSearch.Count > 0)
            {
                foreach (Instrument gt in guitarSearch)
                {
                    Console.WriteLine("Erin, talvez vc goste desta:");
                    Console.WriteLine(gt);
                    Console.WriteLine();
                }
                
            }
            else
            {
                Console.WriteLine("Desculpe Erin, não temos nada para você.");
            }
            Console.ReadLine();
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.addInstument("11277", 3999.95, Factory.newGuitarSpec(Builder.COLLINGS, "CJ", 
                TypeGuitar.ACOUSTIC, 6, Wood.INDIAN_ROSEWOOD, Wood.SITKA));
            inventory.addInstument("V95693", 1499.95, Factory.newGuitarSpec(Builder.FENDER, "Stratocastor", 
                TypeGuitar.ELECTRIC, 6, Wood.ALDER, Wood.ALDER));
            inventory.addInstument("V9512", 1549.95, Factory.newGuitarSpec(Builder.FENDER, "Stratocastor", 
                TypeGuitar.ELECTRIC, 6, Wood.ALDER, Wood.ALDER));
            inventory.addInstument("122784", 5495.95, Factory.newGuitarSpec(Builder.MARTIN, "D-18", 
                TypeGuitar.ACOUSTIC, 6, Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.addInstument("76531", 6295.95, Factory.newGuitarSpec(Builder.MARTIN, "OM-28",
                TypeGuitar.ACOUSTIC, 6, Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.addInstument("70108276", 2295.95, Factory.newGuitarSpec(Builder.GIBSON, "Les Paul", 
                TypeGuitar.ELECTRIC, 6, Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.addInstument("82765501", 1890.95, Factory.newGuitarSpec(Builder.GIBSON, "SG '61 Reissue", 
                TypeGuitar.ELECTRIC, 6, Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.addInstument("77023", 6275.95, Factory.newGuitarSpec(Builder.MARTIN, "D-28", 
                TypeGuitar.ACOUSTIC, 6, Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.addInstument("1092", 12995.95, Factory.newGuitarSpec(Builder.OLSON, "SJ", 
                TypeGuitar.ACOUSTIC, 12, Wood.INDIAN_ROSEWOOD, Wood.CEDAR));
            inventory.addInstument("566-62", 8999.95, Factory.newGuitarSpec(Builder.RYAN, "Cathedral", 
                TypeGuitar.ACOUSTIC, 12, Wood.COCOBOLO, Wood.CEDAR));
            inventory.addInstument("6 29584", 2100.95, Factory.newGuitarSpec(Builder.PRS, "Dave Navarro Signature", 
                TypeGuitar.ELECTRIC, 6, Wood.MAHOGANY, Wood.MAPLE));

            inventory.addInstument("9019920", 5495.99, Factory.newMandolinSpec(Builder.GIBSON, "F5-G",
                TypeGuitar.ACOUSTIC, Wood.BORDO, Wood.BORDO));

            inventory.addInstument("8900231", 2945.95, Factory.newBanjoSpec(Builder.GIBSON, "RB-3",
                TypeGuitar.ACOUSTIC, 5, Wood.BORDO));

        }

    }

}
