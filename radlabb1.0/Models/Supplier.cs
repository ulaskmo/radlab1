namespace radlabb1._0.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public Supplier(int supplierID, string supplierName, string address1, string address2)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Address1 = address1;
            Address2 = address2;
        }
    }
}