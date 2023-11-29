namespace AnimalComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(new EatLight(), new SimpleIsFull(), 50);

            Console.WriteLine(a.IsFull());
            a.Eat(FoodType.Meat, 100);
            Console.WriteLine(a.IsFull());
            a.Eat(FoodType.Light, 100);
            Console.WriteLine(a.IsFull());
        }
    }
}