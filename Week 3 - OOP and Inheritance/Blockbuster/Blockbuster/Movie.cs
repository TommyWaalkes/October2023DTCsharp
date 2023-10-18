using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public enum Genre
    {
        Animated,
        Horror,
        Comedy, 
        Drama,
        Religion
    }
    internal abstract class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();

        public Movie() { }

        public Movie(string title, Genre genre, int runtime, params string[] scenes)
        {
            Title = title;
            Genre = genre;
            Runtime = runtime;
            Scenes = scenes.ToList();
        }

        public override string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Genre: {Genre} \n";
            output += $"Run Time: {Runtime}\n";
            output += $"Scene Count: {Scenes.Count}\n";
            return output;
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i}:{Scenes[i]}");
            }
        }

        //I know VHS and DVD will have totally different play methods
        public abstract void Play();
    }
}
