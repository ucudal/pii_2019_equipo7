    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{
    public abstract class User
    {
      [Key]
        public  int ID { get; set; }
        [Display(Name = "Correo Electronico")]
        public string CorreoElectronico { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
       [Display(Name = "Contacto")]
        public string Contacto { get; set; }
       
    }  
    
}