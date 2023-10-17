namespace CircleLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle c = new Circle(5);
            //Console.WriteLine(c.GetArea());
            //Console.WriteLine(c.GetCircumfernce());

            ////C# way of handling properties 
            //c.Radius = 10;
            //Console.WriteLine(c.Radius);

            ////THis is the non C# approach 
            //c.SetRadius(20);
            //Console.WriteLine(c.GetRadius());

            bool goOn = true; 
            while(goOn == true)
            {
                Console.WriteLine("Please input a decimal Radius to make our circle");
                double rad = 0;
                try
                {
                    rad = double.Parse(Console.ReadLine());
                    if(rad < 0)
                    {
                        throw new Exception("Circles must have a positive radius");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid radius, lets try again");
                    continue;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Lets try again");
                    continue;
                }
                Circle c = new Circle(rad);
                c.PrintInfo();

                Console.WriteLine("Would you like to make the circle grow?");
                string input = Console.ReadLine();
                if(input == "y")
                {
                    c.Grow();
                    c.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine($"Radius: {c.Radius}");
                    break;
                }
            }
        }
    }
}