using System;
namespace FirstProject
{

    
    public class ContaPoupanca : Conta
    {
        public const double tAXA_SAQUE = 0.0;

        public ContaPoupanca(double saldo, string nome, DateTime dataAbertura): base(saldo, nome, dataAbertura) {
        
        }

        public static double TAXA_SAQUE => tAXA_SAQUE;

        public override double calculaImposto()
        {
            System.Console.WriteLine("O valor dos impostos por saque é de: " + TAXA_SAQUE*100 + "%.");
            return TAXA_SAQUE;
        }

        public override void deposito(double valor)
        {
            if(valor > 0)
            this.Saldo += valor;
            else
            System.Console.WriteLine("Deposito de valor invalido!");
        }

        public override void saque(double valor)
        {
            if(valor <= this.Saldo)
            this.Saldo -= valor;
            else
            System.Console.WriteLine("Saldo insuficiente!");

        }
    }
}