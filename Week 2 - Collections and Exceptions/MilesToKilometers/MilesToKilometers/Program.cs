namespace MilesToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] miles = { 10.1, 5.4, 16.2, 30.24 };

            //I can put in as many doubles as I wish into this params method 
            //Or as we saw earlier we can feed in an array
            double[] kilos = MilesToKm(11.3, 13.8, 9.7, 50.3);

            for(int i = 0; i < kilos.Length; i++)
            {
                Console.WriteLine($"Miles: {miles[i]} Kilos: {kilos[i]}");
            }
        }

        //The params is unique to C# and it allows a method to take either an array or a comma separate list 
        //of literals. It can handle as many or as few literals as you wish. 
        //if you want to use params, the parameter must be an array and must be the last parameter in the listing of 
        //parameters, so the params does not get confused with other parameters. 

        //Params is useful when you don't how many inputs you need ahead of time
        public static double[] MilesToKm(params double[] miles)
        {
            double[] kilos = new double[miles.Length];

            for(int i = 0; i < kilos.Length; i++)
            {
                kilos[i] = miles[i] * 1.60934;
            }

            return kilos;
        }
    }
}