using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class PetContext : DbContext
    {
        //To get entity to setup our database we need to use a migration 
        //Migrations are a record of the current state of your models/database in C# 
        //How it works is I will create a migration and it will take a snapshot of my Models and try to create/update my database tables
        //Oftentimes, if you find an issue with your table columns, you'll to delete the table, fix the issue in your model, and 
        //Have migrations recreate your table. 
        public DbSet<Pet> Pets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //When you did your scaffold step for DB first it should be the same as what's on this line below 
                //You want to put in the name of the database you want entity to make
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Pets;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

    }
}
