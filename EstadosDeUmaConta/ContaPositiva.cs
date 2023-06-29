using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.EstadosDeUmaConta
{
    class ContaPositiva : EstadoDeUmaConta
    {
        public void Deposita(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(ContaBancaria conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.EstadoAtual = new ContaNegativa();
        }
    }
}
