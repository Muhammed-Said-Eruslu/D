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
    public class YemekMapping : IEntityTypeConfiguration<Yemek>
    {
        public void Configure(EntityTypeBuilder<Yemek> builder)
        {
            builder.HasKey(y => y.YemekId);
            builder.Property(y => y.YemekAdi).IsRequired().HasMaxLength(100);
            builder.Property(y => y.Kalori).IsRequired();

            // İlişki: Yemek ile Kategori arasında bire çok ilişki
            builder.HasOne(y => y.Kategori)
                   .WithMany(k => k.Yemekler)
                   .HasForeignKey(y => y.KategoriId);

            // İlişki: Yemek ile OgunYemek arasında bire çok ilişki
            builder.HasMany(y => y.Ogunleri)
                   .WithOne(oy => oy.Yemek)
                   .HasForeignKey(oy => oy.YemekId);
        }
    }
}
