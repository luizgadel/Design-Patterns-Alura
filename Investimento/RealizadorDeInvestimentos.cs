using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class RealizadorDeInvestimentos
    {
        public void Investe(ContaBancaria conta, Investimento estrategiaInvestimento)
        {
            Console.WriteLine("A conta bancário tem {0} de saldo.", conta.Saldo);
            double lucro = estrategiaInvestimento.Calcula(conta);
            Console.WriteLine("Investimento realizado.\nLucro obtido: {0}", lucro);
            double retornoDoInvestimento = 0.75 * lucro;
            Console.WriteLine("Retorno do investimento: {0}", retornoDoInvestimento);
            conta.adicionaSaldo(retornoDoInvestimento);
            Console.WriteLine("Novo saldo da conta: {0}", conta.Saldo);
        }
    }
}
