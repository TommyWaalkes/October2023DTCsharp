namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You Generally to avoid nesting loops outside of certain situations 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i: "+i);
                for (int j =0; j < 10; j++)
                {
                    if(j == 5)
                    {
                        break; 
                    }
                    Console.WriteLine("j: "+j);
                }
            }
            Console.WriteLine();
            //This is an infinite loop aka a loop with a bad or no end condition 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //All parts of the for loop are optional 
            //Never to do use this way, but interesting nonetheless 

            //for(; ; )
            //{
            //    Console.WriteLine("Hello world");
            //}

            //This will keep running until we get the input we want
            //While loops are customizable, they can run on any condition.
            bool goOn = true; 
            while (goOn)
            {
                Console.WriteLine("Please input a number, if it's over 1000 we can stop running the loop");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                if(num < 1000)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please input a cool name");

                string name = Console.ReadLine();

                if (name.Contains("Darkness"))
                {
                    goOn = false;
                }
                else
                {
                    //This is technically redudant, but by this line here I am saying I intend this to continue
                    goOn = true;
                }
            }
        }
    }
}