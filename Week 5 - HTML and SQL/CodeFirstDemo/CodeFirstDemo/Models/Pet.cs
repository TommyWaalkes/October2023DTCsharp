using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Pet
    {
        //Data annotations are tags that go above properties in C# to enforce rules coming a database as well as handle validation on the 
        //C# side of things. 
        //Some examples: 
        //[Key] indicates that something is meant to be a primary key
        // It's long and complicated but there is one for identity as well
        //Min and Max length on strings 
        //Min and Max values for numbers
        //when you check if modelstate.isValid it checks the model against its data annotations 
        //For any version of .Net there's not really a listing of all the data annotations in one place. 
        //SQL can mimic most data annotations, but not all of them like Range here

        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [MaxLength(15)]
        public string Species { get; set; }

        [Range(1, 99)]
        public int Age { get; set; }


    }
}
