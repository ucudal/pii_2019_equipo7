    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{/*Utilizamos herencia para reaulizar lo las prpiedades de la calse User */
    public class Tecnico : User
    {
        [Display(Name = "Edad")]
        public  int Edad { get; set; }
        [Display(Name = "Nivel Educativo")]
        public string NivelEducativo { get; set; }
       
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    
    }  
    
}