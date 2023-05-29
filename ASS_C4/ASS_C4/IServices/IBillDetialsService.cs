using Assignment.Models.Data;

namespace Assignment.IServices
{
	public interface IBillDetialsService
	{
		public bool AddBillDetails(BillDetail bd);
		//public bool UpdateBillDetails(BillDetail bd);

		public List<BillDetail> GetBillDetails();
		public BillDetail GetBillDetailById(Guid id);
	}
}
