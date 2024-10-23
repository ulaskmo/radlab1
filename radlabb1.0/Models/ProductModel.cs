using System;
using System.Collections.Generic;

namespace radlabb1._0.Models
{
    public class ProductModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<SupplierProduct> SupplierProducts { get; set; }

        public ProductModel()
        {
            // Initialize Categories
            Categories = new List<Category>
            {
                new Category(1, "Hardware"),
                new Category(2, "Electrical Appliances")
            };

            // Initialize Products
            Products = new List<Product>
            {
                new Product(1, "9 Inch Nails", 200, 0.1m, 1),
                new Product(2, "9 Inch Bolts", 120, 0.2m, 1),
                new Product(3, "Chimney Hoover", 10, 100.30m, 2),
                new Product(4, "Washing Machine", 7, 399.50m, 2)
            };

            // Initialize Suppliers
            Suppliers = new List<Supplier>
            {
                new Supplier(1, "ACME", "Collooney", "Sligo"),
                new Supplier(2, "Swift Electric", "Finglas", "Dublin")
            };

            // Initialize Supplier Products
            SupplierProducts = new List<SupplierProduct>
            {
                new SupplierProduct(1, 1, new DateTime(2012, 12, 12)),
                new SupplierProduct(1, 2, new DateTime(2017, 8, 13)),
                new SupplierProduct(2, 3, new DateTime(2022, 9, 9)),
                new SupplierProduct(2, 4, new DateTime(2024, 4, 11))
            };
        }
    }
}