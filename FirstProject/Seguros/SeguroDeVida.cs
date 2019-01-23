using FirstProject.Intefaces;
using FirstProject.TiposDeConta;

namespace FirstProject.Seguros
{
    public class SeguroDeVida : ITributavel
    {
        public double calculaTributo()
        {
            return 42;
        }
    }
}