using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmDemoContext;


namespace CRMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmDemoDataContext context = new CrmDemoDataContext();
            var query = from it in context.Companies
                        orderby it.CompanyID
                        select it;

            foreach (Company comp in query)
            {
                Console.WriteLine("{0} - {1} | {2}", comp.CompanyID, comp.CompanyName, comp.Country);
                //comp.ShowAll();
            }

            Console.ReadLine();

            var query2 = from pit in context.Products
                        orderby pit.ProductID
                        select pit;
            foreach (Product prod in query2)
            {
                Console.WriteLine("{0} - {1} - ${2}", prod.ProductID, prod.ProductName, prod.Price);
            }

            Console.ReadLine();

            var query3 = from it3 in context.Companies
                        orderby it3.CompanyID
                        select it3;

            foreach (Company comp2 in query3)
            {
                if (comp2.PrimaryContact > 0)
                {
                    Console.WriteLine("{0} | {1} | {2}",
                      comp2.CompanyName, comp2.Personcontact_PrimaryContact.FirstName,
                      comp2.Personcontact_PrimaryContact.LastName);
                }
            }

            Console.ReadLine();

            // Create a new category
            Productcategory newCategory = new Productcategory();
            newCategory.CategoryID = 1000;
            newCategory.CategoryName = "New category";

            // Create a new product
            Product newProduct = new Product();
            newProduct.ProductID = 2000;
            newProduct.ProductName = "New product";
            newProduct.Price = 20;

            // Associate the new product with the new category
            newProduct.Productcategory = newCategory;
            context.Products.InsertOnSubmit(newProduct);

            // Send the changes to the database.
            // Until you do it, the changes are cached on the client side.
            context.SubmitChanges();

            // Request the new product from the database
            var query4 = from it in context.Products
                        where it.ProductID == 2000
                        select it;

            // Since we query for a single object instead of a collection, we can use the method First()
            Product product = query4.First();
            Console.WriteLine("{0} | {1} | {2}", product.Productcategory.CategoryName, product.ProductName, product.Price);
            Console.ReadLine();

            product.ProductName = "Edited product";
            product.Price = 15;
            context.SubmitChanges();

            Console.WriteLine("{0} | {1} | {2}", product.Productcategory.CategoryName, product.ProductName, product.Price);
            Console.ReadLine();

            context.Products.DeleteOnSubmit(newProduct);
            context.Productcategories.DeleteOnSubmit(newCategory);
            context.SubmitChanges();

            // Request the new product from the database
            var query5 = from it in context.Products
                         where it.ProductID == 2000
                         select it;

            // Since we query for a single object instead of a collection, we can use the method First()
            Product product2 = query5.First();
            Console.WriteLine("{0} | {1} | {2}", product2.Productcategory.CategoryName, product2.ProductName, product2.Price);
            Console.ReadLine();
        }
    }
}
