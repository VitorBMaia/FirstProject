using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Conta[3];
            
            
            banco[1] = new ContaCorrente(1000, "Maria", DateTime.Today);
            banco[2] = new ContaPoupanca(1000, "José", DateTime.Today);


        }
    }
}
