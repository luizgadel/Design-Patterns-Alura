using CursoPadroesProjeto.Relatorios;
using CursoPadroesProjeto.RequisicoesWeb;
using System;

namespace CursoPadroesProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaParaRequisicao conta = new ContaParaRequisicao(1, "Luiz");

            Requisicao req = new Requisicao(Formato.NIL);

            ProcessadorRequisicao p3 = new ProcessadorRequisicaoPorcento();
            ProcessadorRequisicao p2 = new ProcessadorRequisicaoCSV(p3);
            ProcessadorRequisicao p1 = new ProcessadorRequisicaoXML(p2);

            Console.WriteLine(p1.Processa(conta, req));

            Relatorio rel = new RelatorioSimples();

            rel.Imprime(conta);

            Console.ReadKey();
        }
    }
}
