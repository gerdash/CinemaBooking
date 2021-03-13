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

        public IActionResult Bookings(int booking, string title)
        {
            var model = new BookingsModel
            {
                Screening = cinemaManager.FindFilmByScreening(booking, title),
                UserFilms = cinemaManager.GetUserFilm()
            };
            return View(model);
        }

        public IActionResult Cancel(int filmId)
        {
            cinemaManager.CancelBooking(filmId);
            return View();
        }
    }
}
