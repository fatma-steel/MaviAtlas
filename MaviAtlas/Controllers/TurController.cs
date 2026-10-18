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
}

