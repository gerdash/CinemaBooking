using CinemaLogic;
using CinemaLogic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Models
{
    public class FilmsAndGenres
    {
        public FilmsAndGenres()
        {
            Genres = new List<CinemaLogic.DB.Categories>();
            Films = new List<CinemaLogic.DB.Films>();
        }
        public List<CinemaLogic.DB.Categories> Genres { get; set; }
        public List<CinemaLogic.DB.Films> Films { get; set; }
    }
}
