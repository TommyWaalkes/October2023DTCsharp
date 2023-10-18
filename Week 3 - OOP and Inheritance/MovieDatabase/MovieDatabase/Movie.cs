using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public enum Category
    {
        Horror, 
        Animated, 
        Drama, 
        Comedy,
        SciFi, 
        Religion
    }
    internal class Movie
    {
        //C# automatically puts get and set onto varialbes 
        //Older versions would not allow you to do that
        public string Title;
        public Category Category;
        public double Runtime { get; set; }
        public int ReleaseYear { get; set; }

        //This is what Java would to do 
        //public void SetTitle(string newTitle)
        //{
        //    Title = newTitle;
        //}
        //public string GetTitle()
        //{
        //    return Title; 
        //}
        public Movie(string title, Category category, double runtime, int releaseYear)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            ReleaseYear = releaseYear;
        }
    }
}
