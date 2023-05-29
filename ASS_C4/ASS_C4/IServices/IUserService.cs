using Assignment.Models.Data;
using System.Security;

namespace Assignment.IServices
{
	public interface IUserService
	{
		public bool AddUser(User user);
		public bool UpdateUser(User user);
		public bool DeleteUser(Guid ID);
		public string Login(string email, string password);
		public User GetUserById(Guid ID);
		public List<User> GetAllUsers();
	
		public User GetUserByName(string Name);
	}
}
