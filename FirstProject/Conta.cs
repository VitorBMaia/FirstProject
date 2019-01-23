using System;

namespace FirstProject

{
    public class Conta : IImposto
    {
        
        public double Saldo { get; private set; }
        public string NomeProprietario { get; set; }
        public DateTime DataAbertura { get; set; }
        public int numero { get; set; }

        public Conta(double saldo, string nomeProprietario, DateTime dataAbertura){
            this.Saldo = saldo;
            this.NomeProprietario = nomeProprietario;
            this.DataAbertura = dataAbertura;
        }
        public virtual void saque(double valor){
            if(valor<=Saldo)
            this.Saldo -= valor;
            else
            System.Console.WriteLine("Saldo insuficiente!");
        }

        public virtual void deposito(double valor){
            if(valor >0)
            this.Saldo += valor;
            else
            System.Console.WriteLine("Valor para depósito inválido");
        }

        public virtual double calculaImposto(){

            return 0;
        }


        
        
            
        
    }
}