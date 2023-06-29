using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmaConta
{
    class ContaNegativa : EstadoDeUmaConta
    {
        public void Deposita(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.95;

            if (conta.Saldo > 0) conta.EstadoAtual = new ContaPositiva();
        }

        public void Saca(ContaBancaria conta, double valor)
        {
            throw new Exception("Contas negativas não podem realizar saque!");
        }
    }
}
