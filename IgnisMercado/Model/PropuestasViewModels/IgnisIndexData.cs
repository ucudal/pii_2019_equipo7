using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgnisMercado.Areas.Identity.Data;

namespace IgnisMercado.Models.IgnisViewModel
{
    public class IgnisIndexData
    {
        public IEnumerable<Propuesta> Propuesta { get; set; }
        
        public IEnumerable<Tecnico> Tecnicos  { get; set; }

        
       
    }
}