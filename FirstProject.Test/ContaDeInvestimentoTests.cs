using System;
using Xunit;

namespace FirstProject.Test
{
    public class ContaDeInvestimentoTests
    {
        [Fact]
        public void DeveAcrescentarOValorNoSaldo()
        {
            var valorEsperado = 1000;
            var ci = new ContaDeInvestimento(0, "", DateTime.Today);
            ci.deposito(1000);
            Assert.Equal(valorEsperado, ci.Saldo);

        }

        [Fact]
        public void DeveDecrementarOValorNoSaldo()
        {

            var valorEsperado = 500;
            var ci = new ContaDeInvestimento(1000, "", DateTime.Today);
            ci.saque(500);
            Assert.Equal(valorEsperado, ci.Saldo);
        }
        [Fact]
        public void DeveRetornarOTributo()
        {
            var valorEsperado = 30.0;
            var ci = new ContaDeInvestimento(1000, "", DateTime.Today);
            Assert.Equal(valorEsperado, ci.calculaTributo());
        }

    }
}