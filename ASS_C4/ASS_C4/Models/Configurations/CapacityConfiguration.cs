using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
    public class CapacityConfiguration : IEntityTypeConfiguration<Capacity>
    {
        public void Configure(EntityTypeBuilder<Capacity> builder)
        {
            builder.ToTable("Capacity");
            builder.HasKey(c => c.ID);

            builder.Property(c => c.Capacitys).HasColumnType("int").IsRequired();
            builder.Property(c => c.Description).HasColumnType("nvarchar(1000)").IsRequired();

        }
    }
}
