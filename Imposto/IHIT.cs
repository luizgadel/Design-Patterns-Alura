using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (tem2ItensComMesmoNome(orcamento.Itens))
            {
                return true;
            }

            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }

        private bool tem2ItensComMesmoNome(IList<Item> itens)
        {
            IList<string> contadorNomes = new List<string>();

            foreach (Item item in itens) 
            {
                if (contadorNomes.Contains(item.Nome))
                {
                    return false;
                }
                else
                {
                    contadorNomes.Add(item.Nome);
                }
            }

            return false;
        }
    }
}
