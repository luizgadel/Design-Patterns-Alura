using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Desconto
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {

            if (orcamento.Itens.Any(i => i.Nome == "LAPIS") && orcamento.Itens.Any(i => i.Nome == "CANETA"))
            {
                return 0.05 * orcamento.Valor;
            }
            else return Proximo.Desconta(orcamento);
        }
    }
}
