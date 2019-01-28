using System;
using System.Collections.Generic;
using System.Linq;
using FirstProject.SimulacaoBanco;
using FirstProject.TiposDeConta;
namespace FirstProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var geradorDevedores = new GeraDevedores();
            var devedores = geradorDevedores.devedores;
            var geradorContas = new GeraContas();
            var contas = geradorContas.contas;
    
           

            var totalDeSaldo = from c in contas where c.Saldo > 500 select c.Saldo;
             
            
            foreach(double d in totalDeSaldo)
            System.Console.WriteLine(d);

            var titulares = from c in contas orderby c.NomeProprietario, c.Saldo select c;
            titulares = titulares.OrderBy(c => c.NomeProprietario).ThenBy(c => c.Saldo);
            
            foreach(Conta c in titulares){
                System.Console.WriteLine(c.NomeProprietario);
            }


            
        }
    }
}
