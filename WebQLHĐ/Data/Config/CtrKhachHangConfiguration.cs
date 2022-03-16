using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Config
{
    public class CtrKhachHangConfiguration : IEntityTypeConfiguration<CtrKhachHang>
    {
        public void Configure(EntityTypeBuilder<CtrKhachHang> builder)
        {
            builder.ToTable("KhachHang");

            builder.HasKey(x => x.CtrKhachHangID);

            builder.Property(x => x.CtrKhachHangID).UseIdentityColumn();

            builder.Property(x => x.MaKH).HasMaxLength(50).IsRequired();

            builder.Property(x => x.TenKhachHang).HasMaxLength(50).IsRequired();

            builder.Property(x => x.MaSothueKH).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Diachi).HasMaxLength(500).IsRequired();

            builder.Property(x => x.Dienthoai).HasMaxLength(10).IsRequired();
         
            builder.Property(x => x.Skype).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();

            builder.Property(x => x.NgayDangKy).IsRequired();

            builder.Property(x => x.NgayCapNhat).IsRequired();

            builder.Property(x => x.TrangThai).IsRequired();

        }
    }
}
