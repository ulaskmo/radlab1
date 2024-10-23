using System;

namespace radlabb1._0.Models
{
    public class SupplierProduct
    {
        
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public DateTime DateFirstOffered { get; set; }

        public SupplierProduct(int supplierID, int productID, DateTime dateFirstOffered)
        {
            SupplierID = supplierID;
            ProductID = productID;
            DateFirstOffered = dateFirstOffered;
        }
    
    }
}