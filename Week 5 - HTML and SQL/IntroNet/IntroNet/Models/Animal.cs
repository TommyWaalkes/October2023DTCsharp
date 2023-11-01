namespace IntroNet.Models
{
    public class Animal
    {
        //Models are generally just a series of properties. Maybe sometimes a constructor and sometimes code to handle conversions. 
        //All properties must be public and most often will just use get and set unmodified. 
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int CaloriesNeeded {  get; set; }
        public bool HasClaws { get; set; }

    }
}
