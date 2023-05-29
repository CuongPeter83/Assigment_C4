using Assignment.IServices;
using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Service
{
	public class CartDetailsService : ICartDetialsService
	{
		public Shopping_Dbcontext _context;
		public CartDetailsService() 
		{ 
			_context = new Shopping_Dbcontext();
		}
		public bool AddCartDetail(CartDetails cd)
		{
			try
			{
				_context.CartDetails.Add(cd);
				_context.SaveChanges();
				return true;
			} 
			catch
			{
				return false;
			}
		}

		public bool DeleteCartDetail(Guid id)
		{
			try
			{
				var cartdetail = _context.CartDetails.FirstOrDefault(c => c.ID == id);
				_context.CartDetails.Remove(cartdetail);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public List<CartDetails> GetCartDetail()
		{
			return _context.CartDetails.ToList();
		}

		public CartDetails GetCartDetailById(Guid id)
		{
			return _context.CartDetails.FirstOrDefault(c => c.UserID == id);
		}

		public bool UpdateCartDetail(CartDetails cd)
		{
			try
			{
				var cartdetail = _context.CartDetails.FirstOrDefault(c => c.ID == cd.ID);
				//cartdetail.IDSp = cd.IDSp;
				cartdetail.Quantity = cd.Quantity;
				//cartdetail.UserID = cd.UserID;
				_context.CartDetails.Update(cartdetail);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}
	}
}
