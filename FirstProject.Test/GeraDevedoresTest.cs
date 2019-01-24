using FirstProject.SimulacaoBanco;
using Xunit;

namespace FirstProject.Test
{
    public class GeraDevedoresTest
    {
        [Fact]
        public void DeveGerarUmaListaDeNomes()
        {
            var valorEsperado = typeof(string);
            GeraDevedores gerador = new GeraDevedores();
            var valorAtual = gerador.Gerar();
            Assert.IsType(valorEsperado, valorAtual[0]);


        }
    }
}