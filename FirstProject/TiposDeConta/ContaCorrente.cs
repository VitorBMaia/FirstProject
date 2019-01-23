using System;
using FirstProject.Excecoes;
namespace FirstProject.TiposDeConta


{
    public class ContaCorrente : Conta
    {

         const double TAXA_SAQUE = 0.02;
        
        public ContaCorrente(double saldo, string nome, DateTime dataAbertura): base(saldo, nome, dataAbertura) {

        }

        public override double calculaImposto()
        {
            System.Console.WriteLine("O valor dos impostos por saque é de: "+ TAXA_SAQUE*100 + "%.");
            return TAXA_SAQUE;
        }

        public override void deposito(double valor)
        {
            if(valor<=0)
            {
                throw new ArgumentException();
            } 
            else
            {
                this.Saldo += valor - 0.05;
            }
        }

        public override void saque(double valor)
        {
            if(valor <=0)
            {
                throw new ArgumentException();
            }

            if(valor > this.Saldo*(1 + TAXA_SAQUE))
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
                this.Saldo -= valor + valor*TAXA_SAQUE;
            }
        }
    }
}