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
            Conta conta = new Conta(500);
            Console.WriteLine(conta.Saldo);
            conta.retiraSaldo(450);
            Console.WriteLine(conta.Saldo);
            conta.adicionaSaldo(50);
            Console.WriteLine(conta.Saldo);
            conta.retiraSaldo(100);
            Console.WriteLine(conta.Saldo);
            conta.adicionaSaldo(50);
            Console.WriteLine(conta.Saldo);
            conta.retiraSaldo(100);
            Console.WriteLine(conta.Saldo);
            Console.ReadKey();
        }
    }
}
