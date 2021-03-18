using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FindExample
{
    class Program
    {
        private static string IDtoFind = "bk109";

        private static List<Book> Books = new List<Book>();

        static void Main(string[] args)
        {
            List<Part> parts = new List<Part>();

            parts.Add(new Part() { PartName = "crank arm", PartId = 1234} );
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\n Constains: Part with Id=1734: {0}",
                parts.Contains(new Part { PartId = 1734, PartName = ""}));

            Console.WriteLine("\n Find: Part where name constains 'seat' {0}",
                parts.Find(x => x.PartName.Contains("seat")));

            Console.WriteLine("\n Exits: Part with Id=1444: {0}",
                parts.Exists(x => x.PartId == 1444));

            Console.ReadKey();

            FillList();

            Book result = Books.Find(
                delegate(Book bk)
                {
                    return bk.ID == IDtoFind;
                });
            if (result != null)
            {
                DisplayResult(result, "Find by ID: " + IDtoFind);
            }
            else
            {
                Console.WriteLine("\nNot Fount: {0}", IDtoFind);
            }

            result = Books.FindLast(
                delegate(Book bk)
                {
                    DateTime year2001 = new DateTime(2001, 01, 01);
                    return bk.Publish_date < year2001;
                });
            if (result != null)
            {
                DisplayResult(result, "Last Book in collection published before 2001:");
            }
            else
            {
                Console.WriteLine("\nNot Fount: {0}", IDtoFind);
            }

            List<Book> results = Books.FindAll(FindComputer);
            if (results.Count != 0)
            {
                DisplayResults(results, "All Computers:");
            }
            else
            {
                Console.WriteLine("\nNo books found");
            }

            results = Books.FindAll(
                delegate(Book bk)
                {
                    return bk.Price < 10.00;
                });
            if (results.Count != 0)
            {
                DisplayResults(results, "Books Under $10:");
            }
            else
            {
                Console.WriteLine("\nNo books found");
            }

            Console.WriteLine();
            int ndx = Books.FindIndex(FindComputer);
            Console.WriteLine("Index of first computer book: {0}", ndx);

            ndx = Books.FindLastIndex(FindComputer);
            Console.WriteLine("Index of last computer book: {0}", ndx);

            int mid = Books.Count / 2;
            ndx = Books.FindIndex(mid, mid, FindComputer);
            Console.WriteLine("Index of first computer book in the second half of the collection: {0}", ndx);

            ndx = Books.FindLastIndex(Books.Count - 1, mid, FindComputer);
            Console.WriteLine("Index of last computer book in the second half of the collection: {0}", ndx);

            Console.ReadKey();

        }

        private static void FillList()
        {
            XElement xTree = XElement.Load(@"c:\temp\books.txt");
            IEnumerable<XElement> elements = xTree.Elements();

            foreach (XElement el in elements)
            {
                Book book = new Book();
                book.ID = el.Attribute("id").Value;
                IEnumerable<XElement> props = el.Elements();
                foreach (XElement p in props)
                {
                    if (p.Name.ToString().ToLower() == "author")
                    {
                        book.Author = p.Value;
                    }
                    else if (p.Name.ToString().ToLower() == "title")
                    {
                        book.Title = p.Value;
                    }
                    else if (p.Name.ToString().ToLower() == "genre")
                    {
                        book.Genre = p.Value;
                    }
                    else if (p.Name.ToString().ToLower() == "price")
                    {
                        book.Price = Convert.ToDouble(p.Value);
                    }
                    else if (p.Name.ToString().ToLower() == "pubish_date")
                    {
                        book.Publish_date = Convert.ToDateTime(p.Value);
                    }
                    else if (p.Name.ToString().ToLower() == "description")
                    {
                        book.Description = p.Value;
                    }

                }
                Books.Add(book);
            }

            DisplayResults(Books, "All books:");
        }

        private static bool FindComputer(Book bk)
        {
            if (bk.Genre == "Computer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DisplayResult(Book result, string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                result.ID, result.Author, result.Title, result.Genre, result.Price,
                result.Publish_date.ToShortDateString());
            Console.WriteLine();            
        }

        private static void DisplayResults(List<Book> results, string title)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            foreach (Book b in results)
            {
                Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                b.ID, b.Author, b.Title, b.Genre, b.Price, b.Publish_date.ToShortDateString());   
            }
            Console.WriteLine();
        }
    }
}
