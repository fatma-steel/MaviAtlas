using Microsoft.AspNetCore.Mvc;
using MaviAtlas.Data;

namespace MaviAtlas.Controllers;

public class TanimaController : Controller
{
    private readonly MaviAtlasContext _db;
    public TanimaController(MaviAtlasContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        ViewBag.Alanlar = _db.Turler.Select(t => t.YasamAlani).Distinct().ToList();
        ViewBag.Govdeler = _db.Turler.Select(t => t.Govde).Distinct().ToList();
        return View();
    }

    public IActionResult Sonuc(string? alan, string? govde)
    {
        var sorgu = _db.Turler.AsQueryable();
        if (!string.IsNullOrEmpty(alan))
            sorgu = sorgu.Where(t => t.YasamAlani == alan);
        if (!string.IsNullOrEmpty(govde))
            sorgu = sorgu.Where(t => t.Govde == govde);

        ViewBag.Alan = string.IsNullOrEmpty(alan) ? "fark etmez" : alan;
        ViewBag.Govde = string.IsNullOrEmpty(govde) ? "fark etmez" : govde;
        return View(sorgu.ToList());
    }
}