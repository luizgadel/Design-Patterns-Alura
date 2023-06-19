using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Desconto
{
    public class DescontoPorOrcamentoMaiorQueQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return 0.07 * orcamento.Valor;
            }
            else return Proximo.Desconta(orcamento);
        }
    }
}
