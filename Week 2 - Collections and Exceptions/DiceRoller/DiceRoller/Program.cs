namespace DiceRoller
{
    internal class Program
    {
        static void Main()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(GetRandomName());
            }
            string response = GetUserInputToContiune("Would you like to roll the dice? y/n");
            if(response == "y")
            {
                //Roll our dice
                Console.WriteLine("How many sides do you want on your dice? Positive whole numbers over 0 only");
                try
                {
                    int sides = int.Parse(Console.ReadLine());
                    if(sides <= 0)
                    {
                        throw new FormatException("Input number must be greater  than 0");
                    }
                    else
                    {
                        Random r = new Random();
                        
                        int roll1 = r.Next(1,sides+1);
                        int roll2 = r.Next(1,sides+1);
                        Console.WriteLine($"Roll 1: {roll1}, Roll 2: {roll2}");
                        if(sides == 6)
                        {
                            string result = CheckDice(roll1,roll2);
                            Console.WriteLine(result);
                        }
                        if(sides== 10)
                        {
                            string result = CheckDice10Sides(roll1,roll2);
                            Console.WriteLine(result);
                        }
                        Main();
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("That was not a vaild number let's try again");
                    Main();
                }
            }
            else
            {
                Console.WriteLine("Okay goodbye!");
            }
        }

        public static string GetRandomName()
        {
            Random r = new Random();
            //Roll a large dice and assign each person to range 
            string[] names = { "Tommy", "Joey", "Phil", "Jake", "Hannah Monsanto" };

            //The reason the max on random is exclusive is so it works easier with Arrays 
            int pick = r.Next(0, names.Length);
            return names[pick];
        }

        public static string CheckDice(int roll1, int roll2)
        {
            string result = "";
            int total = roll1 + roll2;
            if(roll1 == 1 && roll2 == 1)
            {
                result += "Snake Eyes! ";
            }
            else if (total == 3) {
                result += "Ace Deuce! ";
            }
            else if(roll1 == 6 && roll2 ==6)
            {
                result += "Box Cars! ";
            }
            else if(total == 7 || total == 11)
            {
                result += "Win! ";
            }

            if(total == 2 || total == 3 || total == 12)
            {
                result += "Craps! ";
            }
            return result;
        }

        public static string CheckDice10Sides(int roll1, int roll2)
        {
            string result = "";
            int total = roll1 + roll2;
            if(roll1 == 1 && roll2 == 1) {
                result += "Critical Miss! ";
            }
            else if(total == 7)
            {
                result += "Lucky! ";
            }
            else if(total == 13)
            {
                result += "Unlucky! ";
            }
            else if(total == 20)
            {
                result += "Critical Hit! ";
            }
            return result;
        }

        public static string GetUserInputToContiune(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine().ToLower().Trim();
            if(output == "y" || output == "n")
            {
                return output;
            }
            else
            {
                Console.WriteLine("That was not a y or n, let's try again");
                return GetUserInputToContiune(message);
            }
        }
    }
}