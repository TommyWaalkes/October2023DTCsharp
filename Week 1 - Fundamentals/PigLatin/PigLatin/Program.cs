using System.Globalization;

namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = GetUserInput("Please input a word to translate to pig Latin");

            //3 Cases we care about 
            //1) Start with a vowel - add ay onto the end
            //2) Start with a consonant - move leading consonants to the end and add ay 
            //3) No vowels - don't translate the word 

            bool hasVowel = HasVowel(word);
            Console.WriteLine(hasVowel);

            if(hasVowel)
            {
                int first = FindFirstVowel(word);
                Console.WriteLine(first);

                //This means the word starts with vowel 
                if(first == 0)
                {
                    word += "way";
                }
                else
                {
                    //Using the index of the first vowel, cut off everything up to 
                    //But not including the first vowel.
                    bool startWithUpper = char.IsUpper(word[0]);

                    string postFix = word.Substring(0, first).ToLower();

                    Console.WriteLine(postFix);

                    string preFix = word.Substring(first);
                    Console.WriteLine(preFix);


                    if (startWithUpper)
                    {
                        //string firstLetter = preFix[0].ToString().ToUpper();

                        //char c = char.Parse(firstLetter);
                        //char[] letters = preFix.ToCharArray();
                        //letters[0] = c;
                        //preFix = new String(letters);

                        preFix = new CultureInfo("en-us", false).TextInfo.ToTitleCase(preFix);
                    }

                    word = preFix + postFix + "ay";
                }

                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine($"{word} cannot be translated into pig Latin");
            }

        }
        
        public static int FindFirstVowel(string word)
        {
            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            char[] letters = word.ToCharArray();

            int i = 0;
            foreach(char let in letters)
            {
                if (vowels.Contains(let.ToString()))
                {
                    return i;
                }
                else
                {
                    i++;
                }
            }

            return -1;

        }

        public static bool HasVowel(string word)
        {
            string[] vowels = {"a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for(int i = 0;  i < vowels.Length; i++)
            {
                string v = vowels[i];
                if (word.Contains(v))
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input; 
        }
    }
}