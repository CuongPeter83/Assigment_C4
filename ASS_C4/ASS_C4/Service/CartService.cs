using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
	public class CartService : ICartService
	{
		public Shopping_Dbcontext _context;
		public CartService()
		{
			_context = new Shopping_Dbcontext();
		}
		public bool AddCart(Cart cart)
		{
			try
			{
				_context.Carts.Add(cart);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public bool DeleteCart(Guid id)
		{
			try
			{
				var cart = _context.Carts.FirstOrDefault(c => c.UserID == id);
				_context.Carts.Remove(cart);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public List<Cart> GetAllCarts()
		{
			return _context.Carts.ToList();
		}

		public Cart GetCartById(Guid id)
		{
			return _context.Carts.FirstOrDefault(c => c.UserID == id);
		}

		public bool UpdateCart(Cart cart)
		{
			try
			{
				var cart1 = _context.Carts.Find(cart.UserID);
				cart1.Description = cart.Description;
				_context.Carts.Update(cart1);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
