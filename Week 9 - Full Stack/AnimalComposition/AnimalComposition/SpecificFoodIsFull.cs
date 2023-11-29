using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class SpecificFoodIsFull : IIsFull
    {
        public FoodType FoodEaten {  get; set; }
        public int AmountRequired { get; set; }

        public SpecificFoodIsFull(FoodType foodType, int amountRequired)
        {
            FoodEaten = foodType;
            AmountRequired = amountRequired;
        }

        public bool IsFull(Animal a)
        {
            int amount = a.foodsToCalories[FoodEaten];

            return amount >= AmountRequired;
        }
    }
}
