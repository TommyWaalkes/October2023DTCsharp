namespace MovieDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Steve buschemi is imaginary 
            List<Movie> list = new List<Movie>();
            list.Add(new Movie("Shrek", Category.Comedy, 90, 2000));
            list.Add(new Movie("The Big Lebowski", Category.Comedy, 120, 1998));
            list.Add(new Movie("Cars", Category.Comedy, 80, 2006));
            list.Add(new Movie("Finding Nemo", Category.Comedy, 100, 2004));
            list.Add(new Movie("Saving Private Ryan", Category.Comedy, 180, 1996));

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Welcome to our movie app");
                Console.WriteLine("Please input a category for movies, you wish to search for");
                Category cat = Category.Drama;
                string[] categories = Enum.GetNames(typeof(Category));
                List<Category> genres = new List<Category>();
                foreach (string category in categories)
                {
                    genres.Add((Category)Enum.Parse(typeof(Category), category));
                }
                for(int i = 0; i < genres.Count; i++)
                {
                    Category c = genres[i];
                    Console.WriteLine($"{i}: {c}");
                }
                string input = Console.ReadLine();
                try
                {
                    int index = int.Parse(input);
                    cat = genres[index];
                }
                catch (Exception e)
                {
                    try
                    {
                        cat = (Category)Enum.Parse(typeof(Category),input);
                    }
                    catch (ArgumentException e2)
                    {
                        Console.WriteLine(e2.Message);
                        Console.WriteLine("Lets try that again");
                        continue;
                    }
                }

                List<Movie> output = new List<Movie>();

                for(int i = 0; i < list.Count; i++)
                {
                    Movie movie = list[i];
                    string s = movie.Title;
                    movie.Title = "Hello";
                    if(movie.Category == cat)
                    {
                        output.Add(movie);
                    }
                }
                output = output.OrderBy(m => m.Title).ToList();
                foreach(Movie movie in output)
                {
                    Console.WriteLine($"Title: {movie.Title}, Category: {movie.Category}");
                    Console.WriteLine($"Run Time: {movie.Runtime}, Release Year: {movie.ReleaseYear}");
                }

                goOn = KeepRunning();

            }
        }

        public static bool KeepRunning()
        {
            Console.WriteLine("Would you like to run again? y/n");

            string input = Console.ReadLine().Trim().ToLower();

            if(input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                return false; 
            }
            else
            {
                //A method calling itself is called recursion 
                Console.WriteLine("I'm sorry I didn't understand lets try again");
                return KeepRunning();
            }
        }
    }
}