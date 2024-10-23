using System;
using System.Linq;
using radlabb1._0.Models;

namespace radlabb1._0
{
    class Program
    { 
        static void Main(string[] args) 
        {
            // Assuming ProductModel, Categories, Products, and SupplierProducts are defined elsewhere in your project
            var productModel = new ProductModel();

            // List all Categories
            var categories = productModel.Categories.Select(c => c.Description).ToList(); // Ensure we have a list of strings
            Console.WriteLine("Categories:");
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }

            // List all Products
            var products = productModel.Products.Select(p => p.Description).ToList(); // Ensure we have a list of strings
            Console.WriteLine("\nProducts:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            // List Products with a Quantity <= 100
            var productsWithLowStock = productModel.Products.Where(p => p.Quantity <= 100)
                                                            .Select(p => p.Description).ToList(); // Ensure we have a list of strings
            Console.WriteLine("\nProducts with Quantity <= 100:");
            foreach (var product in productsWithLowStock)
            {
                Console.WriteLine(product);
            }

            // List Products with a Quantity > 120
            var productsWithHighStock = productModel.Products.Where(p => p.Quantity > 120)
                                                             .Select(p => p.Description).ToList(); // Ensure we have a list of strings
            Console.WriteLine("\nProducts with Quantity > 120:");
            foreach (var product in productsWithHighStock)
            {
                Console.WriteLine(product);
            }

            // List all Products together with their total value (Quantity * Unit Price)
            var productValues = productModel.Products.Select(p => new
            {
                p.Description,
                TotalValue = p.Quantity * p.UnitPrice
            }).ToList(); // Ensure we have a list
            Console.WriteLine("\nProducts and their total values:");
            foreach (var product in productValues)
            {
                Console.WriteLine($"{product.Description} - Total Value: {product.TotalValue:C}");
            }

            // List all Products in the Hardware Category
            var hardwareProducts = (from p in productModel.Products
                                   join c in productModel.Categories on p.CategoryID equals c.CategoryID
                                   where c.Description == "Hardware"
                                   select p.Description).ToList(); // Ensure we have a list of strings
            Console.WriteLine("\nHardware Products:");
            foreach (var product in hardwareProducts)
            {
                Console.WriteLine(product);
            }

            // List all Suppliers and their Parts ordered by supplier name
            var supplierProducts = (from sp in productModel.SupplierProducts
                                    join s in productModel.Suppliers on sp.SupplierID equals s.SupplierID
                                    join p in productModel.Products on sp.ProductID equals p.ProductID
                                    orderby s.SupplierName
                                    select new { s.SupplierName, p.Description }).ToList(); // Ensure we have a list
            Console.WriteLine("\nSuppliers and their parts:");
            foreach (var supplierProduct in supplierProducts)
            {
                Console.WriteLine($"{supplierProduct.SupplierName} supplies {supplierProduct.Description}");
            }
        }
    }
}