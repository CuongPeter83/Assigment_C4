using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class BillDetailsConfiguration : IEntityTypeConfiguration<BillDetail>
	{ 

		public void Configure(EntityTypeBuilder<BillDetail> builder)
		{
			builder.ToTable("BillDetails");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Quantity).HasColumnType("int").IsRequired();
			builder.Property(x => x.Price).HasColumnType("int").IsRequired();

			builder.HasOne(p => p.Bills).WithMany(c => c.BillDetails).HasForeignKey(p => p.IdHD);
			builder.HasOne(p => p.Product).WithMany(c => c.BillDetails).HasForeignKey(p => p.IdSp);
		}
	}
}
