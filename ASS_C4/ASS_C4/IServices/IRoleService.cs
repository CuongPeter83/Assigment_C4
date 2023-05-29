using Assignment.Models.Data;

namespace Assignment.IServices
{
	public interface IRoleService
	{
		public bool AddRole(Role role);
		public bool RemoveRole(Guid id);
		public bool UpdateRole(Role role);
		public List<Role> GetRoles();
		public Role GetRoleByID(Guid id);
		public Role GetRoleByName(string roleName);
	}
}
