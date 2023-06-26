using CursoPadroesProjeto.Impostos;
using CursoPadroesProjeto.Relatorios;
using CursoPadroesProjeto.RequisicoesWeb;
using System;

namespace CursoPadroesProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000);
            Imposto iss = new ImpostoMuitoAlto(new ICPP());

            double imposto = iss.Calcula(orcamento);
            Console.WriteLine(imposto);

            Console.ReadKey();
        }
    }
}
