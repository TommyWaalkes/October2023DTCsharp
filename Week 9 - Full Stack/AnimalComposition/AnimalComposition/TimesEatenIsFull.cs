using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class TimesEatenIsFull : IIsFull
    {
        public int TimeRequired { get; set; }

        public TimesEatenIsFull(int timeRequired)
        {
            TimeRequired = timeRequired;
        }

        public bool IsFull(Animal a)
        {
            return a.TimeEaten >= TimeRequired;
        }
    }
}
