namespace Assignment.Models.Data
{
    public class Supplier
    {
        public Guid ID { get; set; }
        public string NameSupplier { get; set; }
        public string DescriptionSupplier { get; set; }
        public virtual IEnumerable<Product> Product { get; set;}
    }
}
