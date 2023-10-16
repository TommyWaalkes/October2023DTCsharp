namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //By doing this the variables should be both to the same location in memory

            //This is a shallow copy, we're just copying a pointer to a spot in memory and not the array itself
            int[] nums = { 90, 10, 43, 99, 101 };
            int[] nums2 = nums;
            int[] nums3 = new int[nums.Length];
            //This will do actual copying this is called deep copy

            //Copy will not override an exist reference to another array
            Array.Copy(nums, nums2, nums.Length);

            //When we call clear nums and nums2 still reference the same spot
            //Array.Clear(nums);

            nums[0] = 1001;

            Halve(nums);

            //When you call sort, the array gets updated with the sorted data 
            Array.Sort(nums);

            PrintNums(nums);
            PrintNums(nums2);
            PrintNums(nums3);

            //ToList() Converts our array into a list collections 
            //In C# lists are incredibly often, and if an array can't do something 
            //There's a good chance a list can and vice versa

            //Lists may shrink or grow size automatically
            //Super important method you will use it to convert any collection into a list

            //In java this is several lines of code that are easy to break 
            List<int> list = nums.ToList();

            int[] nums4 = list.ToArray();

            //Arrays vs Lists 
            //Lists may shrink and grow and has more methods built in than arrays. In C# most default to list.
            //Arrays may not shrink or grow, but they are more performant to run. Arrays are a set size. 
        }

        public static void PrintNums(int[] ints)
        {
            Console.WriteLine();
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        //Modifications made to an array in another class or method 
        //are permanent, they appear every else in the code
        public static void Halve(int[] nums)
        {
            //Foreach loops will not let you modify the array you're iterating through
            //foreach(int n in nums)
            //{
            //    n +=2;
            //}

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] /= 2;
            }
        }
    }
}