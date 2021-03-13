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
    public class FilmController : Controller
    {
        public CategoryManager genreManager = new CategoryManager();
        public CinemaManager cinemaManager = new CinemaManager();
        public BookingManager bookingManager = new BookingManager();
        public IActionResult FilmChosen(int? id)
        {
            ChosenFilmModel model = new ChosenFilmModel();
            if (id.HasValue)
            {
                model.ChosenFilm = cinemaManager.ChooseAFilm(id.Value);
                model.ChosenFilmGenre = cinemaManager.GetGenreById(model.ChosenFilm.CategoryId);
                model.ScreeningTimes = cinemaManager.GetScreeningTimesById(model.ChosenFilm.ScreeningId);
            }
            return View(model);
        }

        public IActionResult Genres(int? id)
        {
            GenresModel model = new GenresModel();
            model.Genres = genreManager.GetAllCategories();
            if (id.HasValue)
            {
                model.Films = cinemaManager.GetByCategory(id.Value);
                model.ActiveCat = genreManager.GetCategory(id.Value);
            }
            
            return View(model);
        }
        public IActionResult Bookings(int filmId, string time)
        {
            bookingManager.BookFilm(filmId, time);
            return View(RedirectToAction(nameof(FilmChosen)));
        }

    }
}
