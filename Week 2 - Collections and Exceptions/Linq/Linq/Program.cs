namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 101, 119, 100, 232, 445, 90 };

            List<int> filteredNums = nums.Where(n => n > 95).ToList();
            List<int> evens = nums.Where(n => n % 2 ==0).ToList();

            PrintNums(evens);

            //Long way for finding Evens 
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }

            //Gets you the highest number in a collection 
            int highest = nums.Max();
            int lowest = nums.Min();
            Console.WriteLine($"Highest Number: {highest}");
            Console.WriteLine($"Lowest Number: {lowest}");

            int highestEven = evens.Max();
            int highest2 = nums.Where(n => n % 2 == 0).Max();

            List<string> fastFood = new List<string>() { "Culvers", "Popeyes", "McDonalds", "Wendys" };
            fastFood.Sort();
            PrintString(fastFood);

            List<string> eRestaurants = fastFood.Where(f => !f.Contains("e")).ToList();
            PrintString(eRestaurants);

            string longestName = fastFood.OrderBy(f=> f.Length).Last();
            Console.WriteLine(longestName);

            //The main the methods you use with linq are Where() -Filtering/Searching and OrderBy() - Sorting 

        }

        public static void PrintString(List<string> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(i + " " + strings[i]);
            }
        }

        public static void PrintNums(List<int> nums)
        {
            for(int i =0; i < nums.Count; i++)
            {
                Console.WriteLine(i +" "+ nums[i]);
            }
        }
    }
}