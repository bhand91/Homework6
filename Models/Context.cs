using Microsoft.EntityFrameworkCore;

namespace MovieReviews.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<MovieReviews.Models.Movie> Movie { get; set; }
        public DbSet<MovieReviews.Models.Review> Review {get; set;}
    }
}