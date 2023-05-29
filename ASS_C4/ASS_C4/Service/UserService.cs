using Assignment.IServices;
using Assignment.Models.Data;

namespace Assignment.Service
{
	public class UserService : IUserService
	{
		public Shopping_Dbcontext _context;
		public UserService()
		{
			_context = new Shopping_Dbcontext();
		}
		
		public bool AddUser(User user)
		{
			try
			{
				_context.Users.Add(user);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public bool DeleteUser(Guid ID)
		{
			try
			{
				var userid = _context.Users.FirstOrDefault(x => x.UserID == ID);
				_context.Users.Remove(userid);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}

		public List<User> GetAllUsers()
		{
			return _context.Users.ToList();
		}

		public User GetUserById(Guid ID)
		{
			return _context.Users.FirstOrDefault(c => c.UserID == ID);
		}

		public User GetUserByName(string Name)
		{
			return _context.Users.FirstOrDefault(c => c.Name == Name);
		}

        public string Login(string email, string password)
        {
			var checkemail = _context.Users.FirstOrDefault(c => c.Email == email);
			if(email == null)
			{
				return "Email không có trong hệ thống";
			}
			else
			{
				if(checkemail.Status == 0)
				{
					return "Tài khoản bị vô hiệu hoá.";
				}
				else
				{
					if(checkemail.Password == password)
					{
						return "Đăng nhập thành công."; // đúng mật khẩu
					}
					else
					{
						return "Mật khẩu bị sai. Mời nhập lại.";
					}
				}
			}
			
        }

        public bool UpdateUser(User user)
		{
			try
			{	
				var userid = _context.Users.FirstOrDefault(c => c.UserID == user.UserID);
				userid.Name = user.Name;
				userid.Email = user.Email;
				userid.Password = user.Password;
				userid.PhoneNumber = user.PhoneNumber;
				userid.Address = user.Address;
				userid.IDRole = user.IDRole;
				_context.Users.Update(userid);
				_context.SaveChanges();
				return true;
			} catch (Exception ex)
			{
				return false;
			}
		}
	}
}
