﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class EatLight : IEat
    {
        public int Eat(FoodType food, int amount, List<FoodType> AcceptedFoodTypes)
        {
            if(food == FoodType.Light)
            {
                return amount;
            }
            else
            {
                return 0; 
            }
        }
    }
}
