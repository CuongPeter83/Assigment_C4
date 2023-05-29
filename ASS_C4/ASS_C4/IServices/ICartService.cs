using Assignment.Models.Data;

namespace Assignment.IServices
{
	public interface ICartService
	{
		public bool AddCart(Cart cart);
		public bool UpdateCart(Cart cart);
		public bool DeleteCart(Guid id);
		public List<Cart> GetAllCarts();
		public Cart GetCartById(Guid id);
	}
}
