using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaPoupanca(1000, "", Convert.ToDateTime("21/01/2019"));
            var conta2 = new ContaCorrente(1000, "", Convert.ToDateTime("21/01/2019"));
            var totalizador = new TotalizadorDeContas();
            totalizador.Adiciona(conta1);
            totalizador.Adiciona(conta2);
            System.Console.WriteLine(totalizador.Total);

        }
    }
}
