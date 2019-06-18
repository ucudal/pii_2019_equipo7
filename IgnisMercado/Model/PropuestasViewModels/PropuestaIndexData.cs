using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgnisMercado.Models.PropuestasViewModel
{
    public class PropuestaIndexData
    {
        public IEnumerable<Propuesta> Propuesta { get; set; }

        public IEnumerable<FeedbackPropuesta> FeedbackPropuesta { get; set; }
    }
}