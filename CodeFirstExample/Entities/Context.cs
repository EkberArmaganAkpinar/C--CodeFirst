using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample.Entities
{
    public class Context : DbContext
    {
        public Context() : base("EfExample") { }
        public virtual DbSet<Fakulteler> tFakulte { get; set; }

        public virtual DbSet<Ogrenciler> tOgrenci { get; set; }
        public virtual DbSet<Bolumler> tBolum { get; set; }
        public virtual DbSet<Dersler> tDers { get; set; }
        public virtual DbSet<OgrenciDersler> tOgrenciDersler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fakulteler>().HasKey(e => e.FakulteID);
            modelBuilder.Entity<Fakulteler>().Property(e => e.FakulteID).HasColumnName("fakulteID");
            modelBuilder.Entity<Fakulteler>().Property(e => e.FakulteAd).HasColumnName("fakulteAd");
            modelBuilder.Entity<Ogrenciler>().HasKey(e => e.OgrenciID);
            modelBuilder.Entity<Ogrenciler>().Property(e => e.OgrenciID).HasColumnName("ogrenciID");
            modelBuilder.Entity<Ogrenciler>().Property(e => e.Ad).HasColumnName("ad");
            modelBuilder.Entity<Ogrenciler>().Property(e => e.Soyad).HasColumnName("soyad");
            modelBuilder.Entity<Ogrenciler>().Property(e => e.Numara).HasColumnName("numara");
            modelBuilder.Entity<Ogrenciler>().Property(e => e.BolumID).HasColumnName("bolumID");
            modelBuilder.Entity<Bolumler>().HasKey(e => e.BolumID);
            modelBuilder.Entity<Bolumler>().Property(e => e.BolumID).HasColumnName("bolumID");
            modelBuilder.Entity<Bolumler>().Property(e => e.BolumAd).HasColumnName("bolumAd");
            modelBuilder.Entity<Bolumler>().Property(e => e.fakulteID).HasColumnName("fakulteID");
            modelBuilder.Entity<Dersler>().HasKey(e => e.DersID);
            modelBuilder.Entity<Dersler>().Property(e => e.DersID).HasColumnName("dersID");
            modelBuilder.Entity<Dersler>().Property(e => e.DersAd).HasColumnName("dersAd");
            modelBuilder.Entity<Dersler>().Property(e => e.DersYil).HasColumnName("dersYil");
            modelBuilder.Entity<Dersler>().Property(e => e.DersYariyil).HasColumnName("dersYariyil");
            modelBuilder.Entity<OgrenciDersler>().HasKey(e => e.OgrenciDersID);
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.OgrenciDersID).HasColumnName("ogrenciDersID");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.OgrenciID).HasColumnName("ogrenciID");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.DersID).HasColumnName("dersID");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.Yil).HasColumnName("yil");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.YariYil).HasColumnName("yariyil");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.Vize).HasColumnName("vize");
            modelBuilder.Entity<OgrenciDersler>().Property(e => e.Final).HasColumnName("final");


        }
    }
}
    