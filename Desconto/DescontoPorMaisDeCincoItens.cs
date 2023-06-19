using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Desconto
{
    public class DescontoPorMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return 0.1 * orcamento.Valor;
            }
            else return Proximo.Desconta(orcamento);
        }
    }
}
