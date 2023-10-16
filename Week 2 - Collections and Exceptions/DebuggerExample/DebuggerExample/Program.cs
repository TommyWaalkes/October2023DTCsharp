namespace DebuggerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool aResult = IsVowel('a');
            bool bResult = IsVowel('b');
            Console.WriteLine(aResult);
            Console.WriteLine(bResult);
        }

        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool result = false;
            foreach(char v in vowels)
            {
                if (v == c)
                {
                    result = true;
                    break;
                }
               // result = v == c;
            }

            return result;
        }
    }
}