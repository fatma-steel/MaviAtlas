using Microsoft.AspNetCore.Mvc;
using MaviAtlas.Data;

namespace MaviAtlas.Controllers;
public class TurController : Controller
{
    private readonly MaviAtlasContext _db;
    public TurController(MaviAtlasContext db)
    {
        _db = db;
    }
    public IActionResult Index(string? grup)
    {
        var sorgu = _db.Turler.AsQueryable();
        if (!string.IsNullOrEmpty(grup))
            sorgu = sorgu.Where(t => t.Grup == grup);

        ViewBag.Gruplar = _db.Turler.Select(t => t.Grup).Distinct().ToList();
        ViewBag.SeciliGrup = grup;
        return View(sorgu.ToList());
    }

    public IActionResult Detay(int id)
    {
        var tur = _db.Turler.FirstOrDefault(t => t.Id == id);
        if (tur == null) return NotFound();
        return View(tur);
    }

    public IActionResult Gruplar()
    {
        var gruplar = _db.Turler.AsEnumerable().GroupBy(t => t.Grup).OrderBy(g => g.Key).ToList();
        return View(gruplar);
    }
    
    [HttpPost]
    public IActionResult ToggleFavori(int id)
    {
        string favoriCookie = Request.Cookies["MaviAtlasFavoriler"] ?? "";
        var favoriler = favoriCookie.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();

        string strId = id.ToString();
        bool isFavori = false;
    
        // Eğer tıklanan canlı zaten favoriyse, favorilerden çıkar (Toggle kapama durumu)
        if (favoriler.Contains(strId))
        {
            favoriler.Remove(strId);
        }
        else
        {
            // Tıklanan canlı favori değil ama listede BAŞKA bir favori var
            if (favoriler.Count >= 1)
            {
                // Mevcut favorinin adını veritabanından bulalım
                if (int.TryParse(favoriler.First(), out int mevcutFavoriId))
                {
                    var mevcutCanli = _db.Turler.FirstOrDefault(t => t.Id == mevcutFavoriId);
                    if (mevcutCanli != null)
                    {
                        string mesaj = $"\"{mevcutCanli.TurkceAd}\" Canlısı Favori olarak belirlenmiş. Önce onu favorilerden çıkarmalısınız.";
                        return Json(new { basarili = false, isFavori = false, uyari = mesaj });
                    }
                }
            
                // Eğer veritabanında bulunamazsa varsayılan hata dön
                return Json(new { basarili = false, isFavori = false, uyari = "Zaten bir favori canlınız var!" });
            }

            // Listede hiç favori yoksa, bu canlıyı ekle
            favoriler.Add(strId);
            isFavori = true;
        }

        Response.Cookies.Append("MaviAtlasFavoriler", string.Join(",", favoriler), new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddYears(1),
            HttpOnly = true, 
            IsEssential = true
        });
    
        return Json(new { basarili = true, isFavori = isFavori });
    }
}

