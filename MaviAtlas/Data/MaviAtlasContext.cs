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
    new Tur { Id = 1, TurkceAd = "Ahtapot", BilimselAd = "Octopus vulgaris", Grup = "Yumuşakça", YasamAlani = "Kayalık kıyı", Govde = "Yumuşak",
              Aciklama = "Ahtapot (Octopus vulgaris), kafadanbacaklılar grubundan, kemiği olmayan yumuşak vücutlu bir omurgasızdır. Üzerinde vantuzlar bulunan sekiz kolu vardır. Kayalık kıyılarda kovuklara sığınarak yaşar; tehlike anında mürekkep salar ve rengini değiştirerek çevresine uyum sağlayabilir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/5/57/Octopus2.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 2, TurkceAd = "Çipura", BilimselAd = "Sparus aurata", Grup = "Balık",  YasamAlani = "Kumluk ve deniz çayırı", Govde = "Pullu", 
              Aciklama = "Çipura (Sparus aurata), Akdeniz ve Doğu Atlantik'te yaşayan, gümüşi renkli ve yüksek gövdeli bir balıktır. Gözlerinin arasında altın renkli bir bant bulunur. Kumluk ve deniz çayırı bölgelerinde yaşar, güçlü çenesiyle kabuklu canlıları kırarak beslenir.",
              FotoKaynak = "https://www.bilgiustam.com/resimler/2014/08/5608_cupra-2.jpg" },

    new Tur { Id = 3, TurkceAd = "Barbunya", BilimselAd = "Mullus barbatus", Grup = "Balık", YasamAlani = "Kumlu ve çamurlu dip",  Govde = "Pullu",
              Aciklama = "Barbunya (Mullus barbatus), kırmızımsı pembe renkli, çenesinin altında iki tane sensör sakalı bulunan küçük bir balıktır. Kumlu ve çamurlu diplerde yaşar; sakallarıyla dibi yoklayarak küçük kabuklu ve solucan türü canlıları bulup yer.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/b/be/Black_sea_mullus_barbatus_ponticus_01.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 4, TurkceAd = "Deniz kestanesi", BilimselAd = "Paracentrotus lividus", Grup = "Derisidikenli", YasamAlani = "Kayalık kıyı", Govde = "Dikenli", 
              Aciklama = "Deniz kestanesi (Paracentrotus lividus), derisidikenliler grubundan, küre biçimli ve uzun dikenlerle kaplı bir omurgasızdır. Kayalık kıyılarda yaşar. Ağzındaki sert, dişli yapıyla kayalıklardaki yosunları kazıyarak beslenir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/9/9b/Tripneustes_ventricosus_%28West_Indian_Sea_Egg-top%29_and_Echinometra_viridis_%28Reef_Urchin_-_bottom%29.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 5, TurkceAd = "Orfoz", BilimselAd = "Epinephelus marginatus", Grup = "Balık", YasamAlani = "Kayalık ve mağara", Govde = "Pullu",
              Aciklama = "Orfoz (Epinephelus marginatus), iri ve güçlü yapılı, geniş ağızlı bir kayalık balığıdır. Kayalıkların kovuklarında ve mağaralarında genellikle tek başına yaşar. Yavaş büyür ve uzun ömürlüdür.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/9/93/Epfus_u0_white_bg.gif/500px-Epfus_u0_white_bg.gif?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" },

    new Tur { Id = 6, TurkceAd = "Mürekkep balığı", BilimselAd = "Sepia officinalis", Grup = "Yumuşakça", YasamAlani = "Kumlu ve çamurlu dip", Govde = "Yumuşak", 
              Aciklama = "Mürekkep balığı (Sepia officinalis), kafadanbacaklılar grubundan, yassı ve oval gövdeli bir yumuşakçadır. Vücudunun içinde sübye adı verilen kireçli bir iç iskelet taşır; sekiz kolu ve iki uzun dokunacı vardır. Kumlu ve çamurlu diplerde yaşar, rengini ve desenini hızla değiştirerek çevresine karışabilir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Georgia_Aquarium_-_Cuttlefish_Jan_2006.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 7, TurkceAd = "Kalamar", BilimselAd = "Loligo vulgaris", Grup = "Yumuşakça", YasamAlani = "Açık su", Govde = "Yumuşak",
              Aciklama = "Kalamar (Loligo vulgaris), kafadanbacaklılar grubundan, torpido biçimli uzun gövdeli bir yumuşakçadır. Gövdenin arka kısmında baklava biçimli yüzgeçleri, başında ise vantuzlu sekiz kolu ve avı yakalamaya yarayan iki uzun dokunacı vardır. Kıyıya yakın sularda yaşar, balık ve kabuklularla beslenir; tehlike anında mürekkep salar ve rengini hızla değiştirebilir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/9/92/Dosidicus_gigas.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 8, TurkceAd = "Levrek", BilimselAd = "Dicentrarchus labrax", Grup = "Balık", YasamAlani = "Kıyı ve lagün", Govde = "Pullu",
              Aciklama = "Levrek (Dicentrarchus labrax), gümüşi renkli, uzun gövdeli ve iki ayrı sırt yüzgeci olan yırtıcı bir balıktır. Kıyı sularında, lagünlerde ve nehir ağızlarında yaşar. Küçük balıklar ve kabuklularla beslenir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/6/68/Dicentrarchus_labrax01.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original" },

    new Tur { Id = 9,TurkceAd = "Kefal", BilimselAd = "Mugil cephalus", Grup = "Balık", YasamAlani = "Kıyı ve lagün", Govde = "Pullu",
              Aciklama = "Kefal (Mugil cephalus), silindirik gövdeli, gümüşi renkli ve başı yassı bir balıktır. Kıyı sularında, lagünlerde ve nehir ağızlarında sürüler halinde yaşar. Deniz dibindeki yosun ve organik artıklarla beslenir.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/d/dc/Mújol_%28Mugil_cephalus%29%2C_Parque_natural_de_la_Arrábida%2C_Portugal%2C_2021-09-09%2C_DD_25.jpg/500px-Mújol_%28Mugil_cephalus%29%2C_Parque_natural_de_la_Arrábida%2C_Portugal%2C_2021-09-09%2C_DD_25.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" }, 

    new Tur { Id = 10, TurkceAd = "Dikenli denizyıldızı", BilimselAd = "Marthasterias glacialis", Grup = "Derisidikenli", YasamAlani = "Kayalık kıyı", Govde = "Dikenli",
              Aciklama = "Dikenli denizyıldızı (Marthasterias glacialis), beş kollu ve kolları boyunca sıralı dikenlerle kaplı bir derisidikenlidir. Kayalık zeminlerde yaşar. Midye gibi çift kabuklu canlılarla beslenen bir avcıdır.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/8/8f/CrownofThornsStarfish_Fiji_2005-10-12.jpg/500px-CrownofThornsStarfish_Fiji_2005-10-12.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" },

    new Tur { Id = 11, TurkceAd = "Yeşil deniz anemonu", BilimselAd = "Anemonia viridis", Grup = "Mercan ve anemon", YasamAlani = "Kayalık sığ sular", Govde = "Yumuşak",
              Aciklama = "Yeşil deniz anemonu (Anemonia viridis), uzun ve dalgalanan dokunaçları olan yumuşak vücutlu bir omurgasızdır. Dokunaçları yeşilimsi renklidir ve uçları mor olabilir. Sığ ve kayalık sularda yaşar, dokunaçlarındaki batıcı hücrelerle avını yakalar.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/c/c1/Anemone_monterey_madrabbit.jpg/500px-Anemone_monterey_madrabbit.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" },

    new Tur { Id = 12, TurkceAd = "Midye", BilimselAd = "Mytilus galloprovincialis", Grup = "Yumuşakça", YasamAlani = "Kayalık kıyı", Govde = "Sert kabuklu",
              Aciklama = "Midye (Mytilus galloprovincialis), koyu mavi-siyah renkli çift kabuğu olan bir yumuşakçadır. Kayalıklara bisüs adı verilen ipliklerle tutunur ve kalabalık yataklar oluşturur. Suyu süzerek beslenir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/4/45/CornishMussels.JPG?utm_source=tr.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled" },

    new Tur { Id = 13, TurkceAd = "Caretta", BilimselAd = "Caretta caretta", Grup = "Sürüngen", YasamAlani = "Açık deniz ve kumlu plaj", Govde = "Sert kabuklu",
              Aciklama = "Caretta (Caretta caretta), iri başlı ve kırmızımsı kahverengi kabuklu bir deniz kaplumbağasıdır. Akdeniz'de Türkiye kıyıları dahil birçok kumlu plajda yuva yapar. Yengeç, yumuşakça ve denizanası gibi canlılarla beslenir.",
              FotoKaynak = "https://upload.wikimedia.org/wikipedia/commons/1/13/Loggerhead_turtle.jpg?utm_source=tr.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled" },

    new Tur { Id = 14, TurkceAd = "Akdeniz foku", BilimselAd = "Monachus monachus", Grup = "Memeli", YasamAlani = "Mağaralı kayalık kıyı", Govde = "Kürklü",
              Aciklama = "Akdeniz foku (Monachus monachus), koyu kahverengi ya da gri tüylü, karnı daha açık renkli bir deniz memelisidir. Dinlenmek ve yavrulamak için deniz mağaralarını kullanır. Dünyanın en nadir fok türlerinden biri olarak bilinir.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/e/e1/Billy_monk_seal_2.jpg/500px-Billy_monk_seal_2.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" },

    new Tur { Id = 15, TurkceAd = "Şişe burunlu yunus", BilimselAd = "Tursiops truncatus", Grup = "Memeli", YasamAlani = "Açık deniz ve kıyı suları", Govde = "Pürüzsüz deri",
              Aciklama = "Şişe burunlu yunus (Tursiops truncatus), kısa ve kalın bir burnu olan, gri renkli bir deniz memelisidir. Gruplar halinde yaşar, balıklarla beslenir ve yönünü ses dalgalarıyla bulur. Havayı başının üstündeki solunum deliğinden alır.",
              FotoKaynak = "https://thumb.wikimedia.org/wikipedia/commons/thumb/b/bc/Tursiops_truncatus_01-cropped.jpg/500px-Tursiops_truncatus_01-cropped.jpg?utm_source=tr.wikipedia.org&utm_campaign=parser&utm_content=thumbnail" }

           );
    }
}
