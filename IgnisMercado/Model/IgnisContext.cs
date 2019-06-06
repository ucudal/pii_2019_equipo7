using Microsoft.EntityFrameworkCore;

namespace IgnisMercado.Models
{
    public class IgnisContext : DbContext
    {
        public IgnisContext (DbContextOptions<IgnisContext> options)
            : base(options)
        {
        }

        public DbSet<IgnisMercado.Models.Movie> Movie { get; set; }
    }
}