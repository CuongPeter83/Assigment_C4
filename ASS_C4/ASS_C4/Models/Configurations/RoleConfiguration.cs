using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{
			builder.ToTable("Role");
			builder.HasKey(c => c.IdRole);
			builder.Property(c => c.RoleName).HasColumnType("nvarchar(1000)").IsRequired();
			builder.Property(c => c.RoleDescription).HasColumnType("nvarchar(100)").IsRequired();
			builder.Property(c => c.Status).HasColumnType("int").IsRequired();

		}
	}
}
