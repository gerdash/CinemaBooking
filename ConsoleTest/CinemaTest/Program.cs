using System;
using CinemaLogic;
using CinemaLogic.Managers;

namespace CinemaTest
{
    class Program
    {
        private static CategoryManager categories = new CategoryManager();
        private static CinemaManager films = new CinemaManager();
        static void Main(string[] args)
        {
            Console.WriteLine("Categories: ");
            categories.GetAllCategories().ForEach(n =>
            {
                Console.WriteLine(n.Name);
            });

            Console.WriteLine("Films: ");
            films.GetNewestFilms().ForEach(f =>
            {
                Console.WriteLine(f.Title);
            });

            

        }
    }
}
