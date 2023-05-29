using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
	public class BillDetailService : IBillDetialsService
	{
		public Shopping_Dbcontext _context;
		public BillDetailService()
		{
			_context = new Shopping_Dbcontext();
		}
		public bool AddBillDetails(BillDetail bd)
		{
			try
			{
				_context.BillDetails.Add(bd);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public BillDetail GetBillDetailById(Guid id)
		{
			return _context.BillDetails.FirstOrDefault(c => c.IdSp == id);
		}

		public List<BillDetail> GetBillDetails()
		{
			return _context.BillDetails.ToList();
		}

		//public bool UpdateBillDetails(BillDetail bd)
		//{
		//	try
		//	{
		//		var = 
		//	} catch (Exception ex)
		//	{

		//	}
		//}
	}
}
