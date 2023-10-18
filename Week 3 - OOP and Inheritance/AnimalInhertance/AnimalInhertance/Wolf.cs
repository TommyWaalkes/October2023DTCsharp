using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInhertance
{
    internal class Wolf : Animal
    {
        public int TimesFed { get; set; } = 0;
        public Wolf() : base(800, Food.Meat)
        {
        }

        //Override keyword allow us to either supply our own version of a method OR 
        //In this case call the parent method and add onto what it does
        public override void Eat(Food foodType, int amount)
        {
            base.Eat(foodType, amount);
            if (Diet.Contains(foodType))
            {
                TimesFed++;
            }
        }

        public override bool IsFull()
        {
            return base.IsFull() && TimesFed>=4;
        }
        //Object has a ToString Method, but so does Animal, which gets used and why? 

        //C# when looking a method or property in a family tree it starts searching at the bottom of the tree. 
        //Then it moves up to the direct parent, if nothing is found it moves on through all grandparents 
        //Until it hits the object class. 
    }
}
