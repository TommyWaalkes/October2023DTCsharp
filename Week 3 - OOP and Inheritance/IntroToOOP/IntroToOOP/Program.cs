namespace IntroToOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Card c = Card.GetRandomCard();
                c.PrintInfo();
            }
            WarGame wg = new WarGame();
            wg.RunTurn();
        }
    }
}