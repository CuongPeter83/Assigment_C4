using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.NameSupplier).HasColumnType("nvarchar(1000)").IsRequired();
            builder.Property(c => c.DescriptionSupplier).HasColumnType("nvarchar(1000)").IsRequired();
        }
    }
}
