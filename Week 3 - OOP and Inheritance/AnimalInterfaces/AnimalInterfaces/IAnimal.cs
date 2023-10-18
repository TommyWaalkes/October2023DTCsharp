using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterfaces
{
    public enum food
    {
        plant,
        meat,
        light
    }
    //IAnimal makes me think of IClaudius
    internal interface IAnimal
    {
        //Even C# can put properties into interface, which other languages do not do 
        //They come with a lot of syntax, so much so that I find easier to just handle 
        //Properties in each child
        //int caloriesNeed { get; set; }
        //int caloriesEaten { get; set; }
        //List<food> Diet {  get; set; }

        //Children must fill in the body, we do care how, but just that they do it
        public bool IsFull();

        public void Eat(food foodType, int amount);

    }
}
