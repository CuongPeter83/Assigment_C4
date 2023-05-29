using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("Users");
			builder.HasKey(x => x.UserID);
			builder.Property(c => c.Name).HasColumnType("nvarchar(100)").IsRequired();
			builder.Property(c=> c.Email).HasColumnType("varchar(255)").IsRequired();
			builder.Property(c => c.Password).HasColumnType("varchar(50)").IsRequired();
			builder.Property(c => c.Status).HasColumnType("int").IsRequired();
            builder.Property(c => c.Address).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(c => c.PhoneNumber).HasColumnType("varchar(10)").IsRequired();

            builder.HasOne(c => c.Roles).WithMany(p => p.User).HasForeignKey(p => p.IDRole);
        }
	}
}
