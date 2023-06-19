using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Desconto
{
    public class TestaCorrente
    {
        public void Testa(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorMaisDeCincoItens();
            IDesconto d2 = new DescontoPorOrcamentoMaiorQueQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
