namespace Assignment.Models.Data
{
	public class BillDetail
	{
		public Guid Id { get; set; }
		public Guid IdHD { get; set; }
		public Guid IdSp { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
		public virtual Bill Bills { get; set; }
		public virtual Product Product { get; set; }
	}
}
