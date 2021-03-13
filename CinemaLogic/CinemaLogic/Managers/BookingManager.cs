using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaLogic.Managers
{
    public class BookingManager
    {
        CinemaManager managerCinema = new CinemaManager();
        public Films BookFilm(int id, string time)
        {
            using (var db = new CinemaDB())
            {
                var film = managerCinema.ChooseAFilm(id);
                
                if (film != null)
                {
                    db.UserFilms.Add(new UserFilms()
                    {
                        FilmId = film.Id,
                        FilmTitle = film.Title,
                        ScreeningTime = time
                    });
                    db.SaveChanges();
                    return film;
                }
            }
            return null;
        }
        //getting the film user has chosen
        public List<UserFilms> GetUserFilm()
        {
            using (var db = new CinemaDB())
            {
                return db.UserFilms.ToList();
            }
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
