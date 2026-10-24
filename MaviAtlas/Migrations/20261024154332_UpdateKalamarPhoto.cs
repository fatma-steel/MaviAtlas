using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MaviAtlas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKalamarPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TurkceAd = table.Column<string>(type: "TEXT", nullable: false),
                    BilimselAd = table.Column<string>(type: "TEXT", nullable: false),
                    Grup = table.Column<string>(type: "TEXT", nullable: false),
                    YasamAlani = table.Column<string>(type: "TEXT", nullable: false),
                    Govde = table.Column<string>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    FotoKaynak = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turler", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Turler",
                columns: new[] { "Id", "Aciklama", "BilimselAd", "FotoKaynak", "Govde", "Grup", "TurkceAd", "YasamAlani" },
                values: new object[,]
                {
                    { 1, "Ahtapot (Octopus vulgaris), kafadanbacaklılar grubundan, kemiği olmayan yumuşak vücutlu bir omurgasızdır. Üzerinde vantuzlar bulunan sekiz kolu vardır. Kayalık kıyılarda kovuklara sığınarak yaşar; tehlike anında mürekkep salar ve rengini değiştirerek çevresine uyum sağlayabilir.", "Octopus vulgaris", "", "Yumuşak", "Yumuşakça", "Ahtapot", "Kayalık kıyı" },
                    { 2, "Çipura (Sparus aurata), Akdeniz ve Doğu Atlantik'te yaşayan, gümüşi renkli ve yüksek gövdeli bir balıktır. Gözlerinin arasında altın renkli bir bant bulunur. Kumluk ve deniz çayırı bölgelerinde yaşar, güçlü çenesiyle kabuklu canlıları kırarak beslenir.", "Sparus aurata", "", "Pullu", "Balık", "Çipura", "Kumluk ve deniz çayırı" },
                    { 3, "Barbunya (Mullus barbatus), kırmızımsı pembe renkli, çenesinin altında iki tane sensör sakalı bulunan küçük bir balıktır. Kumlu ve çamurlu diplerde yaşar; sakallarıyla dibi yoklayarak küçük kabuklu ve solucan türü canlıları bulup yer.", "Mullus barbatus", "", "Pullu", "Balık", "Barbunya", "Kumlu ve çamurlu dip" },
                    { 4, "Deniz kestanesi (Paracentrotus lividus), derisidikenliler grubundan, küre biçimli ve uzun dikenlerle kaplı bir omurgasızdır. Kayalık kıyılarda yaşar. Ağzındaki sert, dişli yapıyla kayalıklardaki yosunları kazıyarak beslenir.", "Paracentrotus lividus", "", "Dikenli", "Derisidikenli", "Deniz kestanesi", "Kayalık kıyı" },
                    { 5, "Orfoz (Epinephelus marginatus), iri ve güçlü yapılı, geniş ağızlı bir kayalık balığıdır. Kayalıkların kovuklarında ve mağaralarında genellikle tek başına yaşar. Yavaş büyür ve uzun ömürlüdür.", "Epinephelus marginatus", "", "Pullu", "Balık", "Orfoz", "Kayalık ve mağara" },
                    { 6, "Mürekkep balığı (Sepia officinalis), kafadanbacaklılar grubundan, yassı ve oval gövdeli bir yumuşakçadır. Vücudunun içinde sübye adı verilen kireçli bir iç iskelet taşır; sekiz kolu ve iki uzun dokunacı vardır. Kumlu ve çamurlu diplerde yaşar, rengini ve desenini hızla değiştirerek çevresine karışabilir.", "Sepia officinalis", "", "Yumuşak", "Yumuşakça", "Mürekkep balığı", "Kumlu ve çamurlu dip" },
                    { 7, "Kalamar (Loligo vulgaris), kafadanbacaklılar grubundan, torpido biçimli uzun gövdeli bir yumuşakçadır. Gövdenin arka kısmında baklava biçimli yüzgeçleri, başında ise vantuzlu sekiz kolu ve avı yakalamaya yarayan iki uzun dokunacı vardır. Kıyıya yakın sularda yaşar, balık ve kabuklularla beslenir; tehlike anında mürekkep salar ve rengini hızla değiştirebilir.", "Loligo vulgaris", "https://upload.wikimedia.org/wikipedia/commons/9/92/Dosidicus_gigas.jpg?utm_source=tr.wikipedia.org&utm_campaign=index&utm_content=original", "Yumuşak", "Yumuşakça", "Kalamar", "Açık su" },
                    { 8, "Levrek (Dicentrarchus labrax), gümüşi renkli, uzun gövdeli ve iki ayrı sırt yüzgeci olan yırtıcı bir balıktır. Kıyı sularında, lagünlerde ve nehir ağızlarında yaşar. Küçük balıklar ve kabuklularla beslenir.", "Dicentrarchus labrax", "", "Pullu", "Balık", "Levrek", "Kıyı ve lagün" },
                    { 9, "Kefal (Mugil cephalus), silindirik gövdeli, gümüşi renkli ve başı yassı bir balıktır. Kıyı sularında, lagünlerde ve nehir ağızlarında sürüler halinde yaşar. Deniz dibindeki yosun ve organik artıklarla beslenir.", "Mugil cephalus", "", "Pullu", "Balık", "Kefal", "Kıyı ve lagün" },
                    { 10, "Dikenli denizyıldızı (Marthasterias glacialis), beş kollu ve kolları boyunca sıralı dikenlerle kaplı bir derisidikenlidir. Kayalık zeminlerde yaşar. Midye gibi çift kabuklu canlılarla beslenen bir avcıdır.", "Marthasterias glacialis", "", "Dikenli", "Derisidikenli", "Dikenli denizyıldızı", "Kayalık kıyı" },
                    { 11, "Yeşil deniz anemonu (Anemonia viridis), uzun ve dalgalanan dokunaçları olan yumuşak vücutlu bir omurgasızdır. Dokunaçları yeşilimsi renklidir ve uçları mor olabilir. Sığ ve kayalık sularda yaşar, dokunaçlarındaki batıcı hücrelerle avını yakalar.", "Anemonia viridis", "", "Yumuşak", "Mercan ve anemon", "Yeşil deniz anemonu", "Kayalık sığ sular" },
                    { 12, "Midye (Mytilus galloprovincialis), koyu mavi-siyah renkli çift kabuğu olan bir yumuşakçadır. Kayalıklara bisüs adı verilen ipliklerle tutunur ve kalabalık yataklar oluşturur. Suyu süzerek beslenir.", "Mytilus galloprovincialis", "", "Sert kabuklu", "Yumuşakça", "Midye", "Kayalık kıyı" },
                    { 13, "Caretta (Caretta caretta), iri başlı ve kırmızımsı kahverengi kabuklu bir deniz kaplumbağasıdır. Akdeniz'de Türkiye kıyıları dahil birçok kumlu plajda yuva yapar. Yengeç, yumuşakça ve denizanası gibi canlılarla beslenir.", "Caretta caretta", "", "Sert kabuklu", "Sürüngen", "Caretta", "Açık deniz ve kumlu plaj" },
                    { 14, "Akdeniz foku (Monachus monachus), koyu kahverengi ya da gri tüylü, karnı daha açık renkli bir deniz memelisidir. Dinlenmek ve yavrulamak için deniz mağaralarını kullanır. Dünyanın en nadir fok türlerinden biri olarak bilinir.", "Monachus monachus", "", "Kürklü", "Memeli", "Akdeniz foku", "Mağaralı kayalık kıyı" },
                    { 15, "Şişe burunlu yunus (Tursiops truncatus), kısa ve kalın bir burnu olan, gri renkli bir deniz memelisidir. Gruplar halinde yaşar, balıklarla beslenir ve yönünü ses dalgalarıyla bulur. Havayı başının üstündeki solunum deliğinden alır.", "Tursiops truncatus", "", "Pürüzsüz deri", "Memeli", "Şişe burunlu yunus", "Açık deniz ve kıyı suları" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turler");
        }
    }
}
