using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApp.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Genres()
        {
            return View();
        }

        public IActionResult Films()
        {
            return View();
        }

        public IActionResult Bookings()
        {
            return View();
        }

    }
}
