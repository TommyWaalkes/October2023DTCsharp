namespace CircleCalculator
{
    internal class Program
    {
        //When you your code, C#/Visual Studio runs your main method from top to bottom 
        static void Main(string[] args)
        {
            Console.WriteLine(  "Hello world!");
            Console.WriteLine("My favorite burger place is Culver's");
            Console.WriteLine("Welcome to our circle calculator");
            Console.WriteLine( "Please input a radius");
            string input = Console.ReadLine();
            //Parse converts from a string into a particular datatype 
            //Most built in data types have a parse method 
            //String is the exception 
            double radius = Double.Parse(input);

            //Math is a class with lots of formulas and constant for math 
            double area = radius * radius * Math.PI;

            //The $ and {} is called string interpolation
            //Most modern languages will have some form of this feature 
            Console.WriteLine($"Area: {area}");

        }
    }
}