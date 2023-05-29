using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
    public class CapacityService : ICapacityService
    {
        public Shopping_Dbcontext _context;
        public CapacityService()
        {
            _context = new Shopping_Dbcontext();
        }
        public bool AddCapacity(Capacity capacity)
        {
            try
            {
                _context.Capacities.Add(capacity);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCapacity(Guid id)
        {
            try
            {
                var capacityid = _context.Capacities.FirstOrDefault(c => c.ID == id);
                _context.Capacities.Remove(capacityid);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public List<Capacity> GetCapacity()
        {
            return _context.Capacities.ToList();
        }

        public Capacity GetCapacityByNumber(int Number)
        {
            return _context.Capacities.FirstOrDefault(c => c.Capacitys == Number);
        }

        public bool UpdateCapacity(Capacity capacity)
        {
            try
            {
                var capacityid = _context.Capacities.FirstOrDefault(c => c.ID == capacity.ID);
                capacityid.Capacitys = capacity.Capacitys;
                capacityid.Description = capacity.Description;
                _context.Capacities.Update(capacityid);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
