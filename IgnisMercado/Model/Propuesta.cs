    
using System;
using System.ComponentModel.DataAnnotations;

namespace IgnisMercado.Models
{
    public class Propuesta
    {
        [Key]
        public  int ID { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Nivel De Dificultad")]
        public string NivelDeDificultad { get; set; }
       [Display(Name = "Estimado Por Hora")]
        public string EstimadoPorHora { get; set; }
        [Display(Name = "Title")]
        public string Estado{ get; set; }
        [Display(Name = "Title")]
        public string DescripcionDeLaPropuesta { get; set; }    
        [Display(Name = "Title")]    
        public string ListaDeTecnicosPostulados { get; set; }
        [Display(Name = "Title")]
        public string TecnicoAsignado { get; set; }

    }
}