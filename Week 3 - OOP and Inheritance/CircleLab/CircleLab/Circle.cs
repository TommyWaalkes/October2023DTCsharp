using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Circle
    {
        public double Radius { get; set; }

        //This is the old pattern for initializing your variables in C# 
        //Java and other languages still use this

        //By putting the matching paramter into my constructor 
        //I am telling other devs, this object MUST get a radius
        public Circle(double Radius) {
            //The this keyword refers to the currently running object
            //Other languages call this the self keywrod instead 
            //There are other uses for this, but the main one well see for our class will be in our constructors 
            
            this.Radius = Radius;
        }

        public double GetDiameter()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
            //You could also use Math.Pow() for exponents. <-- good for handling weird exponents

            //Exponents in programming appear in a few cases: Statistics, Animation, Physics simulation
            //return Math.Pow(Radius, 2) * Math.PI;
        }

        public double GetCircumfernce()
        {
            return 2 * Math.PI * Radius;
        }

        public void Grow()
        {
            Radius *= 2;
        }

        //In languages without built in getters and setters this is how 
        //You handle seeing and changing the values of an objects 
        //For each variable you'd need to write a get and set value
        public double GetRadius()
        {
            return Radius;
        }

        public void SetRadius(double radius)
        {
            this.Radius = radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Diameter: {GetDiameter()}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Circumference: {GetCircumfernce()}");
        }
    }
}
