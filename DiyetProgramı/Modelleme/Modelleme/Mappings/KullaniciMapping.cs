using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelleme.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Mappings
{
    internal class KullaniciMapping : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(k => k.KullaniciId);
            builder.Property(k => k.Email).IsRequired().HasMaxLength(50);
            builder.Property(k=>k.Password).IsRequired().HasMaxLength(15);
            // İlişki: Bir Kullanici'nın birden fazla Ogun'u olabilir
            builder.HasMany(k => k.Ogunler)
                   .WithOne(o => o.Kullanici)
                   .HasForeignKey(o => o.KullaniciId);
        }
    }
}
