using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Movie
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Director {  get; set; }
        public int ReleaseYear { get; set; }

        public Movie(string title, int runTime, string director, int releaseYear)
        {
            Title = title;
            RunTime = runTime;
            Director = director;
            ReleaseYear = releaseYear;
        }

        public Movie()
        {

        }
    }
}
