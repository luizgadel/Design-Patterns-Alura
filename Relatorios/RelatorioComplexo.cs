using CursoPadroesProjeto.RequisicoesWeb;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace CursoPadroesProjeto.Relatorios
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void ExtraiCabecalho()
        {
            Cabecalho = $"Banco: {Recursos.NomeBP}\nEndereço: {Recursos.EnderecoBP}\nTelefone: {Recursos.TelefoneBP}\n";
        }

        protected override void ExtraiCorpo(ContaParaRequisicao conta)
        {
            Corpo = $"Titular: {conta.Nome}\nAgência: {Recursos.AgenciaBP}\nConta: {Recursos.NumContaBP}\nSaldo: {conta.Saldo}\n";
        }

        protected override void ExtraiRodape()
        {
            Rodape = $"{Recursos.EmailBP}\n{DateTime.Today}\n";
        }
    }
}
