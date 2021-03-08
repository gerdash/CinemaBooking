using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaLogic
{
    public class CinemaManager
    {
        public List<Films> GetAllFilms()
        {
            using (var db = new CinemaDB())
            {
                return db.Films.OrderByDescending(f => f.ReleaseDate).ToList();
            }
        }
    }
}
