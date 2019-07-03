    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{
    public class Propuesta 
    {
        
        [Key]
        public  int ID { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Estimado De Hora")]
        public int EstimadoDeHora { get; set; }
        [Display(Name = "Costo Estimado")]
        public int CostoEstimado { get; private set; }
        [Display(Name = "Estado")]
        public string Estado{ get; private set; }
        [Display(Name = "Descripcion De La Propuesta")]
        public string DescripcionDeLaPropuesta { get; set; }    
        [Display(Name = "Tecnico Asignado")]
        public Tecnico TecnicoAsignado { get; set; }
        [Display(Name = "Empresa")]
        public Empresa Empresa {get;set;}
        
        [Display(Name = "Fecha Límite De La Propuesta")]
        public DateTime FechaLimite{get; private set;}
        


       
    }
}