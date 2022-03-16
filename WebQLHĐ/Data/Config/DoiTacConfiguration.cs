using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QLHĐSolotion.Data.Config
{
    public class DoiTacConfiguration : IEntityTypeConfiguration<CtrDoiTac>
    {
        public void Configure(EntityTypeBuilder<CtrDoiTac> builder)
        {
            builder.ToTable("DoiTac");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Id).HasMaxLength(50).IsRequired();

            builder.Property(x=>x.TenDoiTac).HasMaxLength(50).IsRequired();

            builder.Property(x=>x.DiaChi).HasMaxLength(50).IsRequired();

            builder.Property(x=>x.MaSoThueDT).HasMaxLength(50).IsRequired();

            builder.Property(x=>x.DienThoai).HasMaxLength(50).IsRequired();

            builder.Property(x=>x.NgayDangKy).IsRequired();

            builder.Property(x=>x.NgayCapNhat).IsRequired();

            builder.Property(x => x.TrangThai).IsRequired();


          
        }
    }
}
