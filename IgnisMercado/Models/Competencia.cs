using System;
using System.ComponentModel.DataAnnotations;

namespace IgnisMercado.Models
{
    public class Competencia
    {
        public int ID { get; set; }
        public string NivelBasicoOAvanzado { get; set; }
        public string PrecioPorHora { get; set; }


    }
}