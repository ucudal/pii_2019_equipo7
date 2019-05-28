using Microsoft.EntityFrameworkCore;

namespace IgnisMercado.Models
{
    public class RazorPagesPropuestaContext : DbContext
    {
        public RazorPagesPropuestaContext (DbContextOptions<RazorPagesPropuestaContext> options)
            : base(options)
        {
        }

        public DbSet<IgnisMercado.Models.Propuesta> Propuesta{ get; set; }
    }
}