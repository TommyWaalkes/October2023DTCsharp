namespace EnumsCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day d = new Day(DaysOfWeek.Tuesday, Months.November);
            Console.WriteLine(d.WeekDay);
            Console.WriteLine(d.Month);

            Console.WriteLine("Please input a month and day:");
            //Few things going on with this line the (DaysOfWeek) is a cast, a short way to attempt 
            //To convert into another data type. 
            //To tell it what enum type we want in the parse, we need the typeOf our enum. 
            //That second parameter is a string like with other parses
            //In C# and others too, Day and Month are represented via enums
            string[] daysOfWeeks = Enum.GetNames(typeof(DaysOfWeek));
            for (int i = 0; i < daysOfWeeks.Length; i++)
            {
                Console.WriteLine(daysOfWeeks[i]);
            }
                Console.WriteLine("Input Day of week:");
            DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
            Console.WriteLine("Input Month: ");
            Months m = (Months)Enum.Parse(typeof(Months), Console.ReadLine());

            Day d2 = new Day(day, m);
            Console.WriteLine(d2.WeekDay);
            Console.WriteLine(d2.Month);


            for (int i = 0; i < daysOfWeeks.Length; i++)
            {
                Console.WriteLine(i +": "+daysOfWeeks[i]);
            }
            Console.WriteLine("Please select a day by index");
            int pick = int.Parse(Console.ReadLine());

            string selection =  Enum.GetName(typeof(DaysOfWeek), pick);
            if (selection != null)
            {
                DaysOfWeek d3 = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), selection);
                Console.WriteLine(d3);
            }
            else
            {
                Console.WriteLine("That was not a valid number");
            }

        }
    }
}