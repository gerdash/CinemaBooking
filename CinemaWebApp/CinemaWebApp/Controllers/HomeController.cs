using CinemaLogic;
using CinemaLogic.Managers;
using CinemaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Controllers
{
    public class HomeController : Controller
    {
        public CategoryManager genreManager = new CategoryManager();
        CinemaManager cinemaManager = new CinemaManager();
        public IActionResult Index()
        {
            return View(cinemaManager.GetAllFilms());
        }

    }
}
