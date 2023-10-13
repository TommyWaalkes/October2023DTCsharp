namespace ListsandDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {12,15,29, 83, 13 };
            nums.Add(1);
            //Like with arrays, lists will throw an expection when given a bad index
            //Console.WriteLine(nums[1]);

            nums.Add(5);
            nums.Add(100);

            nums[2] = 35;

            for(int i = 0; i < nums.Count; i++)
            {
                int num = nums[i];
                if(num % 2 == 0)
                {
                    Console.WriteLine($"{num} is even");
                }
                else
                {
                    Console.WriteLine($"{num} is odd");
                }
            }

            //Modifications made to a list in a method update the list everywhere else, just liek arrays
            List<string> names = new List<string>() { "tmy" , "Jimmy", "Strom", "Clearance"};
            List<int> vowelIndexes = FindFirstVowelIndex(names.ToArray());

            PrintList(vowelIndexes);

            Dictionary();

        }

        //Why don't show up more often? They create a relationship between 2 pieces of data. 
        //The reason is that object handle representing a lot more clearly 
        //In dictionaries keys must all be unique, you can't use the same key more than onces 
        //Values however, may be reused as much as you want
        public static void Dictionary()
        {
            //The first type is the key type 
            //the second type is the value type
            Dictionary<string, string> namesToPasswords = new Dictionary<string, string>();

            namesToPasswords.Add("Tommy", "password1234!");
            namesToPasswords.Add("Frankie", "pizzaTime1947");
            namesToPasswords.Add("Dan", "ScrambledEgg1122");
            namesToPasswords.Add("sezxdrfgvhbunim", "azsexdrftyghuolp;[");

            string pass = namesToPasswords["Tommy"];
            Console.WriteLine(pass);

            //Technically a dictionary is a list of key-value pair objects 
            //Ordered by when they were added 
            foreach(var kvp in  namesToPasswords)
            {
                string key = kvp.Key; 
                string value = kvp.Value;
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
            Console.WriteLine();
            List<string> keys = namesToPasswords.Keys.ToList();

            for(int i = 0; i < keys.Count; i++)
            {
                string key = keys[i];
                string value = namesToPasswords[key];

                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            Dictionary<string, double> passwordToBalance = new Dictionary<string, double>();
            foreach(string password in namesToPasswords.Values)
            {
                Random r = new Random();
                double cash = r.Next(1, 10000);
                passwordToBalance.Add(password, cash);
            }

            Console.WriteLine("Whose balance would you like to learn about?");
            foreach(string name in namesToPasswords.Keys)
            {
                Console.WriteLine(name);
            }

            string selected = Console.ReadLine();
            //string s = namesToPasswords[selected];
            if(namesToPasswords.ContainsKey(selected))
            {
                string password = namesToPasswords[selected];
                double balance = passwordToBalance[password];
                Console.WriteLine($"{selected} has ${balance} in their account.");
            }
            else
            {
                Console.WriteLine($"{selected} isn't in the dictionary");
            }
        }

        public static void PrintList(List<int> nums)
        {
            for(int i =0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static List<int> FindFirstVowelIndex(params string[] words)
        {
            List<int> outputIndexes = new List<int>();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for(int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                for(int j =0; j < word.Length; j++)
                {
                    char c = word[j];
                    if (vowels.Contains(c))
                    {
                        outputIndexes.Add(j); 
                        break;
                    }
                    if(j == word.Length - 1)
                    {
                        outputIndexes.Add(-1);
                    }
                }
            }

            return outputIndexes;


        }
    }
}