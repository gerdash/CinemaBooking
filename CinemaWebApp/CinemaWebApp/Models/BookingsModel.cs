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
            Screening = new CinemaLogic.DB.Screening();
            UserFilms = new List<CinemaLogic.DB.UserFilms>();
        }

        public CinemaLogic.DB.Screening Screening { get; set; }
        public List<CinemaLogic.DB.UserFilms> UserFilms { get; set; }

    }
}
