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
        CinemaManager cinemaManager = new CinemaManager();
        public IActionResult Film(string title)
        {
            var model = new ChosenFilmController();
            model.ChosenFilm = cinemaManager.ChooseAFilm(title);
            model.Genres = genreManager.GetAllCategories();
            model.Films = cinemaManager.GetAllFilms();
            model.Screenings = cinemaManager.GetScreenings();
            return View(model);

        }
        //public IActionResult ChooseFilm(string title)
        //{
        //    cinemaManager.ChooseAFilm(title);
        //    var model = new FilmsAndGenres();
        //    model.Genres = genreManager.GetAllCategories();
        //    model.Films = cinemaManager.GetAllFilms();
        //    return View(model);

        //}

        public IActionResult Genres()
        {
            var model = new FilmsAndGenres();
            model.Genres = genreManager.GetAllCategories();
            model.Films = cinemaManager.GetAllFilms();
            return View(model);
        }

        public IActionResult Bookings()
        {
            return View();
        }
    }
}
