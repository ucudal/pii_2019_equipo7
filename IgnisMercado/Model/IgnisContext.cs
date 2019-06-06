using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Models
{
    public class IgnisContext : DbContext
    {
        public IgnisContext (DbContextOptions<IgnisContext> options)
            : base(options)
        {
        }

        public DbSet<IgnisMercado.Models.Movie> Movie { get; set; }
        public DbSet<IgnisMercado.Models.Movie> Propuesta { get; set; }
        public DbSet<IgnisMercado.Models.Propuesta> Propuesta_1 { get; set; }
    }
}