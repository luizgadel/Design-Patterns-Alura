using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmOrcamento
{
    class DescontoAAplicar : MetaEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.EstadoAtual.AplicaDescontoExtra(orcamento);
            orcamento.MetaEstadoAtual = new DescontoAplicado();
        }
    }
}
