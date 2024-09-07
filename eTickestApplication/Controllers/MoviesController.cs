using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public MoviesController(AppDbContext context)
        {
            _dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _dbContext.Movies.Include(n=> n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies); 
        }
    }
}
