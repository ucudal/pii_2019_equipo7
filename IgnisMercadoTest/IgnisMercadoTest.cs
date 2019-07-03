using System;
using Xunit;
using IgnisMercado.Models;
using IgnisMercado.Data;

namespace IgnisMercadoTest
{
    public class IgnisMercadoTest{
        [Fact]
        public void TecncicoTest()
        {
            Tecnico tecnico1 = new Tecnico();
            tecnico1.Nombre = "Jorge";
            tecnico1.Contacto = "095478654";
            tecnico1.CorreoElectronico = "jorge@contoso.com";
            tecnico1.Edad = 22;
    
            Assert.Equal("Jorge",tecnico1.Nombre);
            Assert.Equal("095478654",tecnico1.Contacto);
            Assert.Equal("jorge@contoso.com",tecnico1.CorreoElectronico);
            Assert.Equal(22,tecnico1.Edad);
        }
        




    }
}