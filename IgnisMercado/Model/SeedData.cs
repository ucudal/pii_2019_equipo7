using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;


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
                SeedPropuestas(context);
                SeedEmpresa(context);
                SeedTecnicos(context);
                SeedPuestos(context);
            }
        }
        private static void SeedPropuestas(ApplicationContext context)
        {
            // Busca Propuestas.
            if (context.Propuestas.Any())
            {
                return;   // DB ha sido poblada.
            }
            context.Propuestas.AddRange(GetSeedingPropuestas());
            context.SaveChanges();

        }
            public static List<Propuesta> GetSeedingPropuestas()
            { 
                return new List<Propuesta>()
                { 
                new Propuesta
                {
                    ID = 1,
                    Title = "Propuesta Laboral para Camarografo",
                    EstimadoDeHora = 12,
                    DescripcionDeLaPropuesta = "Se necesita camarografo con nivel avanzado para realizar un filme corto."
                },
                new Propuesta
                {
                    ID = 2,
                    Title = "Propuesta Laboral para Director",
                    EstimadoDeHora = 20,
                    DescripcionDeLaPropuesta = "Se solicita director con nivel avanzado para dirigir un filme corto."
                },
                new Propuesta
                {
                    ID = 3,
                    Title = "Propuesta Laboral para ayudante de Director",
                    EstimadoDeHora = 15,
                    DescripcionDeLaPropuesta = "Se necesita director con nivel básico para hacer de ayudante en filme corto."
                }

            };


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

        }

        private static void SeedTecnicos(ApplicationContext context)
        {
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

        private static void SeedPuestos(ApplicationContext context)
        {
            if (context.Puesto.Any())
            {
                return;   // DB ha sido poblada.
            }
            context.Puesto.AddRange(GetSeedingPuestos(context));
            context.SaveChanges();     
        }
         public static List<Puesto> GetSeedingPuestos(ApplicationContext context)
        {
            return new List<Puesto>()
            {
                new Puesto
                {
                    PropuestaID = context.Propuestas.Single(m => m.Title == "Propuesta Laboral para Camarografo").ID,
                    TrabajoName = "Camarografo"
                },
                new Puesto
                {
                    PropuestaID = context.Propuestas.Single(m => m.Title == "Propuesta Laboral para Director").ID,
                    TrabajoName = "Director"
                },
                new Puesto
                {
                    PropuestaID = context.Propuestas.Single(m => m.Title == "Propuesta Laboral para ayudante de Director").ID,
                    TrabajoName = "Director"
                }
            };
        }

    }
}