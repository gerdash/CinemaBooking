using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaLogic.Managers
{
    public class BookingManager
    {
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
