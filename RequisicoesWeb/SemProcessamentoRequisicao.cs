using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.RequisicoesWeb
{
    public class SemProcessamentoRequisicao : ProcessadorRequisicao
    {
        public new string Processa(ContaParaRequisicao conta, Requisicao requisicao)
        {
            return "Conta não processada.";
        }

        protected override string GetDelimitador()
        {
            throw new NotImplementedException();
        }
    }
}
