namespace Assignment.Models.Data
{
	public class Cart
	{
		public Guid UserID { get; set; }
		public string Description { get; set; }

		public virtual IEnumerable<CartDetails> CartDetail { get; set;}
		public virtual User User { get; set; }
		
	}
}
