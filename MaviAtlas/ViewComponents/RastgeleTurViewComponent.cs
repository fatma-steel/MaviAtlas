using MaviAtlas.Data;
using MaviAtlas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaviAtlas.ViewComponents;

public class RastgeleTurViewComponent : ViewComponent
{
    private readonly MaviAtlasContext _context;

    public RastgeleTurViewComponent(MaviAtlasContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var count = await _context.Turler.CountAsync();
        
        var random = new Random();
        var skip = random.Next(0, count);
        
        var rastgeleTur = await _context.Turler.Skip(skip).FirstOrDefaultAsync();
        return View(rastgeleTur);
    }
}