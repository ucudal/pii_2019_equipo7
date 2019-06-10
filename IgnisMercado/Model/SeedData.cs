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
            using (var context = new IgnisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IgnisContext>>()))
            {
                // Propuetas
                if (context.Propuesta.Any())
                {
                    return;   // DB has been seeded
                }

                context.Propuesta.AddRange(

                    new Propuesta
                    {
                        Title = "When Harry Met Sally",
                       // NivelDeDificultad = "Alta",
                        //EstimadoPorHora = "6",
                        //Estado = "Aierto",
                        DescripcionDeLaPropuesta = "test"

                    }


                );
                context.SaveChanges();
            }
        }
    }
}