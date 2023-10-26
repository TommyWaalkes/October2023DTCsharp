using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHistoricalEvents
{
    internal interface IView
    {
        void Display();
        string GetUserInput(string prompt);
    }

    public class WelcomeView : IView
    {
        public void Display()
        {
            Console.WriteLine("Hello welcome to our history application");
            Console.WriteLine("We have a list of accurate and historical events.");
        }

        public string GetUserInput(string prompt)
        {
            //The purpose of the view is just to gather data from our user
            //Working with it is the job of the controller, parsing, calculating, storing/updating data are some example of what happens
            //with user input in a controller
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }

    public class SelectEventView : IView
    {
        public List<HistoryEvent> Events { get; set; }

        public SelectEventView(List<HistoryEvent> events)
        {
            Events = events;
        }


        public void Display()
        {
            
        }

        public string GetUserInput(string prompt)
        {
            for(int i =0; i < Events.Count; i++)
            {
                Console.WriteLine(i+": "+Events[i].Name);
            }
            Console.WriteLine(prompt);

            return Console.ReadLine();
        }
    }

    public class EventView : IView
    {
        public HistoryEvent HistoryEvent { get; set; }

        public EventView(HistoryEvent historyEvent)
        {
            HistoryEvent = historyEvent;
        }

        public void Display()
        {
            Console.WriteLine(HistoryEvent.Name);
            Console.WriteLine("Description: "+ HistoryEvent.Description);
            Console.WriteLine($"{HistoryEvent.StartYear} to {HistoryEvent.EndYear} {HistoryEvent.Era}");

        }

        public string GetUserInput(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
