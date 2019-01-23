using System;
using FirstProject.Intefaces;
using FirstProject.Excecoes;

namespace FirstProject.TiposDeConta
{
    public class ContaDeInvestimento : Conta, ITributavel
    {
        public ContaDeInvestimento(double saldo, string nomeProprietario, DateTime dataAbertura) : base(saldo, nomeProprietario, dataAbertura)
        {
        }

        public override double calculaImposto()
        {
            return 0;
        }

        public double calculaTributo()
        {
            return Saldo * 0.03;
        }

        public override void deposito(double valor)
        {
            if(valor<0)
            {
                throw new ArgumentException("Valor inválido para depósito!");
            }
            else
            {
                this.Saldo += valor;
            }
            
        }

        public override void saque(double valor)
        {
            if(valor<=0)
            {
                throw new ArgumentException("Valor inválido para o saque!");
            }
            if(valor>this.Saldo)
            {
                System.Console.WriteLine("Saldo insuficiete");
                throw new SaldoInsuficienteException();
            }
            else
                this.Saldo -= valor;

        }
    }
}