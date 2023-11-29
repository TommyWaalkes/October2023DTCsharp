using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class SimpleIsFull : IIsFull
    {
        public bool IsFull(int caloriesEat, int caloriesNeeded)
        {
           return caloriesEat >= caloriesNeeded;
        }
    }
}
