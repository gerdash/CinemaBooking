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
        public IActionResult FilmChosen(string title)
        {
            var model = new ChosenFilmModel
            {
                ChosenFilm = cinemaManager.ChooseAFilm(title),
                Genres = genreManager.GetAllCategories(),
                Films = cinemaManager.GetAllFilms(),
                Screenings = cinemaManager.GetScreenings()
            };
            return View(model);

        }

        public IActionResult Genres()
        {
            var model = new FilmsAndGenres
            {
                Genres = genreManager.GetAllCategories(),
                Films = cinemaManager.GetAllFilms()
            };
            return View(model);
        }

        public IActionResult Bookings(DateTime booking)
        {
            cinemaManager.BookAScreening(booking);
            return View();
        }
    }
}
