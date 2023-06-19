using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.RequisicoesWeb
{
    public abstract class ProcessadorRequisicao
    {
        protected ProcessadorRequisicao Proximo { get; set; }

        public ProcessadorRequisicao()
        {
            Proximo = null;
        }

        public ProcessadorRequisicao(ProcessadorRequisicao proximo)
        {
            Proximo = proximo;
        }

        protected abstract string GetDelimitador();

        public string Processa(ContaParaRequisicao conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return conta.Nome + GetDelimitador() + conta.Saldo.ToString();
            }
            else if (Proximo != null) return Proximo.Processa(conta, requisicao);
            else return "Conta não processada.";
        }
    }
}
