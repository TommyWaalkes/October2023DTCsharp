namespace RoomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, this is a spiffy program!!!");
            Console.WriteLine("In the burger world, tommy is king");
            bool goOn = true;

            while (goOn == true)
            {
               
                Console.WriteLine("Hello and welcome to our Room Calculator");

                Console.WriteLine("Please input a width");
                string wInput = Console.ReadLine();
                double width = double.Parse(wInput);

                Console.WriteLine("Please input a length");
                string lInput = Console.ReadLine();
                double length = double.Parse(lInput);


                Console.WriteLine("Please input a height");
                string hInput = Console.ReadLine();
                double height = double.Parse(hInput);

                double area = length * width;
                double perimeter = length * 2 + width * 2;
                double volume = width * height * length;
                double surfaceArea = 2 * (length * width + height*width + length*height);

                //These do the same thing 
                Console.WriteLine($"Area: {area}");
                Console.WriteLine("Area: " + area);

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine($"Surface Area: {surfaceArea}");

                if (area <= 250)
                {
                    Console.WriteLine("This is a small room");
                }
                else if (250 < area && area <= 650)
                {
                    Console.WriteLine("This is a medium sized room");
                }
                else
                {
                    Console.WriteLine("This is a big room");
                }

                Console.WriteLine("Would you like to measure another room? y/n");

                string input = Console.ReadLine();

                if(input == "y")
                {
                    //This skips to the next run of our loop
                    continue;
                }
                else
                {
                    Console.WriteLine("Good bye!");
                    //we'll assume they want to quit
                    //This kicks us out of the loop 
                    break;
                }
            }
        }
    }
}