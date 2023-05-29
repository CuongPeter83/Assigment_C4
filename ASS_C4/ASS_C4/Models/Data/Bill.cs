namespace Assignment.Models.Data
{
	public class Bill
	{
		public Guid ID { get; set; }
		public Guid UserId { get; set; }
		public string MaHD { get; set; }
		public DateTime CreateDate { get; set; }
        public DateTime Receiveddate { get; set; }
        public int Status { get; set; }
		public virtual IEnumerable<BillDetail> BillDetails { get; set; }
		public virtual User User { get; set; }
	}
}
