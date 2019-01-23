using System;
using FirstProject.Intefaces;
using FirstProject.Excecoes;

namespace FirstProject.TiposDeConta
{

    
    public class ContaPoupanca : Conta, ITributavel
    {
        public const double tAXA_SAQUE = 0.0;

        public ContaPoupanca(double saldo, string nome, DateTime dataAbertura): base(saldo, nome, dataAbertura) {
        
        }

        public static double TAXA_SAQUE => tAXA_SAQUE;

        public override double calculaImposto()
        {
            System.Console.WriteLine("O valor dos impostos por saque é de: " + TAXA_SAQUE* 100 + "%.");
            return TAXA_SAQUE;
        }

        public double calculaTributo()
        {
            return this.Saldo * 0.05;
        }

        public override void deposito(double valor)
        {
            if(valor<=0)
            {
                System.Console.WriteLine("Valor inválido apra depósito!");
                throw new ArgumentException();
            }
            else
            this.Saldo += valor;
        }

        public override void saque(double valor)
        {
            if(valor <=0)
            {
                System.Console.WriteLine("Valor inválido para saque!");
                throw new ArgumentException();
            }
            if(valor > this.Saldo)
            {
                System.Console.WriteLine("Saldo insuficiente!");
                throw new SaldoInsuficienteException();
            }
            else
            this.Saldo -= valor;
            

            
        }
    }
}