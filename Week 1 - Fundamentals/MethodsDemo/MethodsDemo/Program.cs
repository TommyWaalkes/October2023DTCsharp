namespace MethodsDemo
{
    internal class Program
    {
        //Main is a method, but it is a special one 
        //When you run your code C# looks and starts in main 
        //Main as a method name is reserved for that use
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Hello, World!");
                double a = GetAreaRectangle(10, 15);
                Console.WriteLine(a);

                PrintGreeting("Tommy");

                goOn = AskToContinue();
            }
        }

        //Main can't look at the contents of a method, just its result IE what it returns
        public static double GetAreaRectangle(double length, double width)
        {
            //The method is done once you hit the return statement 
            double area = length * width;
            return area;
        }

        public static void PrintGreeting(string name)
        {
            string greeting = $"Hello, {name}. I hope you are doing well.";
            Console.WriteLine(greeting);

            //Say you're in a void method and want it to stop 
            return; //<-- this kicks you out of the method, I believe only C# and Javascript will allow you to do that
        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to run again? y/n");
            string input = Console.ReadLine();

            //3 case we care about: y, n, or anything else
            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hey I didn't understand your response");
                return AskToContinue();
            }
        }

    }
}