using System;
using Xunit;
using IgnisMercado.Models;
using IgnisMercado.Data;

namespace IgnisMercadoTest
{
    public class IgnisMercadoTest{
        [Fact]
        public void CalculoEstimadoDeHorasTest()
        {
            Propuesta Propuesta = new Propuesta();
            Propuesta.EstimadoDeHora=150;
            Propuesta.NivelDeDificultad=IgnisData.NivelesDeDificultad[0];
            int esperado= Propuesta.EstimadoDeHora*IgnisData.PrecioHoraBasico;
            Propuesta.CalcularCostoEstimado();
            Assert.Equal(esperado,Propuesta.CostoEstimado);
        }




    }
}