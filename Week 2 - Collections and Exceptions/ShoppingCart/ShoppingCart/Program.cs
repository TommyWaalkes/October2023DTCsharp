namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Spam", "Apples", "Onions", "Snickers Bar" };

            for(int i = 0; i < items.Length +1; i++)
            {
                Console.WriteLine(i+1 +") "+items[i]);
            }

            string input = Console.ReadLine();
            int pick = int.Parse(input);
            Console.WriteLine(items[pick -1]);

            char letter = 'A';
            for(int i = 0; i < items.Length;i++)
            {
                Console.WriteLine(letter+ ") "+ items[i]);
                //Chars can be treat mathematically. On the ascii chart, each has its numeric index. 
                //By doing char++ I'm saying go to the next index in the chart 
                //All upper and lowercase characters are all grouped together in the ASCii
                letter++;
            }
            Dictionary<char, int> charactersToIndexes = new Dictionary<char, int>();
            letter = 'A';
            for(int i = 0;i < items.Length;i++)
            {
                charactersToIndexes.Add(letter, i);
                letter++;
            }

            char selected = char.Parse(Console.ReadLine().ToUpper());
            int index = charactersToIndexes[selected];
            Console.WriteLine(items[index]);

        }
    }
}