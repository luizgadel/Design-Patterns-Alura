using CursoPadroesProjeto.Contas;
using CursoPadroesProjeto.Filtros;
using CursoPadroesProjeto.Impostos;
using CursoPadroesProjeto.Relatorios;
using CursoPadroesProjeto.RequisicoesWeb;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoPadroesProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(100);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();
            Console.ReadKey();
        }
    }
}
