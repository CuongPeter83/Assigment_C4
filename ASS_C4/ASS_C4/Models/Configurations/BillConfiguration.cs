using Assignment.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment.Models.Configurations
{
	public class BillConfiguration : IEntityTypeConfiguration<Bill>
	{
		public void Configure(EntityTypeBuilder<Bill> builder)
		{
			builder.ToTable("Bill"); // dat ten bang
			builder.HasKey(x => x.ID); // set khoa chinh
									   // cau hinh thuoc tinh

			builder.Property(x => x.Status).HasColumnType("int").IsRequired();
			builder.Property(x => x.CreateDate).HasColumnType("Date");
            builder.Property(x => x.Receiveddate).HasColumnType("Date");
			builder.Property(x => x.MaHD).HasColumnType("varchar(20)");
			builder.HasOne(p => p.User).WithMany(c => c.Bills).HasForeignKey(b => b.UserId);	


		}
	}
}
