using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaces
{
    internal class Pig : IAnimal
    {
        public int caloriesNeeded { get; set; }
        public int caloriesEaten { get; set; }
        public List<food> Diet { get; set; }
        public int plantsEaten { get; set; }
        public int meatEaten { get; set; }

        //This is a lambda attached to a property. 
        //Any variables I reference this lambda will sit and listen to 
        //and update the value of my property any time any of those variables changes
        //I don't have to remember to update this variable. 
        public bool EatenEnough => caloriesNeeded <= caloriesEaten 
            && plantsEaten >=1000 
            && meatEaten >=1000;

        public Pig()
        {
            caloriesEaten = 0;
            caloriesNeeded = 3000;
            Diet = new List<food>();
            Diet.Add(food.plant);
            Diet.Add(food.meat);
        }

        //This code only exists for pig, we have to rewrite for every child we do 
        //This illustrate the downside of interfaces, they push to write a lot of duplicate code
        public void Eat(food foodType, int amount)
        {
           if(Diet.Contains(foodType))
            {
                caloriesEaten += amount; 
                if(foodType == food.plant)
                {
                    plantsEaten += amount;
                }
                else if(foodType == food.meat)
                {
                    meatEaten += amount;
                }
            }
        }

        public bool IsFull()
        {
            return caloriesEaten >= caloriesNeeded && 
                plantsEaten >= 1000 && 
                meatEaten >= 1000;
        }
    }
}
