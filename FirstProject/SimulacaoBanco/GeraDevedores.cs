using System.Collections.Generic;

namespace FirstProject.SimulacaoBanco
{
    public class GeraDevedores
    {
        public List<string> devedores { get; private set; }
        public GeraDevedores()
        {
            
            this.devedores = new List<string>();

            for (int i = 0; i < 30; i++)
            {
                devedores.Add("Devedor " + i);               
            }
            
        }
    }
}