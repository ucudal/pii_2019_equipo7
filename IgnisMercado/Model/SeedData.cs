using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace IgnisMercado.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                SeedPropuesta(context);

            }
         }
        private static void SeedPropuesta(ApplicationContext context)
        {
            // Busca Propuestas.
            if (context.Propuesta.Any())
            {
                return;   // DB ha sido poblada.
            }
            context.Propuesta
            
            
            
            .AddRange(
                new Propuesta
                {
                    Title = "Propuesta Laboral para Camarografo",
                    NivelDeDificultad = "Avanzado",
                    EstimadoDeHora = 12,
                    DescripcionDeLaPropuesta = "Se necesita camarografo con nivel avanzado para realizar un filme corto."
                }
            
            );
            context.SaveChanges();
               

        }
    
     }
}