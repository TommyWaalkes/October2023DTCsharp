using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class EatOneFood : IEat
    {
        public FoodType FoodEaten {  get; set; }
        public EatOneFood(FoodType foodEaten)
        {
            FoodEaten = foodEaten;
        }
        public int Eat(FoodType food, int amount, List<FoodType> AcceptedFoodTypes)
        {
            if(food == FoodEaten)
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
