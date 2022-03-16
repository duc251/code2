using Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Config
{
    public class CtrHopDongConfiguration : IEntityTypeConfiguration<CtrHopDong>
    {
        public void Configure(EntityTypeBuilder<CtrHopDong> builder)
        {
            builder.ToTable("HopDong");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.IdHd).HasMaxLength(50).IsRequired();

            builder.Property(x => x.TenHopDong).HasMaxLength(50).IsRequired();

            builder.Property(x => x.NoiDungHD).HasMaxLength(50).IsRequired();

            builder.Property(x => x.NgayLap).IsRequired();

            builder.Property(x => x.NgayNghiemThu).IsRequired();

            builder.Property(x => x.NguoiPhuTrachHopDong).HasMaxLength(500).IsRequired();

            builder.Property(x => x.GiaTriGoiDV).HasMaxLength(200).IsRequired();

            builder.Property(x => x.CtrDoiTacID).IsRequired();

            builder.Property(x => x.TrangThai).IsRequired();

          
            

        }
    }
}
