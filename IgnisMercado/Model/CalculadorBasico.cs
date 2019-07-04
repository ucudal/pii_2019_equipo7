using System;

namespace IgnisMercado.Models
{
    public class CalculadorBasico : ICalculador
    {
        private Propuesta Propuesta;
        public CalculadorBasico(Propuesta Propuesta)
        {   

            this.Propuesta = Propuesta;
            this.precioHora=100;
        
        }

        public int precioHora { get; set; }

        public int Calcular()
        {
            return  this.Propuesta.EstimadoDeHora * this.precioHora;
        }
    }
}