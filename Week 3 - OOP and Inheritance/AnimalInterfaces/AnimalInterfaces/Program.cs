namespace AnimalInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();
            Console.WriteLine(p.IsFull());
            p.Eat(food.plant, 1000);
            p.Eat(food.meat, 2000);
            Console.WriteLine(p.IsFull());

            Deer d = new Deer();
            Console.WriteLine(d.IsFull());
            d.Eat(food.plant, 1200);
            Console.WriteLine(d.IsFull());

            Pig p2 = new Pig();
            Console.WriteLine(p2.EatenEnough);
            p2.Eat(food.plant, 1000);
            p2.Eat(food.meat, 2000);
            Console.WriteLine(p2.EatenEnough);
        }
    }
}