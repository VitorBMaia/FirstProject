using System.Collections.Generic;

namespace FirstProject.SimulacaoBanco
{
    public class GeraDevedores
    {
        public List<string> Gerar()
        {
            var lista = new List<string>();

            for (int i = 0; i < 30; i++)
            {
                lista.Add("Devedor " + i);               
            }
            return lista;
        }
    }
}