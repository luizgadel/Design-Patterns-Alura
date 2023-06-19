using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class InvestimentoConservador : Investimento
    {
        public double Calcula(ContaBancaria conta)
        {
            return 0.008 * conta.Saldo;
        }
    }
}
