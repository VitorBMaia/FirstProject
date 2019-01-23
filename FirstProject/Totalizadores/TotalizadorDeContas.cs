using FirstProject.Intefaces;
using FirstProject.TiposDeConta;

namespace FirstProject.Totalizadores

{
    public class TotalizadorDeContas
    {
        public double Total { get; private set; }


        public void Adiciona(Conta conta)
        {
            this.Total += conta.Saldo;    
        }
    }
}