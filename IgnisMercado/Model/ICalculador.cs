using System;

namespace IgnisMercado.Models
{
    public interface ICalculador
    {

        int precioHora { get; set; }

        int Calcular();
    }
    
}