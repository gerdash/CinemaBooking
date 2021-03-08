using CinemaLogic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaLogic.Managers
{
    public class CategoryManager
    {
        public List<Categories> GetAllCategories()
        {
            //returns Categories, ordered by Title
            using (var db = new CinemaDB())
            {
                return db.Categories.OrderBy(n => n.Name).ToList();
            }
        }
    }
}
