using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
	public class RoleService : IRoleService
	{
		public Shopping_Dbcontext _context;
		public RoleService()
		{
			_context = new Shopping_Dbcontext();
		}
		public bool AddRole(Role role)
		{
			try
			{
				_context.Roles.Add(role);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public Role GetRoleByID(Guid id)
		{
			return _context.Roles.FirstOrDefault(c => c.IdRole == id);
		}

		public Role GetRoleByName(string roleName)
		{
			return _context.Roles.FirstOrDefault(c => c.RoleName == roleName);
		}

		public List<Role> GetRoles()
		{
			return _context.Roles.ToList();
		}

		public bool RemoveRole(Guid id)
		{
			try
			{
				var role = _context.Roles.FirstOrDefault(x => x.IdRole == id);
				_context.Roles.Remove(role);
				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public bool UpdateRole(Role role)
		{
			try
			{
				var role1 = _context.Roles.FirstOrDefault(x => x.IdRole == role.IdRole);
				role1.RoleName = role.RoleName;
				role1.RoleDescription = role.RoleDescription;
				role1.Status = role.Status;
				_context.Roles.Update(role1);
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
