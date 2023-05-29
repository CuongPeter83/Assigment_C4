namespace Assignment.Models.Data
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public virtual IEnumerable<Product> Products { get;}
    }
}
