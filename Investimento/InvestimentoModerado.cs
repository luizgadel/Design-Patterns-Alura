using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class InvestimentoModerado : Investimento
    {
        private Random random;

        public InvestimentoModerado()
        {
            random = new Random();  
        }

        public double Calcula(ContaBancaria conta)
        {
            int sorteio = random.Next(2);

            if (sorteio == 0)
            {
                return 0.025 * conta.Saldo;
            }
            else
            {
                return 0.007 * conta.Saldo;
            }
        }
    }
}
