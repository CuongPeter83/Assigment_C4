using Assignment.Models.Data;

namespace Assignment.IServices
{
    public interface ICapacityService
    {
        public bool AddCapacity(Capacity capacity);
        public bool UpdateCapacity(Capacity capacity);
        public bool DeleteCapacity(Guid id);
        public List<Capacity> GetCapacity();
        public Capacity GetCapacityByNumber(int Number);
    }
}
