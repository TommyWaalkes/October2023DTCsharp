using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    public enum FoodType
    {
        Light, 
        Meat, 
        Plant
    }
    internal interface IEat
    {
        public int Eat(FoodType food, int amount);
    }
}
