using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class InvestimentoArrojado : Investimento
    {
        private Random random;

        public InvestimentoArrojado() 
        {
            random = new Random();
        }

        public double Calcula(ContaBancaria conta)
        {
            int sorteio = random.Next(10);
            
            if (sorteio < 2)
            {
                return 0.05 * conta.Saldo;
            }
            else if(sorteio < 5)
            {
                return 0.03 * conta.Saldo;
            }
            else
            {
                return 0.006 * conta.Saldo;
            }
        }
    }
}
