using System;
using System.Collections.Generic;

namespace CinemaLogic.DB
{
    public partial class UserFilms
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public string FilmTitle { get; set; }
        public string ScreeningTime { get; set; }
    }
}
