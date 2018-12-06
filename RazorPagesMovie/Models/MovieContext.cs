using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models {
    public class MovieContext : DbContext {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options) { }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Testdata> Testdatas { get; set; }
        public DbSet<Newclass> NewClases { get; set; }

    }
}