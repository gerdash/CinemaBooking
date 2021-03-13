using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaLogic.DB;

namespace CinemaWebApp.Models
{
    public class ChosenFilmModel
    {
        //Film clicked on
        public Films ChosenFilm { get; set; }
        //Genre the film is in
        public Categories ChosenFilmGenre { get; set; }
        //Available Screenings for this film to get by ID or not to get by ID is the question
        public List<DateTime> ScreeningTimes { get; set; }
    }

}
