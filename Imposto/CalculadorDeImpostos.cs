using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Impostos
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto estrategiaImposto)
        {
            double resultado = estrategiaImposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }
    }
}
