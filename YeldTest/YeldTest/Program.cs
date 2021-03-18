using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace YeldTest
{
    class Program
    {
        static IEnumerable<string> NameEnumerator()
        {
            yield return "Bob";
            yield return "Harry";
            yield return "Joe";
            yield return "Frank";
        }

        private static XDocument GetStarBuzzData()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Starbuzz Customer Loyality Data"),
                new XElement("starbuzzData",
                    new XAttribute("storeName", "Park Slope"),
                    new XAttribute("location", "Brooklyn NY"),
                    new XElement("person",
                        new XElement("personalInfo",
                            new XElement("name", "Janet Venutian"),
                            new XElement("zip", 11215)),
                        new XElement("favoriteDrink", "Choco Macchiato"),
                        new XElement("moneySpent", 255),
                        new XElement("visits", 50)),
                    new XElement("person",
                        new XElement("personalInfo",
                            new XElement("name", "Liz Nelson"),
                            new XElement("zip", 11238)),
                        new XElement("favoriteDrink", "Double Cappuccino"),
                        new XElement("moneySpent", 150),
                        new XElement("visits", 35)),
                    new XElement("person",
                        new XElement("personalInfo",
                            new XElement("name", "Matt Franks"),
                            new XElement("zip", 11217)),
                        new XElement("favoriteDrink", "Zasty Lemon Chai"),
                        new XElement("moneySpent", 75),
                        new XElement("visits", 15)),
                    new XElement("person",
                        new XElement("personalInfo",
                            new XElement("name", "Joe Ng"),
                            new XElement("zip", 11217)),
                        new XElement("favoriteDrink", "Banana Split in a Cup"),
                        new XElement("moneySpent", 60),
                        new XElement("visits", 10)),
                    new XElement("person",
                        new XElement("personalInfo",
                            new XElement("name", "Sarah Kalter"),
                            new XElement("zip", 11215)),
                        new XElement("favoriteDrink", "Boring Coffe"),
                        new XElement("moneySpent", 110),
                        new XElement("visits", 15))
                    ));

            return doc;
        }

        static void Main(string[] args)
        {
            Guy bob = new Guy("Bob", 43, 100);
            Guy joe = new Guy("Joe", 41, 100);

            Random random = new Random();

            while (true)
            {
                int amountToGive = random.Next(20);
                
                if (amountToGive < 10)
                    continue;

                if (joe.ReceiveCash(bob.GiveCash(amountToGive)) == 0)
                    break;

                Console.WriteLine("Bob gave Joe {0} bucks, Joe has {1} bucks, Bob has {2} bucks", amountToGive, joe.Cash, bob.Cash);
            }

            Console.WriteLine("Bob's left with {0} bucks", bob.Cash);
            Console.ReadLine();

            Console.WriteLine("SportCollection contents:");
            SportCollection sportCollection = new SportCollection();
            foreach (Sport sport in sportCollection)
	        {
                Console.WriteLine(sport.ToString());
	        }
            Console.WriteLine("Sport #3 is {0}", sportCollection[3].ToString());
            Console.ReadLine();

            IEnumerable<string> names = NameEnumerator();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            GuyCollection guyCollection = new GuyCollection();
            Console.WriteLine("Adding two guys and modifying one guy");
            guyCollection["Bob"] = guyCollection["Joe"] + 3;
            guyCollection["Bill"] = 57;
            guyCollection["Harry"] = 31;

            foreach (Guy guy in guyCollection)
            {
                Console.WriteLine(guy.ToString());
            }
            Console.ReadLine();

            GuyCollection2 guyCollection2 = new GuyCollection2();
            Console.WriteLine("Testando GuyCollection2 = Adding two guys and modifying one guy");
            //guyCollection2["Bob"] = guyCollection2["Joe"] + 3;
            Guy temp = new Guy("Bob", guyCollection2["Joe"].Age + 13, guyCollection2["Joe"].Cash);
            guyCollection2["Bob"] = temp;
            guyCollection2[57] = new Guy("Bill", 57, 1231);
            guyCollection2[31] = new Guy("Harry", 31, 8654);

            foreach (Guy guy in guyCollection2)
            {
                Console.WriteLine(guy.ToString());
            }
            Console.ReadLine();

            DataContractSerializer serializer = new DataContractSerializer(typeof(SerializableGuy));
            SerializableGuy guyToWrite = new SerializableGuy("Joe", 37, 150);
            using (FileStream writer = new FileStream("serialized_guy.xml", FileMode.Create))
            {
                serializer.WriteObject(writer, guyToWrite);
            }

            SerializableGuy guyToRead = null;
            using (FileStream inputStream = new FileStream("serialized_guy.xml", FileMode.Open))
            using (XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(inputStream, new XmlDictionaryReaderQuotas()))
            {
                guyToRead = serializer.ReadObject(reader, true) as SerializableGuy;
            }

            Console.WriteLine(guyToRead);
            Console.ReadLine();

            XDocument doc = GetStarBuzzData();
            Console.WriteLine(doc.ToString());
            //doc.Save("starbuzzData.xml");

            XDocument anotherDoc = XDocument.Load("starbuzzData.xml");

            var data = from item in doc.Descendants("person")
                       select new
                       {
                           drink = item.Element("favoriteDrink").Value,
                           moneySpent = item.Element("moneySpent").Value,
                           zipCode = item.Element("personalInfo").Element("zip").Value,
                           maneName = item.Element("personalInfo").Element("name").Value
                       };

            foreach (var p in data)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("Só pra lembra {0} R$ {1}", p.maneName, p.moneySpent);
            }
            Console.ReadLine();

            var zipcodeGroups = from item in doc.Descendants("person")
                                group item.Element("favoriteDrink").Value
                                by item.Element("personalInfo").Element("zip").Value
                                    into zipcodeGroup
                                    select zipcodeGroup;

            foreach (var group in zipcodeGroups)
            {
                Console.WriteLine("{0} favorite drink in {1}", group.Distinct().Count(), group.Key);
            }
            Console.ReadLine();

            List<AddressDetails> AddressList = new List<AddressDetails>();
            Console.WriteLine("Testando List Address = XML");

            AddressDetails tempAd = new AddressDetails();
            tempAd.HouseNo = 4;
            tempAd.StreetName = "ABC";
            tempAd.City = "Delhi";
            AddressList.Add(tempAd);

            tempAd = new AddressDetails();
            tempAd.HouseNo = 3;
            tempAd.StreetName = "ABCD";
            tempAd.City = "New Delhi";
            AddressList.Add(tempAd);

            XmlSerializer serializerXXX = new XmlSerializer(typeof(List<AddressDetails>));
            using (TextWriter writer = new StreamWriter("Address.xml"))
            {
                serializerXXX.Serialize(writer, AddressList);
            }

            List<AddressDetails> AddressList2 = null;
            using (TextReader reader = new StreamReader("Address.xml"))
            {
                AddressList2 = serializerXXX.Deserialize(reader) as List<AddressDetails>;
            }
            foreach (AddressDetails add in AddressList2)
            {
                Console.WriteLine(add);
            }
            Console.ReadLine();


            AddressDirectory AddressListTTT = new AddressDirectory();
            AddressListTTT.DirectoryOwner = "Tiago Fernandes DAgostino";
            AddressListTTT.PinCode = "125415";

            AddressDetails tt = new AddressDetails();
            tt.AddressId = "1";
            tt.StreetName = "Bahia";
            tt.HouseNo = 2139;
            tt.City = "Votuporanga";
            AddressListTTT.address.Add(tt);

            tt = new AddressDetails();
            tt.AddressId = "2";
            tt.HouseNo = 4;
            tt.StreetName = "ABC";
            tt.City = "Delhi";
            AddressListTTT.address.Add(tt);
 
            tt = new AddressDetails();
            tt.AddressId = "3";
            tt.HouseNo = 3;
            tt.StreetName = "ABCD";
            tt.City = "New Delhi";
            AddressListTTT.address.Add(tt);

            Designation ttDesi = new Designation();
            ttDesi.JobType = "Engenheiro";
            ttDesi.place = "São Paulo";
            AddressListTTT.designation = ttDesi;

            serializerXXX = new XmlSerializer(typeof(AddressDirectory));
            using (TextWriter writer = new StreamWriter("Address2.xml"))
            {
                serializerXXX.Serialize(writer, AddressListTTT);
            }

            using (TextReader reader = new StreamReader("Address2.xml"))
            {
                AddressListTTT = serializerXXX.Deserialize(reader) as AddressDirectory;
            }

            Console.WriteLine("Owner: {0} - Pin:{1}", AddressListTTT.DirectoryOwner, AddressListTTT.PinCode);
            Console.WriteLine("Job: {0} - Place:{1}", AddressListTTT.designation.JobType, AddressListTTT.designation.place);
            foreach (AddressDetails add in AddressListTTT.address)
            {
                Console.WriteLine(add);
            }
            Console.ReadLine();
        }

    }
}
