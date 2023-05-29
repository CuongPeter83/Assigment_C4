using Assignment.IServices;
using Assignment.Models.Data;
using System.ComponentModel;

namespace Assignment.Service
{
    public class CategoryService : ICategoryService
    {
        public Shopping_Dbcontext _context;
        public CategoryService()
        {
            _context = new Shopping_Dbcontext();
        }
        public bool AddCategory(Category category)
        {
            try
            {
                _context.Categorys.Add(category);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCategory(Guid id)
        {
            try
            {
                var cateid = _context.Categorys.FirstOrDefault(c => c.ID == id);
                _context.Categorys.Remove(cateid);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categorys.ToList();
        }

        public Category GetCategoryByName(string name)
        {
            return _context.Categorys.FirstOrDefault(c => c.Name == name);
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                var cateid = _context.Categorys.FirstOrDefault(c => c.ID == category.ID);
                cateid.Name = category.Name;
                cateid.Description = category.Description;
                _context.Categorys.Update(cateid);
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
