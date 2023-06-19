using CursoPadroesProjeto.RequisicoesWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Relatorios
{
    public class RelatorioSimples : Relatorio
    {
        protected override void ExtraiCabecalho()
        {
            Cabecalho = $"Banco: {Recursos.NomeBP}\n";
        }

        protected override void ExtraiRodape()
        {
            Rodape = $"Telefone: {Recursos.TelefoneBP}\n";
        }

        protected override void ExtraiCorpo(ContaParaRequisicao conta)
        {
            Corpo = $"Titular: {conta.Nome}\nSaldo: {conta.Saldo}\n";
        }
    }
}
