using CursoPadroesProjeto.RequisicoesWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Relatorios
{
    public abstract class Relatorio
    {
        protected string Cabecalho { get; set;  }
        protected string Corpo { get; set; }
        protected string Rodape { get; set; }

        protected abstract void ExtraiCabecalho();
        protected abstract void ExtraiRodape();
        protected abstract void ExtraiCorpo(ContaParaRequisicao conta);

        public Relatorio()
        {
            ExtraiCabecalho();
            ExtraiRodape();
        }

        private void ImprimeRelatorio()
        {
            Console.WriteLine(Cabecalho);
            Console.WriteLine(Corpo);
            Console.WriteLine(Rodape);
        }

        public void Imprime(ContaParaRequisicao conta)
        {
            ExtraiCorpo(conta);
            ImprimeRelatorio();
        }

        public void Imprime(IList<ContaParaRequisicao> listaContas)
        {
            foreach (ContaParaRequisicao conta in listaContas)
            {
                Imprime(conta);
            }
        }
    }
}
