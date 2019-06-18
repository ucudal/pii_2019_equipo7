using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace IgnisMercado.Models
{
    public class FeedbackPropuesta
    {
        [Key]
        public int PropuestaID { get; set; }

        [Key]
        public int FeedbackID { get; set; }

        [Required]
        public Propuesta Propuesta { get; set; }

        [Required]
        public Feedback Feedback { get; set; }
    }
}