using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Impostos
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }

        public ImpostoMuitoAlto(Imposto OutroImposto) : base(OutroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculaOutroImposto(orcamento);
        }
    }
}
