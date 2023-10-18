namespace AnimalAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Panda p = new Panda();
            Console.WriteLine(p.IsFull());
            p.Eat(food.plant, 3000);
            Console.WriteLine(p.IsFull());
            p.Eat(food.plant, 3000);
            Console.WriteLine(p.IsFull());
            Animal a = Animal.Zoo[0];
            //Since all my animal children count as animal 
            //When I have a list of my parent type, all of my children are welcome in that list 
            Animal.Zoo.Add(p);
        }
    }
}