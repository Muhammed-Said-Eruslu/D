using Microsoft.EntityFrameworkCore;
using Modelleme.Mappings;
using Modelleme.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Context
{
    public class KaloriTakipDbContext: DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<OgunYemek> OgunYemekler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KaloriTakipDeneme3;Trusted_Connection=True; MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KullaniciMapping());
            modelBuilder.ApplyConfiguration(new OgunMapping());
            modelBuilder.ApplyConfiguration(new YemekMapping());
            modelBuilder.ApplyConfiguration(new KategoriMapping());
            modelBuilder.ApplyConfiguration(new OgunYemekMapping());
        }

    }


}
