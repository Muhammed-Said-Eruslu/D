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
    public class OgunYemekMapping : IEntityTypeConfiguration<OgunYemek>
    {
        public void Configure(EntityTypeBuilder<OgunYemek> builder)
        {
            builder.HasKey(oy => oy.OgunYemekDetayId);

            builder.HasIndex(oy => new { oy.OgunId, oy.YemekId })
                   .IsUnique();

            builder.Property(oy => oy.Miktar)
                   .IsRequired(); // Miktarın zorunlu olduğunu belirtiyoruz

            // İlişkiler:
            builder.HasOne(oy => oy.Ogun)
                   .WithMany(o => o.Yemekleri)
                   .HasForeignKey(oy => oy.OgunId);

            builder.HasOne(oy => oy.Yemek)
                   .WithMany(y => y.Ogunleri)
                   .HasForeignKey(oy => oy.YemekId);
        }
    }
}
