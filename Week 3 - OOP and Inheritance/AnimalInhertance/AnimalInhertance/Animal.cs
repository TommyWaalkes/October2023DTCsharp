using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInhertance
{
    public enum Food
    {
        Meat, 
        Plants, 
        Light
    }
    internal class Animal
    {
        public int CaloriesNeeded { get; set; }
        public int CaloriesEaten { get; set; } = 0;
        public List<Food> Diet { get; set; } = new List<Food>();

        public Animal(int CaloriesNeeded, params Food[] diet)
        {
            this.CaloriesNeeded = CaloriesNeeded;
            this.Diet = diet.ToList();
        }

        public virtual bool IsFull()
        {
            return CaloriesEaten >= CaloriesNeeded;
        }

        public virtual void Eat(Food foodType, int amount)
        {
            if (Diet.Contains(foodType))
            {
                CaloriesEaten += amount;
            }
            else
            {
                Console.WriteLine("This animal won't eat this type of food: " +foodType);
            }
        }

        public override string ToString()
        {
            string output = "Calories Eaten: " + CaloriesEaten + "\n";
            output += "Calories Needed: " + CaloriesNeeded + "\n";
            output += "Is Full: " + IsFull() + "\n";
            output += "Diet: " + '\n';
            foreach(Food food in Diet)
            {
                output += food.ToString();
            }
            return output;
        }
    }
}
