using System.Globalization;

namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = GetUserInput("Please input a word to translate to pig Latin");

            string[] words = input.Split();
            words.

            //3 Cases we care about 
            //1) Start with a vowel - add ay onto the end
            //2) Start with a consonant - move leading consonants to the end and add ay 
            //3) No vowels - don't translate the word 

            //if (word.Contains("'"))
            //{
            //    Console.WriteLine("This word is a contraction and can't translated to pig latin");
            //    return;
            //}
            foreach (string word in words)
            {
                Translate(word);
            }
          
        }

        public static void Translate(string word)
        {
            bool dontTranslate = ContainsNumberOrSymbol(word);
            bool hasVowel = HasVowel(word);
            if (word.Length > 0)
            {
                if (dontTranslate == false)
                {

                    string[] punct = { ",", ".", "!", "?" };
                    bool hasPunct = false;
                    foreach (string p in punct)
                    {
                        if (word.Contains(p))
                        {
                            hasPunct = true;
                        }
                    }

                    char ending = ' ';
                    if (hasPunct)
                    {
                        ending = word[word.Length - 1];
                        word = word.Substring(0, word.Length - 1);
                        //Console.WriteLine(word);
                    }


                    if (hasVowel)
                    {
                        int first = FindFirstVowel(word);
                        //Console.WriteLine(first);

                        //This means the word starts with vowel 
                        if (first == 0)
                        {
                            word += "way";
                        }
                        else
                        {
                            //Using the index of the first vowel, cut off everything up to 
                            //But not including the first vowel.
                            bool startWithUpper = char.IsUpper(word[0]);

                            string postFix = word.Substring(0, first);

                            //Console.WriteLine(postFix);

                            string preFix = word.Substring(first);
                            //Console.WriteLine(preFix);


                            if (startWithUpper)
                            {
                                //string firstLetter = preFix[0].ToString().ToUpper();

                                //char c = char.Parse(firstLetter);
                                //char[] letters = preFix.ToCharArray();
                                //letters[0] = c;
                                //preFix = new String(letters);

                                preFix = new CultureInfo("en-us", false).TextInfo.ToTitleCase(preFix);
                                word = preFix + postFix + "AY";

                            }
                            else
                            {
                                word = preFix + postFix + "ay";
                            }
                        }

                        if (hasPunct)
                        {
                            word += ending;
                        }

                        Console.Write(word +" ");
                    }
                    else
                    {
                        Console.WriteLine($"{word} cannot be translated into pig Latin");
                    }
                }
                else
                {
                    Console.WriteLine("Skipping the current word as it contains symbols or numbers");
                }
            }
            else
            {
                Console.WriteLine("No input was given, word is 0 character long and can't be translated");
            }

        }

        public static bool ContainsNumberOrSymbol(string input)
        {
            string[] skips = { "@", "#", "$", "%", "^", "&", "*", "(", ")" };

            for(int i =0; i < input.Length; i++)
            {
                string s = input[i].ToString();
                char c = input[i];
                if(skips.Contains(s) || char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
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