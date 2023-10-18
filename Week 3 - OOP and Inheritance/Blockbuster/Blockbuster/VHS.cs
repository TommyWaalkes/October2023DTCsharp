using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    internal class VHS : Movie
    {
        public int CurrentSceneIndex = 0;

        public VHS(string title, Genre genre, int runtime, params string[] scenes)
           : base(title, genre, runtime, scenes)
        {

        }
        public override void Play()
        {
            if (CurrentSceneIndex < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentSceneIndex]);
                CurrentSceneIndex++;
            }
            else
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            Console.WriteLine("Rewinding the movie");
            CurrentSceneIndex = 0;
        }
    }
}
