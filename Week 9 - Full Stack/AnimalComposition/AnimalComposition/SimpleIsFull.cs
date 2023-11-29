using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class SimpleIsFull : IIsFull
    {
        public bool IsFull(Animal a)
        {
           return a.CaloriesEaten >= a.CaloriesNeeded;
        }
    }
}
