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
    public class KategoriMapping : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(k => k.KategoriId);
            builder.Property(k => k.KategoriAdi).IsRequired().HasMaxLength(50);

            // İlişki: Bir Kategori'nin birden fazla Yemek'i olabilir
            builder.HasMany(k => k.Yemekler)
                   .WithOne(y => y.Kategori)
                   .HasForeignKey(y => y.KategoriId);
        }
    }
}
