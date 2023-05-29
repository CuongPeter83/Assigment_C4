namespace Assignment.Models.Data
{
	public class Role
	{
		public Guid IdRole { get; set; }
		public string RoleName { get; set; }
		public string RoleDescription { get; set; }
		public int Status { get; set; }
		public virtual IEnumerable<User> User { get; set; }
	}
}
