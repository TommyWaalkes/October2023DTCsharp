namespace MVCHistoricalEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HistoryController hc = new HistoryController();
            hc.WelcomeView();
        }
    }
}