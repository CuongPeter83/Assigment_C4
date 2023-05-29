using Assignment.Models.Data;

namespace Assignment.IServices
{
    public interface ICategoryService
    {
        public bool AddCategory(Category category);
        public bool UpdateCategory (Category category);
        public bool DeleteCategory(Guid id);
        public List<Category> GetAllCategories();
        public Category GetCategoryByName(string name);
    }
}
