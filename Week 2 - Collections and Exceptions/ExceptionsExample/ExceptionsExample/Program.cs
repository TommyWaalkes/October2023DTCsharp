namespace ExceptionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckEmptyRooms();
            CheckAge();
        }

        public static void CheckAge()
        {
            Console.WriteLine("Please input an age and we will check what you can do, the age must be greater than 0");
            int age = -1;
            bool goodAge = int.TryParse(Console.ReadLine(), out age);
            if(goodAge && age > -1)
            {
                if (age >= 16)
                {
                    Console.WriteLine("This person can drive");
                }
                if(age >= 21)
                {
                    Console.WriteLine("This person can drink");
                }
            }
            else
            {
                Console.WriteLine("That was not a valid age");
                Console.WriteLine("Lets try that again");
                CheckAge();
            }

        }

        public static void CheckEmptyRooms()
        {
            bool[] roomsOccupied = { true, false, true, false, false };
            Console.WriteLine("Please select an even room: 0 to " + roomsOccupied.Length);

            //Block scoping for try/catch blocks still exists
            try
            {
                int index = int.Parse(Console.ReadLine());
                if(index % 2 == 1)
                {
                    //This is useful if you wish to handle validation via exceptions 
                    //In general, throw statements are rare since modern language are so thorough with exceptions
                    //Other than JS
                    throw new Exception("Odd Room numbers are bad luck in our culture so those aren't allowed");
                }

                bool occupied = roomsOccupied[index];
                Console.WriteLine($"Room {index} is occupied:{occupied}");
            }
            //You may create in the catch a varialbe representing the exception 
            //This is useful for 2 reason 1) seeing the error message 2) seeing the stack trace 
            //The exceptions you see will depend on your code/framework
            catch (FormatException f)
            {
                Console.WriteLine("That was not a valid whole number, please try again");
                Console.WriteLine(f.Message);
                Console.WriteLine(f.StackTrace);
                CheckEmptyRooms();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("That was a number not between 0 "+roomsOccupied.Length);
                Console.WriteLine("Lets try that again.");
                CheckEmptyRooms();
            }
            //This exception is the grand parent of all other exceptions 
            //Thefore any exception thrown will trigger this catch block if 
            //previous blocks don't catch it first. 
            //Generally, you want this to be last
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Lets try again");
                CheckEmptyRooms();
            }

        }
    }
}