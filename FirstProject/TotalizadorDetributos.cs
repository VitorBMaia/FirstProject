namespace FirstProject
{
    public class TotalizadorDetributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel tributavel)
        {
            this.Total += tributavel.calculaTributo();
        }
    }
}