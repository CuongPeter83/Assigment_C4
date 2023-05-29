using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("Product");
			builder.HasKey(c => c.ID);
			builder.Property(c => c.NameProduct).HasColumnType("nvarchar(100)").IsRequired();
			builder.Property(c => c.Price).HasColumnType("int").IsRequired();
			builder.Property(c => c.AvailableQuantity).HasColumnType("int").IsRequired();
           
            builder.Property(c => c.Status).HasColumnType("int").IsRequired();
			
            builder.Property(c => c.Image).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Color).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(c => c.Description).HasColumnType("nvarchar(1000)").IsRequired();
            builder.Property(c => c.Features).HasColumnType("nvarchar(1000)").IsRequired();

            builder.HasOne(c => c.Supplier).WithMany(c => c.Product).HasForeignKey(c => c.SupplierID);
			builder.HasOne(c => c.Category).WithMany(c => c.Products).HasForeignKey(c => c.CategoryID);
			builder.HasOne(c => c.Capacity).WithMany(c => c.Products).HasForeignKey(c => c.CapacityID);
        }
	}
}
