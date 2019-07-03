using System;

namespace IgnisMercado.Models
{
    public class CalculadorBasico : ICalculador
    {
        private Propuesta Propuesta;
        public CalculadorBasico(Propuesta Propuesta)
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