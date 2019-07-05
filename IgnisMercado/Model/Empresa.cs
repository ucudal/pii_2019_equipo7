    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{
    public class Empresa : User
    {   
        
        [Display(Name = "Director")]
        public string Director { get; set; }
        [Display(Name = "Descricpion")]
        public string Descricpion  { get; set; }
        [Display(Name="Propuesta")]
        public  ICollection<Propuesta> Propuesta {get;set;} 
    }  
    
}