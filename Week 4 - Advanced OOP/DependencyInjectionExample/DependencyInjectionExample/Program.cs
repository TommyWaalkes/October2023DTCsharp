namespace DependencyInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DI written by in C# is incredibly useful, so it's worth learning 
            //However, for the rest of this course, .Net and Javascript both have thier injections built in
            //But this is a good peak under the hood of what happens when you do injections. 
            WelcomeView wv = new WelcomeView(new DisplayMessage("Hello World"));
            wv.Display();
            wv.DisplayMethod = new CharByCharMessage("This is neat!");
            wv.Display();
            List<HistoryEvent> HistoryEventsDb = new List<HistoryEvent>();
            HistoryEventsDb.AddRange(new HistoryEvent[] {
                new HistoryEvent("Founding of Stankonia", "After an epic journey they found a really nice tree and thought it would be a good place for a city.", 1997, 1998,Era.AD),
                new HistoryEvent("Got kicked out of Taco Bell", "Prank went very wrong", 2013, 2013, Era.AD),
                new HistoryEvent("Founding of Rome", "Two brothers, raised by wolves, got into a knife fight. Winner named a city after himself", 786, 786, Era.BC),
                new HistoryEvent("Julius Caesar invents salad", "Okay it wasn't actually him, but people kinda assume its after him", 30, 30, Era.BC)
            });

            SelectEventView sev = new SelectEventView(HistoryEventsDb, new GetString());
            string result = sev.GetUserInput();
        }
    }
}