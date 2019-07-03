using System;
using Xunit;
using IgnisMercado.Models;
using IgnisMercado.Data;

namespace IgnisMercadoTest
{
    public class IgnisMercadoTest
    {
    
    [Fact]
    public void TestEmpresa()
    {
        Empresa empresa1 = new Empresa();
        empresa1.Nombre = "Oracle";
        empresa1.Contacto = "+3 555 666";
        empresa1.CorreoElectronico = "oracle@oracle.com";
        empresa1.Descricpion = "Desarollo de soluciones para la nube y locales.";
        empresa1.ID = 1;
        Assert.Equal("Oracle",empresa1.Nombre);
        Assert.Equal("+3 555 666",empresa1.Contacto);
        Assert.Equal("oracle@oracle.com",empresa1.CorreoElectronico);
        Assert.Equal("Oracle",empresa1.Nombre);
        Assert.Equal("Desarollo de soluciones para la nube y locales.",empresa1.Descricpion);
        Assert.Equal(1,empresa1.ID);
    }

    public void TestPropuesta()
    {
        Propuesta propuesta1 = new Propuesta();
        propuesta1.Title = "Propuesta X"; 
        propuesta1.DescripcionDeLaPropuesta = "Descripcion X";
    }

    }
}