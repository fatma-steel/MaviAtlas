using MaviAtlas.Models;
    using Microsoft.EntityFrameworkCore;

namespace MaviAtlas.Data;

public class MaviAtlasContext:DbContext
{
    public MaviAtlasContext(DbContextOptions<MaviAtlasContext>options ): base(options) { }
    public DbSet<Tur> Turler { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tur>().HasData(
           new Tur { Id = 1, TurkceAd = "Ahtapot", BilimselAd = "Octopus vulgaris", Grup = "Yumuşakça", YasamAlani = "Kayalık kıyı", Govde = "Yumuşak" },
           new Tur { Id = 2, TurkceAd = "Çipura", BilimselAd = "Sparus aurata", Grup = "Balık", YasamAlani = "Kumluk ve deniz çayırı", Govde = "Pullu" },
           new Tur { Id = 3, TurkceAd = "Barbunya", BilimselAd = "Mullus barbatus", Grup = "Balık", YasamAlani = "Kumlu ve çamurlu dip", Govde = "Pullu" },
           new Tur { Id = 4, TurkceAd = "Deniz kestanesi", BilimselAd = "Paracentrotus lividus", Grup = "Derisidikenli", YasamAlani = "Kayalık kıyı", Govde = "Dikenli" },
           new Tur { Id = 5, TurkceAd = "Orfoz", BilimselAd = "Epinephelus marginatus", Grup = "Balık", YasamAlani = "Kayalık ve mağara", Govde = "Pullu" },
           new Tur { Id = 6, TurkceAd = "Mürekkep balığı", BilimselAd = "Sepia officinalis", Grup = "Yumuşakça", YasamAlani = "Kumlu ve çamurlu dip", Govde = "Yumuşak" }

           );
    }
}
