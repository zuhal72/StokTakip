
using Microsoft.EntityFrameworkCore;
using StokTakip.Entities.Entities;

namespace StokTakip.DataAccess.Context
{
    public class StokDbContext : DbContext
    {
        public StokDbContext(DbContextOptions<StokDbContext> options) : base(options) { }

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public object StokHareketler { get; internal set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Todo> Todos { get; set; }

    }
}
