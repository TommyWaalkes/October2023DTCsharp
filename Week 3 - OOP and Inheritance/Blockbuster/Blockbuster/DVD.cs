using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    internal class DVD : Movie
    {
        public DVD(string title, Genre genre, int runtime, params string[] scenes) 
            : base(title, genre,runtime, scenes ) { 
        
        }
        public override void Play()
        {
            Console.WriteLine("Select which scene you wish to watch: 0-"+(Scenes.Count - 1));
            int pick = -1; 
            try
            {
                pick = int.Parse(Console.ReadLine());
                Console.WriteLine(Scenes[pick]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Lets try that again!");
                Play();
            }
        }
    }
}
