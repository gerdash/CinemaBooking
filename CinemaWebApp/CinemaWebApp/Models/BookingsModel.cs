using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Models
{
    public class BookingsModel
    {
        public BookingsModel()
        {
            ChosenFilm = new CinemaLogic.DB.Films();
            Screening = new CinemaLogic.DB.Screening();
        }

        public CinemaLogic.DB.Films ChosenFilm { get; set; }
        public CinemaLogic.DB.Screening Screening { get; set; }

    }
}
