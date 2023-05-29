using Assignment.Models.Data;

namespace Assignment.IServices
{
	public interface IProductsService
	{
		public bool CreateProduct(Product p);
		public bool UpdateProduct(Product p);
		public bool DeleteProduct(Guid id);
		public Product GetProductById(Guid id);
		public List<Product> GetProductByName(string name);
		public List<Product> GetAllProducts();
	}
}
