namespace MockAssessment1
{
    public class Program
    {

        //Assessments won't ask you to write code in your main method, you will not be graded on whats there 
        //That being you are encouraged to use main to test your code
        public static void Main() {
            bool same = AreTheSame(10, 11);
            Console.WriteLine(same);
            bool same1 = AreTheSame(10, 10);
            Console.WriteLine(same1);

            double result = Subtract(15, 10);
            Console.WriteLine(result);
            double result2 = Subtract(12, 15);
            Console.WriteLine(result2);

            Console.WriteLine(FindBuildingType(2));
            Console.WriteLine(FindBuildingType(6));
            Console.WriteLine(FindBuildingType(15));
            Console.WriteLine(FindBuildingType(200));
        }

        //Parameters are like loop variables, they exist purely within the method for the methods own use
        public static bool AreTheSame(int s1, int s2)
        {
            //Return statements pass data up to where the method is called 
            //They must match the return setup in the method signature
            return s1 == s2;
        }

        public static double Subtract(double num1, double num2)
        {
            double output = num1 - num2;
            return output;
        }

        public static string FindBuildingType(int floors)
        {
            if(floors < 0)
            {
                return "Negative floors";
            }
            else if(floors <=3)
            {
                return "This is a house";
            }
            else if (floors <= 10)
            {
                return "This is an office building";
            }
            else if (floors <= 49)
            {
                return "This is a sky scraper";
            }
            else
            {
                return "This is a SUPER skyscraper";
            }
        }
    }
}