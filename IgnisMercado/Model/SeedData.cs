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
                SeedEmpresa(context);
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
            context.SaveChanges();


        }

        private static void SeedEmpresa(ApplicationContext context)
        {
            //Busca Empresas.
            if (context.Empresa.Any())
            {
                return; //DB ha sido poblada.
            }
            context.Empresa

            .AddRange(
                new Empresa
                {
                    Director = "Battista Farina",
                    Descricpion = "Firma de diseño automotriz.",
                    Nombre = "Pininfarina",
                    CorreoElectronico = "pininfarina@pininfarina.com",
                    Contacto = "+9 566 8 5211"

                },
                
                new Empresa
                {
                    Director = "Hideo Matsushita",
                    Descricpion = "Empresa japonesa que diseña y fabrica micrófonos profesionales y sistemas de audio.",
                    Nombre = "Audio Technica",
                    CorreoElectronico = "audiotechnica@audiotechnica.com",
                    Contacto = "+3 884 555 695"
                },
                
                new Empresa
                {
                    Director = "Lawrence J. Ellison",
                    Descricpion = "Empresa de desarollo de soluciones en la nube y local.",
                    Nombre = "Oracle",
                    CorreoElectronico = "oracle@oracle.com",
                    Contacto = "+3 666 888 555 "
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