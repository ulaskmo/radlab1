namespace radlabb1._0.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryID { get; set; }

        public Product(int productID, string description, int quantity, decimal unitPrice, int categoryID)
        {
            ProductID = productID;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            CategoryID = categoryID;
        }
    }
}