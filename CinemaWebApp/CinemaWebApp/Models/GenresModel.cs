using CinemaLogic;
using CinemaLogic.DB;
using CinemaLogic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWebApp.Models
{
    public class GenresModel
    {
        //to display all genres
        public List<Categories> Genres { get; set; }
        //to display films in the selected category
        public List<Films> Films { get; set; }
        //to display selected genre
        public Categories ActiveCat { get; set; }
    }
}
