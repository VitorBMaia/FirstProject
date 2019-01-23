using System;
using Xunit;
namespace FirstProject.Test
{
    public class TotalizadorDeTributosTestes
    {
        [Fact]
        public void DeveSomarOsTributosDasContas()
        {
            var valorEsperado = 50;
            var cp = new ContaPoupanca(1000, "", DateTime.Today);
            var cdi = new ContaDeInvestimento(1000, "", DateTime.Today);
            var totalizador = new TotalizadorDetributos();
            totalizador.Acumula(cp);
            totalizador.Acumula(cdi);
            Assert.Equal(valorEsperado, totalizador.Total);
        }
    }
}