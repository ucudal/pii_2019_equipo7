using System;

namespace IgnisMercado.Models
{
    public class CalculadorAvanzado : ICalculador
    {
        private Propuesta Propuesta;
        public CalculadorAvanzado(Propuesta Propuesta)
        {   

            this.Propuesta = Propuesta;

        
        }

        public int precioHora { get; set; }

        public int Calcular()
        {
            return  this.Propuesta.Horas * this.precioHora;
        }
    }
}