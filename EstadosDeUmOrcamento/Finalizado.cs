using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmOrcamento
{
    class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de finalização e não pode ser aprovado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de finalização.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de finalização e não pode ser reprovado.");
        }
    }
}
