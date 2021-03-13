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
                return db.Films.OrderByDescending(f => f.ReleaseDate).ToList();
            }
        }
        //getting the film user has chosen
        public List<UserFilms> GetUserFilm()
        {
            using (var db = new CinemaDB())
            {
                return db.UserFilms.ToList();
            }
        }

        //method to get all of the records by category
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

        public Screening FindFilmByScreening(int booking, string title)
        {
            using (var db = new CinemaDB())
            {
                var film = ChooseAFilm(title);
                var screening = db.Screening.FirstOrDefault(s => s.Id == booking);
                if (screening != null && film != null)
                {
                    db.UserFilms.Add(new UserFilms()
                    {
                        FilmId = film.Id,
                        FilmTitle = film.Title,
                        ScreeningId = screening.Id
                    });
                    db.SaveChanges();
                    return screening;
                }
            }
            return null;
        }

        //cancelling a booking
        public UserFilms CancelBooking(int filmId)
        {
            using (var db = new CinemaDB())
            {
                var userFilm = db.UserFilms.FirstOrDefault(u => u.FilmId == filmId);

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
