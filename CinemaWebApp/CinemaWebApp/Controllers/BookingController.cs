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
        public IActionResult Bookings(int filmId)
        {
            return View(bookingManager.GetUserFilm());
        }
        public IActionResult Cancel(int filmId)
        {
            bookingManager.CancelBooking(filmId);
            return RedirectToAction();
        }
    }
}
