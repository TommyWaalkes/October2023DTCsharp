using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalComposition
{
    internal class Animal
    {
        List<IIsFull> FullConditions = new List<IIsFull>();
        public int CaloriesEaten { get; set; } = 0; 
        public int CaloriesNeeded { get; set; }
        public int TimeEaten { get; set; } = 0; 
        public bool IsPanda { get; set; } 
        public List<FoodType> AcceptedFoodTypes { get; set; } = new List<FoodType>();
        public Dictionary<FoodType, int> foodsToCalories { get; set; } = new Dictionary<FoodType, int>();


        public Animal(bool isPanda,List<IIsFull> fullConditions, int caloriesNeeded, params FoodType[] foodTypes)
        {

            FullConditions = fullConditions;
            CaloriesNeeded = caloriesNeeded;
            AcceptedFoodTypes = foodTypes.ToList();
            IsPanda = isPanda;

            foreach(FoodType type in AcceptedFoodTypes)
            {
                foodsToCalories.Add(type, 0);
            }
        }

        public void Eat(FoodType type, int amount)
        {
            if (IsPanda)
            {
                amount /= 2;
            }
            if (AcceptedFoodTypes.Contains(type))
            {
                foodsToCalories[type] += amount;
                CaloriesEaten += amount;
                TimeEaten++;
            }

        }

        public bool IsFull()
        {
            //I can dynamically swap what conditions I care. Every may now have own unique set of conditions 
           for (int i = 0; i < FullConditions.Count; i++)
            {
                bool result = FullConditions[i].IsFull(this);
                if (result == false)
                {
                    return false;
                }
            }

           return true;
        }
    }
}
