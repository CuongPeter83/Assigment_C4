using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasColumnType("nvarchar(100)").IsRequired();

            builder.Property(c => c.Description).HasColumnType("nvarchar(1000)").IsRequired();

            
        }
    }
}
