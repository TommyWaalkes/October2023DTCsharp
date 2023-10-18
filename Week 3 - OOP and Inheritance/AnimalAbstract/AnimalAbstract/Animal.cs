using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    public enum food
    {
        meat, plant, light
    }

    //Abstract classes are flexible, but since they have so many options,
    //there more decision involved than with interfaces
    
    internal abstract class Animal
    {
        public static List<Animal> Zoo = new List<Animal>();
        //.Net LOVES your properties having a get and set, many operations it does need those to be present 
        //So that's why we're of always putting them there. 
        public int CaloriesNeeded { get; set; }
        public int CaloriesEaten { get; set; } = 0;

        public List<food> Diet { get; set; } = new List<food>();

        //Why can I define a constructor if I can't call it? 
        //Constructors only exist to to be used by the children of abstract classes. 
        public Animal(int caloriesNeeded, params food[] diet)
        {
            CaloriesNeeded = caloriesNeeded;
            Diet = diet.ToList();
        }

        //THis is the same idea as a method stub in an interface, children must override this 
        //and supply their own version and it comes without a method body
        public abstract void Eat(food foodType, int amount);

        //Vitrual gives us the option to either take as is or override complete or override and add on
        public virtual bool IsFull()
        {
            return CaloriesNeeded <= CaloriesEaten;
        }
    }
}
