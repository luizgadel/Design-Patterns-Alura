using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Impostos
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            else return OutroImposto.Calcula(orcamento);
        }
    }
}
