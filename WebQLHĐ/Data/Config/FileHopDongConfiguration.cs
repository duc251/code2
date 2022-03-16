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
    public class FileHopDongConfiguration : IEntityTypeConfiguration<FileHopDong>
    {
        public void Configure(EntityTypeBuilder<FileHopDong> builder)
        {
            builder.ToTable("FileHopDong");

            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x => x.FilePath).HasMaxLength(200).IsRequired(true);

            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.CtrHopDong).WithMany(x=> x.FileHopDongs).HasForeignKey(x => x.HopDongId);
        }
    }
}
