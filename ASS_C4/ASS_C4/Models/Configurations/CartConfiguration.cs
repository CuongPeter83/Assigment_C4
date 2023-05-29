using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.ToTable("Cart");
			builder.HasKey(p => p.UserID);

			builder.Property(c => c.Description).HasColumnType("nvarchar(1000)").IsRequired();
			builder.HasOne(c => c.User).WithMany(c => c.Carts).HasForeignKey(c => c.UserID);
		}
	}
}
