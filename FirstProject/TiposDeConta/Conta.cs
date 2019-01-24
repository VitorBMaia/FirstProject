using System;
using FirstProject.Intefaces;
namespace FirstProject.TiposDeConta

{
    public abstract class Conta : IImposto
    {
        public static int QuantidadeDeContas;
        public double Saldo { get; protected set; }
        public string NomeProprietario { get; set; }
        public DateTime DataAbertura { get; set; }
        public int numero { get; set; }

        public Conta(){
            QuantidadeDeContas++;
        }
        public Conta(double saldo, string nomeProprietario, DateTime dataAbertura){
            this.Saldo = saldo;
            this.NomeProprietario = nomeProprietario;
            this.DataAbertura = dataAbertura;
            QuantidadeDeContas++;
        }
        public abstract void saque(double valor);
        public abstract void deposito(double valor);
        public abstract double calculaImposto();

        public static int ProximaConta(){
            return QuantidadeDeContas + 1;
        }


        public override string ToString()
        {
            return String.Format("{0}:[Numero da Conta = {1} | Titular = {2} | Data de Abertura = {3} | Saldo = {4}]",
            this.GetType().Name, this.numero, this.NomeProprietario, this.DataAbertura, this.Saldo);
        }

        public override bool Equals(object obj)
        {

            if(this.GetType() != obj.GetType() || obj == null)
            {
                return false;
            }

            Conta other = (Conta) obj;
            
            return this.DataAbertura.Equals(other.DataAbertura) &&
              this.NomeProprietario.Equals(other.NomeProprietario) &&
              this.numero.Equals(other.numero) && this.Saldo.Equals((other.Saldo));
            
        }

        public override int GetHashCode()
        {
            var hashCode = 1;

            hashCode *= (this.numero == 0)? 31 : this.numero.GetHashCode() * 31;
            hashCode *= (this.DataAbertura == null)? 31 : this.DataAbertura.GetHashCode() * 31;
            hashCode *= (this.NomeProprietario == null)? 31 : this.DataAbertura.GetHashCode() * 31;
            hashCode *= (this.Saldo == 0)? 31 : this.Saldo.GetHashCode() * 31;
            
            return hashCode;
        }
        

            
        
    }
}