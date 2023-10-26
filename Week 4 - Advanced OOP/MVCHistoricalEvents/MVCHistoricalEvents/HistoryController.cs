using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistoricalEvents
{
    internal class HistoryController
    {
        public List<HistoryEvent> HistoryEventsDb = new List<HistoryEvent>();

        public HistoryController()
        {
            HistoryEventsDb.AddRange(new HistoryEvent[] {
                new HistoryEvent("Founding of Stankonia", "After an epic journey they found a really nice tree and thought it would be a good place for a city.", 1997, 1998,Era.AD),
                new HistoryEvent("Got kicked out of Taco Bell", "Prank went very wrong", 2013, 2013, Era.AD),
                new HistoryEvent("Founding of Rome", "Two brothers, raised by wolves, got into a knife fight. Winner named a city after himself", 786, 786, Era.BC),
                new HistoryEvent("Julius Caesar invents salad", "Okay it wasn't actually him, but people kinda assume its after him", 30, 30, Era.BC)
            });

            //Methods that handle views in a controller are called actions 
            //You may still write regular methods as well to help with any tasks you need to do
        }
        public void WelcomeView()
        {
            WelcomeView wv = new WelcomeView();
            wv.Display();
            SelectEventView();
        }

        public void SelectEventView()
        {
            SelectEventView sev = new SelectEventView(HistoryEventsDb);
            int pick = int.Parse(sev.GetUserInput("Please select which Event you'd like to learn about"));
            HistoryEvent picked = HistoryEventsDb[pick];
            DisplayEventView(picked);
        }

        public void DisplayEventView(HistoryEvent hEvent)
        {
            EventView ev = new EventView(hEvent);
            ev.Display();
        }
    }
}
