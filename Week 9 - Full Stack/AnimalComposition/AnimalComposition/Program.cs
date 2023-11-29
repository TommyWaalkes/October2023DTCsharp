namespace AnimalComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IIsFull> conditions = new List<IIsFull>();
            conditions.Add(new SimpleIsFull());
            conditions.Add(new SpecificFoodIsFull(FoodType.Meat, 200));
            Animal a = new Animal(
                false, 
                conditions, 
                1000,
                FoodType.Plant,
                FoodType.Meat,
                FoodType.Light
                );

            Console.WriteLine(a.IsFull());
            a.Eat(FoodType.Plant, 1500);
            Console.WriteLine(a.IsFull());
            a.Eat(FoodType.Meat, 200);
            Console.WriteLine(a.IsFull());
        }
    }
}