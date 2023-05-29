using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
    public class SupplierService : ISupplierService
    {
        public Shopping_Dbcontext _context;
        public SupplierService()
        {
            _context = new Shopping_Dbcontext();
        }
        public bool AddSupplier(Supplier supplier)
        {
            try
            {
                _context.Suppliers.Add(supplier);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteSupplier(Guid id)
        {
            try
            {
                var suppid = _context.Suppliers.FirstOrDefault(c => c.ID == id);
                _context.Suppliers.Remove(suppid);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                var suppid = _context.Suppliers.FirstOrDefault(c => c.ID == supplier.ID);
                suppid.NameSupplier = supplier.NameSupplier;
                suppid.DescriptionSupplier = supplier.DescriptionSupplier;
                _context.Suppliers.Update(suppid);
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
