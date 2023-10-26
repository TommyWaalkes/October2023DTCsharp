using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public enum Era
    {
        AD,
        BC
    }
    public class HistoryEvent
    {
        //In .Net models just need to be a series of properties, without much additional 
        public string Name { get; set; }
        public string Description { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public Era Era { get; set; }

        //.Net heavily uses the default empty constructor for models, so if you wish to define, you need to also define an empty constructor
        public HistoryEvent()
        {

        }

        public HistoryEvent(string name, string description, int startYear, int endYear, Era era)
        {
            Name = name;
            Description = description;
            StartYear = startYear;
            EndYear = endYear;
            Era = era;
        }
    }
}
