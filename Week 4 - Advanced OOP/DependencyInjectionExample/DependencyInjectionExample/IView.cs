using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    internal interface IView
    {
        void Display();
        string GetUserInput(string prompt);
    }

    //While this is more code, separating these into their own interfaces removes their coupling
    public interface IDisplay
    {
        void Display();
    }

    public class DisplayMessage : IDisplay
    {
        public string Message { get; set; }

        public DisplayMessage(string message)
        {
            Message = message;
        }

        public void Display() {
            Console.WriteLine(Message);
        }
    }

    public class CharByCharMessage: IDisplay
    {
        public string Message { get; set; }
        public CharByCharMessage(string message)
        {
            Message = message;
        }

        public void Display()
        {
            foreach (char c in Message)
            {
                Console.WriteLine(c);
            }
        }
    }

    public interface IGetUserInput
    {
        void GetUserInput(string prompt);
    }

    public class WelcomeView 
    {
        public IDisplay DisplayMethod { get; set; }

        //This is the injection, it will take in any version of display that I want. I can swap different functionality 
        //Without reworking this class itself
        //Injecting methods like this is called composition - instead of using inheritance directly, we allow our class 
        //To use polymorphism to figure out the version of the method it wants 
        public WelcomeView(IDisplay displayMethod)
        {
            DisplayMethod = displayMethod;
        }
        public void Display()
        {
           DisplayMethod.Display();
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
            for (int i = 0; i < Events.Count; i++)
            {
                Console.WriteLine(i + ": " + Events[i].Name);
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
            Console.WriteLine("Description: " + HistoryEvent.Description);
            Console.WriteLine($"{HistoryEvent.StartYear} to {HistoryEvent.EndYear} {HistoryEvent.Era}");

        }

        public string GetUserInput(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
