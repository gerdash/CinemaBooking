using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaLogic
{
    public class CinemaManager
    {
        //getting all of the films in the cinema database
        public List<Films> GetAllFilms()
        {
            using (var db = new CinemaDB())
            {
                return db.Films.ToList();
            }
        }
        //gets the newest releases of 9 films
        public List<Films> GetNewestFilms()
        {
            using (var db = new CinemaDB())
            {
                return db.Films.OrderByDescending(f => f.ReleaseDate).Take(9).ToList();
            }
        }

        //method to get all of the the films in a category
        public List<Films> GetByCategory(int categoryId)
        {
            using (var db = new CinemaDB())
            {
                return db.Films
                    .Where(f => f.CategoryId == categoryId)
                    .OrderByDescending(f => f.ReleaseDate)
                    .ToList();
            }
        }

        //Choosing a film user has clicked on
        public Films ChooseAFilm(int filmId)
        {
            using (var db = new CinemaDB())
            {
                var film = db.Films.FirstOrDefault(f => f.Id == filmId);
                if (film != null)
                {
                    return film;
                }
            }
            return null;
        }

        //Getting a genre by the Id value
        public Categories GetGenreById(int categoryId)
        {
            using (var db = new CinemaDB())
            {
                var genre = db.Categories.FirstOrDefault(c => c.Id == categoryId);
                if (genre != null)
                {
                    return genre;
                }
            }
            return null;
        }
        //Getting a screening by the Id value
        public List<DateTime> GetScreeningTimesById(int screeningId)
        {
            using (var db = new CinemaDB())
            {
                var screening = db.Screening.FirstOrDefault(s => s.Id == screeningId);
                List<DateTime> screeningTimes = new List<DateTime>();
                if (screening != null)
                {
                    DateTime screening1 = screening.StartTime1;
                    screeningTimes.Add(screening1);
                    DateTime screening2 = screening.StartTime2 ?? default;
                    DateTime screening3 = screening.StartTime3 ?? default;

                    if (screening2 != default)
                    {
                        screeningTimes.Add(screening2);
                    }
                    if (screening3 != default)
                    {
                        screeningTimes.Add(screening3);
                    }
                    return screeningTimes;
                }
                return null;
            }
        }
    }
}

    
