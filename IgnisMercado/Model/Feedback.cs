using System;
using System.ComponentModel.DataAnnotations;

namespace IgnisMercado.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        [Display(Name = "Valoracion Del Trabajo")]
        public string ValoracionDelTrabajo { get; set; }

    }
}