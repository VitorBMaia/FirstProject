using System;
using Xunit;
using FirstProject;

namespace FirstProject.Test
{
    public class ContaCorrenteTestes
    {
        [Fact]
        public void DeveAcrescentarOSaldoDaConta()
        {
        var valorEsperado = 1050;
        var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        conta.deposito(50);
        Assert.Equal(valorEsperado, conta.Saldo);


        }

        [Fact]
        public void DevedecrementarOSaldoDaContaIncluindoOCustoOperacional()
        {
            var valorEsperado = 898;
            var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.saque(100);
            Assert.Equal(valorEsperado, conta.Saldo);
        }

        [Fact]
        public void DeveImpedirOSaque(){

            var valorEsperado = 1000;
            var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
            conta.saque(1001);
            Assert.Equal(valorEsperado, conta.Saldo);
        }

        [Fact]
        public void DeveImpedirODeposito(){
        var valorEsperado = 1000;
        var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        conta.deposito(-50);
        Assert.Equal(valorEsperado, conta.Saldo);

        }

        [Fact]
        public void DeveExibirATaxa(){
        var valorEsperado = 0.02;
        var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        Assert.Equal(valorEsperado, conta.calculaImposto());

        }
    }
}