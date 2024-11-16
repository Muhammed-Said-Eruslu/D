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
    internal class OgunMapping : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.HasKey(o => o.OgunId);
            builder.Property(o => o.Tarih).IsRequired();

            // İlişki: Ogun ile Kullanici arasında bire çok ilişki
            builder.HasOne(o => o.Kullanici)
                   .WithMany(k => k.Ogunler)
                   .HasForeignKey(o => o.KullaniciId);

            // İlişki: Ogun ile OgunYemek arasında bire çok ilişki
            builder.HasMany(o => o.Yemekleri)
                   .WithOne(oy => oy.Ogun)
                   .HasForeignKey(oy => oy.OgunId);
        }
    }
}
