using System;
using Xunit;
using FirstProject;

namespace FirstProject.Test
{
    public class ContaPoupancaTests
    {
        [Fact]
        public void DeveDecrementarOSaldoDaConta()
        {
            var saldoEsperado = 950;
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.saque(50);
            Assert.Equal(saldoEsperado, conta.Saldo);
        }

        [Fact]
        public void DeveAcrescentarSaldo()
        {
            var saldoEsperado = 1050;
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.deposito(50);
            Assert.Equal(saldoEsperado, conta.Saldo);

        }

        [Fact]
        public void DeveImpedirODeposito()
        {
            var saldoEsperado = 1000;
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.deposito(-50);
            Assert.Equal(saldoEsperado, conta.Saldo);

        }

        [Fact]
        public void DeveImpedirOSaque()
        {
            var saldoEsperado = 1000;
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.saque(1001);
            Assert.Equal(saldoEsperado, conta.Saldo);
        }

        [Fact]
        public void DeveExibirATaxa()
        {
            var valorEsperado = 0;
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            Assert.Equal(valorEsperado, conta.calculaImposto());
        }

        [Fact]
        public void DeveRetornarOValorDoTributo()
        {
            var valorEsperado = 20;
            var conta = new ContaPoupanca(1000, "", DateTime.Today);
            Assert.Equal(valorEsperado, conta.calculaTributo());

        }
    }
}
