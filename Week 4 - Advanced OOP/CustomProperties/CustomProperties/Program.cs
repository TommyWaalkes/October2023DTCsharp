namespace CustomProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l = new Login("Tommy@email.com", "CoolGuy87", "password1234");
            string email = l.Email;
            Console.WriteLine(email);
            l.UserName = "ILikeMangoes";
            l.CheckLogin("Tommy@email.com", "CoolGuy87", "password1234");
            email = l.Email;
            Console.WriteLine(email);
            l.UserName = "ILikeMangoes";
            Console.WriteLine(l.UserName);

        }
    }
}