namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = ConvertDoubletoInt(10);
            Console.WriteLine(output);

            int output2 = ConvertDoubletoInt(10.49);
            Console.WriteLine(output2);
            string input = GetUserInput("Please input a valid decimal radius for a circle");
            Console.WriteLine(GetAreaCircle(double.Parse(input)));
        }

        public static int ConvertDoubletoInt(double num)
        {
            //Everything can be a string -all datatypes can be converted in and out of being a string 
            //All types and class have a built in method called ToString() 

            //string s = num.ToString();
            int output = Convert.ToInt32(num);
            return output;
        }

        public static double GetAreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            //Right here is a good spot to validate or convert your input 
            //When we learn more validation we'll put some code here

            return input;
        }
    }
}