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
             builder.Entity<AsiganrTecnico>().ToTable("AsiganrTecnico")
                 .HasKey(a => new { a.TecnicoID, a.PropuestaID });
        }
        public DbSet<IgnisMercado.Models.Propuesta> Propuesta { get; set; }
        public DbSet<IgnisMercado.Models.Tecnico> Tecnico { get; set; }
        public DbSet<IgnisMercado.Models.Empresa> Empresa { get; set; }
        public DbSet<IgnisMercado.Models.Puesto> Puesto { get; set; }

        public DbSet<IgnisMercado.Models.AsiganrTecnico> AsiganrTecnico { get; set; }

      
      
    
      /*Utilizamos el patron  Demeter
      
      Asignar la responsabilidad de colaborar con objetos indirectos de un objeto dado a los objetos directos, para que ese
objeto no necesite conocer a los objetos indirectos.

       */
      
      
      public bool TecnicoExists(int id)
        {
            return this.Tecnico.Any(e => e.ID == id);
        }

        public async virtual Task<List<IgnisMercado.Models.Tecnico>> GetTecnicosAsync()
        {
            return await this.Tecnico
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Tecnico> GetTecnicoByIdAsync(int? id)
        {
            return this.Tecnico.FirstOrDefaultAsync(m => m.ID == id);
        }

        public Task<int> AddTecnicoAsync(Tecnico tecnico)
        {
            this.Tecnico.Add(tecnico);
            return this.SaveChangesAsync();
        }

        public Task<int> RemoveTecnicoAsync(Tecnico Tecnico)
        {
            this.Tecnico.Remove(Tecnico);
            return this.SaveChangesAsync();
        }

        
    }
}
