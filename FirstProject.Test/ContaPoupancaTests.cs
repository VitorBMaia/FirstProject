using System;
using Xunit;
using FirstProject.TiposDeConta;
using FirstProject.Excecoes;

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
        public void DeveImpedirODepositoValorNegativo()
        {
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            Assert.Throws<ArgumentException>(()=> conta.deposito(-50));

        }

        [Fact]
        public void DeveImpedirOSaqueValorNegativo()
        {
            var conta = new ContaPoupanca(1000, "", DateTime.Today);
            Assert.Throws<ArgumentException>(()=> conta.saque(-50));

        }

        [Fact]
        public void DeveImpedirOSaqueSaldoInsuficiente()
        {
            var conta = new ContaPoupanca(1000, "A", Convert.ToDateTime("21/01/2019"));
            Assert.Throws<SaldoInsuficienteException>(()=> conta.saque(1001));
         
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
            var valorEsperado = 50;
            var conta = new ContaPoupanca(1000, "", DateTime.Today);
            Assert.Equal(valorEsperado, conta.calculaTributo());

        }
    }
}
