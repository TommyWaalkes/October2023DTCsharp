using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    internal class Panda : Animal
    {
        public Panda() : base(3000, food.plant, food.meat, food.light)
        {
        }

        public override void Eat(food foodType, int amount)
        {
            if(Diet.Contains(foodType))
            {
                CaloriesEaten += amount/2;
            }
        }
    }
}
