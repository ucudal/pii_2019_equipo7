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
                    EstimadoDeHora = 12,
                    DescripcionDeLaPropuesta = "Se necesita camarografo con nivel avanzado para realizar un filme corto."
                }
            );
            
            if (context.Tecnico.Any())
            {
                return;   // DB ha sido poblada.
            }
            context.Tecnico

            .AddRange(
                new Tecnico
                {
                    Edad = 22,
                    NivelEducativo = "Avanzado",
                    Nombre = "Jorge",
                    CorreoElectronico = "jorge@contoso.com",
                    Contacto = "095478654"
                    
                },
                new Tecnico
                {
                    Edad = 24,
                    NivelEducativo = "Intermedio",
                    Nombre = "Camila",
                    CorreoElectronico = "camila@contoso.com",
                    Contacto = "097745658"
                },
                new Tecnico
                {
                    Edad = 26,
                    NivelEducativo = "Basico",
                    Nombre = "Daniel",
                    CorreoElectronico = "daniel@contoso.com",
                    Contacto = "099545847"
                },
                new Tecnico
                {
                    Edad = 32,
                    NivelEducativo = "Avanzado",
                    Nombre = "Claudia",
                    CorreoElectronico = "claudia@contoso.com",
                    Contacto = "098458654"
                }
            );
            context.SaveChanges();
               

        }
    
     }
}