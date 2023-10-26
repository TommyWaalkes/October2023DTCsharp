namespace DependencyInjectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DI written by in C# is incredibly useful, so it's worth learning 
            //However, for the rest of this course, .Net and Javascript both have thier injections built in
            //But this is a good peak under the hood of what happens when you do injections. 
            WelcomeView wv = new WelcomeView(new DisplayMessage("Hello World"));
            wv.Display();
            wv.DisplayMethod = new CharByCharMessage("This is neat!");
            wv.Display();
        }
    }
}