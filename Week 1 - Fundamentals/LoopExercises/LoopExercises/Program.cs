namespace LoopExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to take the factorial");
            int maxNum = int.Parse(Console.ReadLine());

            int total = 1;
            for(int i = 2; i <= maxNum; i++)
            {
                total *= i;
                Console.WriteLine(total);
            }

            Console.WriteLine("Moving onto shuttle launch");
            for(int i = 10; i>=0; i--)
            {
                Console.WriteLine(i);
                if(i == 0)
                {
                    Console.WriteLine("Blast off!!!!");
                }
            }

            int n = 0;
            while (n < 10)
            {
                Console.WriteLine(n);
                n++;
            }

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}