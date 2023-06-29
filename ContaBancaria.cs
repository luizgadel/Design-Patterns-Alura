using CursoPadroesProjeto.EstadosDeUmaConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public EstadoDeUmaConta EstadoAtual { get; set; }

        public ContaBancaria(double saldo) 
        {
            Saldo = saldo;
            EstadoAtual = new ContaPositiva();
        }

        public void adicionaSaldo(double valor)
        {
            EstadoAtual.Deposita(this, valor);
        }

        public void retiraSaldo(double valor)
        {
            EstadoAtual.Saca(this, valor);
        }
    }
}
