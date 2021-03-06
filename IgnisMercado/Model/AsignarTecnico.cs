using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace IgnisMercado.Models
{
    public class AsiganrTecnico
    {
        [Key]
        public int TecnicoID { get; set; }

        [Key]
        public int PropuestaID { get; set; }

        [Required]
        public Tecnico Tecnico { get; set; }

        [Required]
        public Propuesta Propuesta { get; set; }
    }
}