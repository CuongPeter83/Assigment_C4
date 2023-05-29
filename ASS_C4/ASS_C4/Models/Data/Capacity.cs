namespace Assignment.Models.Data
{
    public class Capacity
    {
        public Guid ID { get; set; }    
        public int Capacitys { get; set; }
        public string Description { get; set;}
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
