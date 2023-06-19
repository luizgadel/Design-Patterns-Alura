using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.RequisicoesWeb
{
    public class ContaParaRequisicao : ContaBancaria
    {

        public String Nome;
        public ContaParaRequisicao(double saldo, String nome) : base(saldo)
        {
            this.Nome = nome;
        }
    }
}
