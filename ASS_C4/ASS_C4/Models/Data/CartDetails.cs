namespace Assignment.Models.Data
{
	public class CartDetails
	{
		public Guid ID { get; set; }
		public Guid UserID { get; set; }
		public Guid IDSp { get; set; }
		public int Quantity { get; set; }
		public virtual Product Product { get; set; }
		public virtual Cart Cart { get; set; }
	}
}
