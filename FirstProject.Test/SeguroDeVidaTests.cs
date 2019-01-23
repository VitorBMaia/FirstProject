using System;
using Xunit;
using FirstProject.Seguros;

namespace FirstProject.Test
{
    public class SeguroDeVidaTests
    {
        [Fact]
        public void DeveRetornarOValorDoTributo()
        {
            var valorEsperado = 42;
            var seguro = new SeguroDeVida();
            Assert.Equal(valorEsperado, seguro.calculaTributo());    
        }
    }
}