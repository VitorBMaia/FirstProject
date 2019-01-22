using System;
namespace FirstProject
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
            if(valor>0)
            this.Saldo += valor;
            else
            System.Console.WriteLine("Deposito de valor invalido");
        }

        public override void saque(double valor)
        {
            if(valor<=this.Saldo)
          this.Saldo -= (valor + valor*TAXA_SAQUE);   
          else
          System.Console.WriteLine("Saldo insuficiente");
        }
    }
}