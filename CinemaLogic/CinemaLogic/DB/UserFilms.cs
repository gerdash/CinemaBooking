using System;
using System.Collections.Generic;

namespace CinemaLogic.DB
{
    public partial class UserFilms
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Director { get; set; }
        public string Synopsis { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public string Cast { get; set; }
        public int DurationInMin { get; set; }
        public int? ScreeningId { get; set; }
    }
}
