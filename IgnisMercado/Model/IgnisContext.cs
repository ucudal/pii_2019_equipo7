using Microsoft.EntityFrameworkCore;
using System;
namespace IgnisMercado.Models
{
    public class IgnisContext : DbContext
    {
        public IgnisContext (DbContextOptions<IgnisContext> options)
            : base(options)
        {
        }

        public DbSet<IgnisMercado.Models.Propuesta> Propuesta{ get; set; }

        public DbSet<IgnisMercado.Models.Feedback> Feedback { get; set; }
         public DbSet<IgnisMercado.Models.Movie> Movie { get; set; }
    }
}