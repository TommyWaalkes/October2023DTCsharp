using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class Animal
    {
        IEat EatMethod;
        IIsFull FullMethod;
        public int CaloriesEaten { get; set; } = 0; 
        public int CaloriesNeeded { get; set; }

        public Animal(IEat eatMethod, IIsFull fullMethod, int caloriesNeeded)
        {
            EatMethod = eatMethod;
            FullMethod = fullMethod;
            CaloriesNeeded = caloriesNeeded;
        }

        public void Eat(FoodType food, int amount)
        {
            int eaten = EatMethod.Eat(food, amount);
            CaloriesEaten += eaten;
        }

        public bool IsFull()
        {
            return FullMethod.IsFull(CaloriesEaten, CaloriesNeeded);
        }
    }
}
