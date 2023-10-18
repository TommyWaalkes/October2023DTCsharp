using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaces
{
    internal class Deer : IAnimal
    {
        public int CaloriesNeeded { get; set; } = 1200;
        public int CaloriesEaten { get; set; } = 0;
        public List<food> Diet { get; set; } = new List<food>();

        public Deer()
        {
            Diet.Add(food.plant);
        }

        public void Eat(food foodType, int amount)
        {
            if (Diet.Contains(foodType))
            {
                CaloriesEaten += amount;
            }
        }

        public bool IsFull()
        {
            return CaloriesNeeded <= CaloriesEaten;
        }
    }
}
