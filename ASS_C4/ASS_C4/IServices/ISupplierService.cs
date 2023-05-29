using Assignment.Models.Data;

namespace Assignment.IServices
{
    public interface ISupplierService
    {
        public bool AddSupplier(Supplier supplier);
        public bool DeleteSupplier(Guid id);
        public bool UpdateSupplier(Supplier supplier);
        public List<Supplier> GetAll();

    }
}
