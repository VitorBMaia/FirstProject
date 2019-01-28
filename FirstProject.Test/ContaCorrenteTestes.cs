using System;
using Xunit;
using FirstProject.TiposDeConta;
using FirstProject.Excecoes;

namespace FirstProject.Test
{
    public class ContaCorrenteTestes
    {
        [Fact]
        public void DeveAcrescentarOSaldoDaConta()
        {
            var valorEsperado = 1049.95;
            var conta = new ContaCorrente(1000, "dono", DateTime.Now);
            conta.deposito(50);
            Assert.Equal(valorEsperado, conta.Saldo);

        // var valorEsperado = 1049.95;

        // var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        // conta.deposito(50);

        // Assert.Equal(valorEsperado, conta.Saldo);
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
        public void DeveImpedirOSaqueValorNegativo()
        {
            var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
            var ex = Assert.Throws<ArgumentException>(()=>conta.saque(-50));
            System.Console.WriteLine(ex.StackTrace);
        }

        [Fact]
        public void DeveImpedirOSaqueSaldoInsuficiente()
        {
            var conta = new ContaCorrente(1000, "", DateTime.Today);
            var ex = Assert.Throws<SaldoInsuficienteException>(()=>conta.saque(1050));
            System.Console.WriteLine(ex.StackTrace);
        }

        [Fact]
        public void DeveImpedirODeposito(){
        var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        var ex1 = Assert.Throws<ArgumentException>(()=>conta.deposito(-50));
        System.Console.WriteLine(ex1.StackTrace);
     

        }

        [Fact]
        public void DeveExibirATaxa(){
        var valorEsperado = 0.02;
        var conta = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
        Assert.Equal(valorEsperado, conta.calculaImposto());

        }
        
        [Fact]
        public void DeveCompararContas()
        {
            var conta1 = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
            var conta2 = new ContaCorrente(1000, "A", Convert.ToDateTime("21/01/2019"));
            var conta3 = new ContaCorrente(1001, "B", Convert.ToDateTime("21/01/2019"));
            Assert.True(conta1.Equals(conta2));
            Assert.False(conta1.Equals(conta3));


        }

        [Fact]
        public void DeveImpedirACriacaoDeUmaNovaConta()
        {
            
        }
    }
}