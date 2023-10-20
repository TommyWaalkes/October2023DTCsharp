
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie m = new Movie("Shrek", 90, "George Lucas", 2000);
            Movie m2 = new Movie("Star Wars", 120, "George Lucas", 1974);
            Movie m3 = new Movie("The Exorcist", 75, "Tim Directorman", 1979);
            //Movie m = new Movie() { Title = "shrek" };
            string json = MovieToJson(m);
            Movie newM = JsonToMovie(json);
            Console.WriteLine(newM.Title);
            AddMovieToFile(m);
            AddMovieToFile(m2);
            AddMovieToFile(m3);
        }

        public static void AddMovieToFile(Movie m)
        {
            string relPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\Movies.txt";
            StreamReader sr = new StreamReader(relPath);
            string movies = sr.ReadToEnd();
            sr.Close();

            StreamWriter sw = new StreamWriter(relPath);
            string json = MovieToJson(m);
            movies += "\n" + json;
            sw.Write(movies);
            sw.Close();
        }

        public static string MovieToJson(Movie m)
        {
            //string json = JsonConvert.SerializeObject(m);
            string json = JsonSerializer.Serialize(m);

            Console.WriteLine(json);
            return json;
        }

        public static Movie JsonToMovie(string json)
        {
            Movie m = JsonSerializer.Deserialize<Movie>(json);
            return m;
        }

        public static void FileIO()
        {
            try
            {
                //First thing you want to do is figure out your file path
                //Use and @ to tell C# you are making a file path so it should not treat the slashes as escape character
                string absPath = @"C:\\Users\\thoma\\Desktop\\Class Repo Oct 2023\\Week 3 - OOP and Inheritance\\FileIO\\FileIO\\Countries.txt";
                string relPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\Countries.txt";
                Console.WriteLine(relPath);
                StreamReader sr = new StreamReader(relPath);

                //Stream reader has 2 ways of looking at the content of your file: 
                //Line by line or all at once. 
                //Generally I do all at once, but if a file a huge line by line will run smoother
                string content = sr.ReadToEnd();

                string[] countries = content.Split(",");

                foreach (string country in countries)
                {
                    Console.WriteLine(country.Trim());
                }

                //Generally most computers will only allow a file to opened by one program at a time 
                //Without that restriction, 2 programs looking at the file can create a infinite loop 
                //That freezes the computer. It is possible to have 2 programs edit the same file at once 
                //But it requires very specific extra code. The idea that when a file is open 
                //Your OS will place a lock on them. 

                //Visual Studio will not release on locks on files even if you close out and wait several minutes
                //Git Ignores will ignore a lot of the files Visual Loves to lock
                sr.Close();
                Console.WriteLine("Please input a new country:");
                string newCountry = Console.ReadLine();
                List<string> countryList = countries.ToList();
                countryList.Add(newCountry);
                //USA, Canada, France, Kenya, Japan
                StreamWriter sw = new StreamWriter(relPath);
                //By itself writeline will override the contents of our file
                sw.Write(content + "," + newCountry);
                sw.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The file path was bad");
            }
        }
    }
}