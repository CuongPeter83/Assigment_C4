using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class CartDetailsConfiguration : IEntityTypeConfiguration<CartDetails>
	{
		public void Configure(EntityTypeBuilder<CartDetails> builder)
		{
			builder.ToTable("CatDetails");
			builder.HasKey(c => c.ID);

			builder.Property(c => c.Quantity).HasColumnType("int").IsRequired();

			builder.HasOne(c => c.Cart).WithMany(c => c.CartDetail).HasForeignKey(c => c.UserID);
			builder.HasOne(c => c.Product).WithMany(c => c.CartDetail).HasForeignKey(c => c.IDSp);
		}
	}
}
