using Microsoft.EntityFrameworkCore;

namespace IntroFullStackAPI.Model
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieDetails> MovieDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Movies;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

    }
}
