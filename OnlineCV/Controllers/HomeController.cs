using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCV.Data;
using System.Linq;
using System.Threading.Tasks;

public class HomeController : Controller
{
    private readonly CVContext _context;

    public HomeController(CVContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var model = await _context.CVs.Include(c => c.WorkExperiences)
        .Include(c => c.Educations)
        .Include(c => c.Projects)
        .FirstOrDefaultAsync();

        if (model == null)
        {
            return NotFound();
        }

        return View(model);
    }
}