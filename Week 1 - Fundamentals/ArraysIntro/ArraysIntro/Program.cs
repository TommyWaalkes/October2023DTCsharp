namespace ArraysIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 40, 100, 1000 };
            double a = TakeAverage(nums);
            Console.WriteLine(a);
            Console.WriteLine(nums.Average());

            
            string[] names = new string[4];
            names[0] = "Jimmy";
            names[1] = "Sandy";
            names[2] = "Joey";
            names[3] = "Frankie";
           

            PrintNames(names);

            int joeyIndex = FindNameIndex(names, "azwsxetfgvbyh");
            Console.WriteLine(joeyIndex);

            Console.WriteLine(hasVowel("Joey"));
            Console.WriteLine(hasVowel("xXxSh4d0wxXx"));

            Console.WriteLine(findFirstVowelIndex("Strong"));
            Console.WriteLine(findFirstVowelIndex("rtyhgf"));
            Console.WriteLine(findFirstVowelIndex("APPLE"));
        }

        public static int findFirstVowelIndex(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            if (hasVowel(s))
            {
                char[] letters = s.ToLower().ToCharArray();
                for(int i = 0; i < letters.Length; i++)
                {
                    char c = letters[i];

                    if (vowels.Contains(c))
                    {
                        return i;
                    }
                }
                //This cant be reached, so this is here to stop C# from complaining 
                return -1;
            }
            else
            {
                Console.WriteLine("No vowels found in "+s);
                return -1;
            }
        }

        public static bool hasVowel(string s)
        {
            s= s.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)
            {
                if (s.Contains(vowel))
                {
                    return true;
                }
            }

            return false;
        }

        public static double TakeAverage(int[] nums)
        {
            double sum = 0;
            for(int i = 0; i  < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum / nums.Length;
        }

        public static void PrintNames(string[] items)
        {
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
        }

        //C# does not like Ambiguity, Javascript loves it
        public static int FindNameIndex(string[] names, string nameToSearch) 
        { 
            for(int i = 0; i<names.Length; i++)
            {
                string n = names[i];

                //When you compare strings casing matters 
                if (n.ToLower() == nameToSearch.ToLower())
                {
                    return i;
                }

            }

            return -1;
        }
    }
}