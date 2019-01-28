using System.Collections.Generic;
using FirstProject.SimulacaoBanco;
using FirstProject.TiposDeConta;
using Xunit;

namespace FirstProject.Test
{
    public class GeraContasTest
    {
        [Fact]
        public void DeveRetornarUmaListaComTodosOsTiposDeConta()
        {   
            
            var valorEsperado1 = typeof(ContaCorrente);
            var valorEsperado2 = typeof(ContaPoupanca);
            var valorEsperado3 = typeof(ContaDeInvestimento);

            GeraContas gerador = new GeraContas();
            var lista = gerador.contas;
            
            
            
        }
    }
}