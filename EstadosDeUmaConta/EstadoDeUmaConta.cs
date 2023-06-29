using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmaConta
{
    public interface EstadoDeUmaConta
    {
        void Saca(ContaBancaria conta, double valor);
        void Deposita(ContaBancaria conta, double valor);
    }
}
