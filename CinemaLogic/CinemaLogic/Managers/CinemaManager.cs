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
        public List<UserFilms> GetUserFilm()
        {
            using (var db = new CinemaDB())
            {
                return db.UserFilms.ToList();
            }
        }

        public List<Screening> GetScreenings()
        {
            using (var db = new CinemaDB())
            {
                return db.Screening.ToList();
            }
        }

        //book a film for a specific time
        public Films ChooseAFilm(string title)
        {
            using (var db = new CinemaDB())
            {
                var film = db.Films.FirstOrDefault(f => f.Title.ToLower() == title.ToLower());
                if (film != null)
                {
                    return film;
                }
            }
            return null;
        }

        public Films BookAScreening(int screeningId)
        {
            using (var db = new CinemaDB())
            {
                var film = db.Films.FirstOrDefault(f => f.ScreeningId == screeningId);
                if (film != null)
                {
                    db.UserFilms.Add(new UserFilms()
                    {
                        FilmId = film.Id
                    });
                    db.SaveChanges();
                    return film;
                }
            }
            return null;
        }

        //cancelling a booking
        public UserFilms CancelBooking(int filmId)
        {
            using (var db = new CinemaDB())
            {
                var userFilm = db.UserFilms.FirstOrDefault(f => f.FilmId == filmId);

                if (userFilm != null)
                {
                    db.UserFilms.Remove(userFilm);
                    db.SaveChanges();
                    return userFilm;
                }
            }
            return null;

        }
        
    }
}
