using MaviAtlas.Data;
using MaviAtlas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MaviAtlas.ViewComponents;

public class RastgeleTurViewComponent : ViewComponent
{
    private readonly MaviAtlasContext _context;
    
    private static Tur? _onbellekTur;
    private static readonly SemaphoreSlim _lock = new(1, 1);

    public RastgeleTurViewComponent(MaviAtlasContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        if (_onbellekTur != null)
        {
            return View(_onbellekTur);
        }

        await _lock.WaitAsync();
        try
        {
            if (_onbellekTur == null)
            {
                var count = await _context.Turler.CountAsync();
                if (count > 0)
                {
                    var skip = Random.Shared.Next(0, count);
                    _onbellekTur = await _context.Turler.AsNoTracking().Skip(skip).FirstOrDefaultAsync();
                }
            }
        }
        finally
        {
            _lock.Release();
        }
        return View(_onbellekTur);
    }
}