namespace Blockbuster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alternate way of making objects, this is good to mention 
            //since .Net will automatically build fill out objects 
            //And this syntax is useful in Javacript 
            //Movie m = new Movie() { Title = "Hello", Genre = Genre.Horror, Runtime=10,
            ////    Scenes = new List<string>() {"blah" } };

            //DVD d = new DVD("Shrek", Genre.Religion, 192, "Get out of my swamp", "Rescue princess", "Wedding scene");

            ////Since we overrode ToString we can print out the movie directly 
            ////Javascript will natively let you print objects, the downside is that Javascript's debugger isn't as useful 
            //Console.WriteLine(d);
            //d.Play();

            //VHS v = new VHS("Find Nemo", Genre.Animated, 120, "Nemo is lost", "Dentist scene", "Sharks", "Find Nemo");
            //for (int i = 0; i < 10; i++)
            //{
            //    v.Play();
            //}

            Blockbluster b = new Blockbluster();
            Movie m = b.Checkout();
            m.Play();
        }
    }
}