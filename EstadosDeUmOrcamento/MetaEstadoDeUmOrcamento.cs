using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmOrcamento
{
    public interface MetaEstadoDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
    }
}
