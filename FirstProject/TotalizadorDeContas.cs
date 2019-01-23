namespace FirstProject
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