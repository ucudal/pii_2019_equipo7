using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Areas.Identity.Data;

namespace IgnisMercado.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<FeedbackPropuesta>().ToTable("Feedback de la Propuesta")
            .HasKey(a => new { a.PropuestaID, a.FeedbackID });
        }
        public DbSet<IgnisMercado.Models.Propuesta> Propuesta { get; set; }

        public DbSet<IgnisMercado.Models.Feedback> Feedbacks { get; set; }

        public DbSet<FeedbackPropuesta> FeedbackPropuesta { get; set; }

        public DbSet<Competencia> Competencia { get; set; }
    }
}
