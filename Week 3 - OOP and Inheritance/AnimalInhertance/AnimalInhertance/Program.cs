namespace AnimalInhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bush b = new Bush();
            Console.WriteLine(b.IsFull());
            b.Eat(Food.Light, 50);
            Console.WriteLine(b.IsFull());

            Wolf w = new Wolf();
            Console.WriteLine(w);
            w.Eat(Food.Plants, 1000);
            Console.WriteLine(w.IsFull());
            w.Eat(Food.Plants, 1000);
            w.Eat(Food.Plants, 1000);
            w.Eat(Food.Plants, 1000);
            w.Eat(Food.Meat, 1000);
            Console.WriteLine(w.IsFull());



        }
    }
}