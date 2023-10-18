using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInhertance
{
    internal class Bush : Animal
    {
        //The base keyword is used to reference the direct parent of a class 
        //This is most useful for when the parent requires something that can be passing up to the parent 
        //constructor or override a method
        //Base works different for contructors vs regular methods 
        public Bush() : base(50, Food.Light)
        {
        }


    }
}
