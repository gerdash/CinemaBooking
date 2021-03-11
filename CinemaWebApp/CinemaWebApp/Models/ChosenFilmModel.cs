using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Models
{
    public class ChosenFilmModel
    {
        public ChosenFilmModel()
        {
            Genres = new List<CinemaLogic.DB.Categories>();
            Films = new List<CinemaLogic.DB.Films>();
            Screenings = new List<CinemaLogic.DB.Screening>();
            ChosenFilm = new CinemaLogic.DB.Films();
        }

        public List<CinemaLogic.DB.Categories> Genres { get; set; }
        public List<CinemaLogic.DB.Films> Films { get; set; }
        public List<CinemaLogic.DB.Screening> Screenings { get; set; }

        public CinemaLogic.DB.Films ChosenFilm { get; set; }
    }

}
