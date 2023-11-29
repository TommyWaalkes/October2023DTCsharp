using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal interface IIsFull
    {
        public bool IsFull(int caloriesEat, int caloriesNeeded);
    }
}
