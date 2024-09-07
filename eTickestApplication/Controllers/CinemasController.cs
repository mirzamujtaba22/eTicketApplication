using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketApplication.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CinemasController(AppDbContext context)
        {
            _dbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _dbContext.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
