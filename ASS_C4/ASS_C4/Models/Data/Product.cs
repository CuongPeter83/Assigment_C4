using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Models.Data
{
	public class Product
	{
		public Guid ID { get; set; }
		public Guid CategoryID { get; set; }
        public Guid? CapacityID { get; set; }
        public Guid SupplierID { get; set; }
        public string NameProduct { get; set; }
		public string Image { get; set; }
		public int Price { get; set; }
		public int AvailableQuantity { get; set; }
		public string Color { get; set; }	
        public string Description { get; set; }
        public string Features { get; set; }
        public int Status { get; set; }
		public virtual Supplier Supplier { get; set; }
        public virtual Capacity Capacity { get; set; }
		
		public virtual Category Category { get; set; }
		public virtual IEnumerable<BillDetail> BillDetails { get; set; }
		public virtual IEnumerable<CartDetails> CartDetail { get; set; }

		
	}
}
