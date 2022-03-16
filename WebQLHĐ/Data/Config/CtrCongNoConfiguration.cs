using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Config
{
    public class CtrCongNoConfiguration : IEntityTypeConfiguration<CtrCongNo>
    {
        public void Configure(EntityTypeBuilder<CtrCongNo> builder)
        {
            builder.ToTable("CongNo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.IdCongNo).HasMaxLength(50).IsRequired();

            builder.Property(x => x.TongNo).HasMaxLength(200).IsRequired();

            builder.Property(x => x.DaThanhToan).HasMaxLength(50).IsRequired();

            builder.Property(x => x.NgayThanhToan).IsRequired();

            builder.Property(x => x.DuNo).HasMaxLength(200).IsRequired();

            builder.Property(x => x.KhauTru).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Kyhan).IsRequired();

            builder.Property(x => x.GhiChu).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Trangthai).IsRequired();


            
        }
    }
}
