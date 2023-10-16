namespace LinqExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942, 1000000, 534432 };

            //5) Find all the Values between 100000 and 999999 inclusive 
            List<int> numsRange = nums.Where(n => n >= 100000 && n <= 999999).ToList();
            PrintNums(numsRange);
            //3) Find the Maximum value less than 10000
            int maxUnder10k = nums.Where(n => n<10000).Max();
            // int maxUnder10k = filteredNums.Max();
            //7) Order the list by descending order, most to least
            Console.WriteLine(maxUnder10k);
            List<int> sortedNums = nums.OrderBy(n => n).ToList();
            sortedNums.Reverse();
            PrintNums(sortedNums);


        }

        public static void PrintNums(List<int> nums)
        {
            for(int i = 0;i < nums.Count; i++)
            {
                Console.WriteLine(i+": "+nums[i]);
            }
        }
    }
}