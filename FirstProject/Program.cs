using System;
using System.Collections.Generic;
using FirstProject.SimulacaoBanco;
using FirstProject.TiposDeConta;
namespace FirstProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Conta[3];
            
            
            banco[0] = new ContaCorrente(1000, "Maria", DateTime.Today);
            banco[1] = new ContaCorrente(1000, "Maria", DateTime.Today);
            banco[2] = new ContaDeInvestimento(1000, "Maria", DateTime.Today);
           
            

            System.Console.WriteLine(banco[0].Equals(banco[1]));
            System.Console.WriteLine(banco[0].GetHashCode() == banco[2].GetHashCode());

            GeraContas gerador = new GeraContas();

            
        }
    }
}
