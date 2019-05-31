using Microsoft.EntityFrameworkCore;

namespace IgnisMercado.Models
{
    public class RazorPagesFeedbackContext : DbContext
    {
        public RazorPagesFeedbackContext (DbContextOptions<RazorPagesFeedbackContext> options)
            : base(options)
        {
        }

        public DbSet<IgnisMercado.Models.Feedback> Feedback{ get; set; }
    }
}