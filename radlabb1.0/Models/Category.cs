namespace radlabb1._0.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }

        public Category(int categoryID, string description)
        {
            CategoryID = categoryID;
            Description = description;
        }
    }
}