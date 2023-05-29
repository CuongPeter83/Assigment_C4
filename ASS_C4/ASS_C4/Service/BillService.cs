using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
	public class BillService : IBillSerivce
	{
		public Shopping_Dbcontext _context;
		public BillService() 
		{
			_context = new Shopping_Dbcontext();
		}
		public bool AddBill(Bill bill)
		{
			try
			{
				_context.Bills.Add(bill);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public Bill GetBillByID(Guid id)
		{
			return _context.Bills.FirstOrDefault(x => x.ID == id);
		}

		public List<Bill> GetBillList()
		{
			return _context.Bills.ToList();
		}
	}
}
