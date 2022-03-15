using Data.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conf
{
    public class ContactConfigConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).HasMaxLength(256).IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x=>x.PhoneNumber).HasMaxLength(200).IsRequired();
            builder.Property(x=>x.Message).IsRequired();
        }
    }
}
