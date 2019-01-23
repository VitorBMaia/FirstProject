using System;

namespace FirstProject

{
    public abstract class Conta : IImposto
    {
        
        public double Saldo { get; protected set; }
        public string NomeProprietario { get; set; }
        public DateTime DataAbertura { get; set; }
        public int numero { get; set; }

        public Conta(double saldo, string nomeProprietario, DateTime dataAbertura){
            this.Saldo = saldo;
            this.NomeProprietario = nomeProprietario;
            this.DataAbertura = dataAbertura;
        }
        public abstract void saque(double valor);
            
        

        public abstract void deposito(double valor);

        

        public abstract double calculaImposto();


        
        
            
        
    }
}