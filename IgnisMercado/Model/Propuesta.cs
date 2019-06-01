using System;
using System.ComponentModel.DataAnnotations;

namespace IgnisMercado.Models
{
    public class Propuesta
    {
        public  int ID { get; set; }
        public string NivelDeDificultad { get; set; }
        public string EstimadoPorHora { get; set; }
        public string Estado{ get; set; }
        public string DescripcionDeLaPropuesta { get; set; }        
        public string ListaDeTecnicosPostulados { get; set; }
        public string TecnicoAsignado { get; set; }

    }
}