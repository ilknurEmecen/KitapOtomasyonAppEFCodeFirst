using KitapAp.MODELS;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapApp.DAL
{
    public class KitapDbContext:DbContext
    {

        public KitapDbContext():base("cstr")
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KitapTuru> KitapTurleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<KitapTuru>().ToTable("tblKitapTuru");
            modelBuilder.Entity<KitapTuru>().Property(o => o.KitapTuruAd).HasMaxLength(50).IsRequired().HasColumnType("varchar");


            modelBuilder.Entity<Yazar>().ToTable("tblYazar");
            modelBuilder.Entity<Yazar>().Property(o => o.YazarAdiSoyadi).HasMaxLength(50).IsRequired().HasColumnType("varchar");


        }


    }
}
