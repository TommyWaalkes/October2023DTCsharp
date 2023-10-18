using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    internal class Blockbluster
    {
        List<Movie> movies = new List<Movie>();

        public Blockbluster()
        {
            DVD d = new DVD("Shrek", Genre.Religion, 192, "Get out of my swamp", "Rescue princess", "Wedding scene");
            VHS v = new VHS("Find Nemo", Genre.Animated, 120, "Nemo is lost", "Dentist scene", "Sharks", "Find Nemo");
            movies.Add(v);
            movies.Add(d);

        }

        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i}: {movies[i]}");
            }
        }

        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Which film would you like to watch?");

            try
            {
                int pick = int.Parse(Console.ReadLine());
                return movies[pick];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Lets try that again!");
                return Checkout();
            }
        }
    }
}
