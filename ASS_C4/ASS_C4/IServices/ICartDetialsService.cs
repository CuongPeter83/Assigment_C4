using Assignment.Models.Data;

namespace Assignment.IServices
{
	public interface ICartDetialsService
	{
		public bool AddCartDetail(CartDetails cd);
		public bool UpdateCartDetail(CartDetails cd);
		public bool DeleteCartDetail(Guid id);
		public List<CartDetails> GetCartDetail();
		public CartDetails GetCartDetailById(Guid id);
	}
}
