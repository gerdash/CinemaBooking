using CinemaLogic;
using CinemaLogic.Managers;
using CinemaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Controllers
{
    public class BookingController : Controller
    {
        CinemaManager cinemaManager = new CinemaManager();
        BookingManager bookingManager = new BookingManager();
        public IActionResult Bookings(int booking, string title)
        {
            var model = new BookingsModel
            {
                //fix the method so the screening time would be saved in userfilms!!!
                Screening = cinemaManager.FindFilmByScreening(booking, title),
                UserFilms = cinemaManager.GetUserFilm()
            };
            return View(model);
        }

        public IActionResult Cancel(int filmId)
        {
            bookingManager.CancelBooking(filmId);
            return View();
        }
    }
}
