using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace IgnisMercado.Models
{
    public class Puesto
    {
        [Key]
        public int PropuestaID { get; set; }

        [Display(Name = "Puesto")]
        public string TrabajoName { get; set; }

        

        public Propuesta Propuesta { get; set; }
    }
}