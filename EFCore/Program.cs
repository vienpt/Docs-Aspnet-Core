using System;
using System.Collections.Generic;
using System.Linq;
using EFCore.Models;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            InsertProduct();
            ReadProduct();
            UpdateProduct();
            DeleteProduct();
            ReadProduct();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void InsertProduct()
        {
            // Create a new instance of the DbContext class.
            using (var db = new EFContext())
            {
                // Create a new instance of the domain class product and assign values to its properties.
                Product product = new Product
                {
                    Name = "Pen Drive"
                };
                // add it to the DbContext class so that Context becomes aware of the entity.
                db.Add(product);

                product = new Product
                {
                    Name = "Memory Card"
                };

                // add it to the DbContext class so that Context becomes aware of the entity.
                db.Add(product);

                // call the saveChanges method of the DBContext to persist the changes to the database.
                db.SaveChanges();
            }
            return;
        }

        // example code retrieves the Product using the Method Syntax
        // It uses the ToList() method of the DbSet
        // The ToList() sends the select query to the database and retrieves and converts the result into List of Products.
        private static void ReadProduct()
        {
            // Create a new instance of the DbContext class.
            using var db = new EFContext();
            List<Product> products = db.Products.ToList();
            foreach (Product p in products)
            {
                Console.WriteLine("{0}, {1}", p.Id, p.Name);
            }
            return;
        }

        private static void UpdateProduct()
        {
            // Create a new instance of the DbContext class.
            using EFContext db = new EFContext();
            Product product = db.Products.Find(1);
            product.Name = "Better Pen Drive";

            product = db.Products.Find(2);
            product.Name = "Better Memory Card";

            db.SaveChanges();
            return;
        }

        private static void DeleteProduct()
        {
            using var db = new EFContext();
            Product product = db.Products.Find(1);
            db.Products.Remove(product);
            db.SaveChanges();
            return;
        }

    }
}
