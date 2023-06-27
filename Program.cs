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
            IList<Conta> contas = new List<Conta>()
            {
                new Conta(50),
                new Conta(500),
                new Conta(5_000, new DateTime(1997, 8, 17)),
                new Conta(50_000),
                new Conta(500_000),
                new Conta(5_000_000, new DateTime(1976, 5, 21)),
                new Conta(50_000_000),
                new Conta(500_000_000),
            };

            Filtro filtro1 = new FiltroSaldoMenorCem(
                new FiltroSaldoMaiorQuinhentosMil(
                    new FiltroDataAberturaMesCorrente()
                    )
                );
            filtro1.Aplica(contas);

            Console.ReadKey();
        }
    }
}
