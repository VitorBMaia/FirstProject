using System;

namespace FirstProject
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
            if(valor>=0)
            this.Saldo += valor;
            else
            System.Console.WriteLine("Valor inválido para depósito!");
        }

        public override void saque(double valor)
        {
            if(valor <= this.Saldo && valor >0)
            this.Saldo -= valor;

        }
    }
}