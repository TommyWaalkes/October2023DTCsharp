using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsCalendar
{
    //Enums are indexed starting at zero
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }

    public enum Months
    {
        January, 
        February,
        March, 
        April, 
        May, 
        June, 
        July, 
        August, 
        September,
        October, 
        November, 
        Decmber

    }
    internal class Day
    {
        public DaysOfWeek WeekDay { get; set; }
        public Months Month { get; set; }

        public Day( DaysOfWeek weekDay, Months month)
        {
            WeekDay = weekDay;
            Month = month;
        }
    }
}
