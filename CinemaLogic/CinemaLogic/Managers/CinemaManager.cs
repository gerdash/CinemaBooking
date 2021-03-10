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
                return db.UserFilms.OrderBy(f => f.Title).ToList();
            }
        }

        //book a film for a specific time
        public Films ChooseAFilm()
        {
            //book a film by title? (title is a link to click on)

            using (var db = new CinemaDB())
            {
                
            }
            throw new NotImplementedException();
        }

        public Films BookAScreening()
        {
            //THEN choose a screening? No prbs both together
            //add to user list
            //would take away one for available seats
            throw new NotImplementedException();
        }

        //cancelling a booking
        public UserFilms CancelBooking()
        {
            throw new NotImplementedException();
        }
        
    }
}
