using demo_mvc.Data;
using demo_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n =>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
