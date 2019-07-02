    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{
    public class Tecnico : User
    {
        [Display(Name = "Edad")]
        public  int Edad { get; set; }
        [Display(Name = "Nivel Educativo")]
        public string NivelEducativo { get; set; }
       
       
    }  
    
}