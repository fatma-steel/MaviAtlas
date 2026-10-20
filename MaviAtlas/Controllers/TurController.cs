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
}

