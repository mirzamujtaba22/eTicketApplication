using eTicketApplication.Data.Services;
using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTicketApplication.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorService;

        public ActorsController(IActorsService actorService)
        {
          _actorService = actorService;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _actorService.GetAll();
            return View(data);
        }

        //Get;Actors/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
