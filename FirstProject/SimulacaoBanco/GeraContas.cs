using System;
using System.Collections.Generic;
using FirstProject.TiposDeConta;
namespace FirstProject.SimulacaoBanco
{
    public class GeraContas
    {
        public HashSet<Conta> contas { get; private set; }
        public Dictionary<string, Conta> dicionario { get; private set; }

        public GeraContas()
        {
            this.contas = new HashSet<Conta>();
            this.dicionario = new Dictionary<string, Conta>();

            for(int i = 0; i< 5; i++)
            {
                ContaCorrente cc = new ContaCorrente(1000 + i, "Corrente" + i, DateTime.Now);
                ContaPoupanca cp = new ContaPoupanca(1000 + i, "Poupanca" + i, DateTime.Now);
                ContaDeInvestimento cdi = new ContaDeInvestimento(1000 + i, "Investimento" + i, DateTime.Now);
                contas.Add(cc);
                contas.Add(cp);
                contas.Add(cdi);
                dicionario.Add(cc.NomeProprietario, cc);
                dicionario.Add(cp.NomeProprietario, cp);
                dicionario.Add(cdi.NomeProprietario, cdi);
            }
        }

        public Conta BuscaPorNome(string titular)
        {
            return dicionario.GetValueOrDefault(titular);
        }
    }
}