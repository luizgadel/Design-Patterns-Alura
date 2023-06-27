using CursoPadroesProjeto.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPadroesProjeto.Filtros
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; set; } 

        protected Filtro()
        {
            OutroFiltro = null;
        }

        public Filtro(Filtro outroFiltro) 
        {
            OutroFiltro = outroFiltro;
        }
        public abstract bool Filtra(Conta conta);

        protected bool AplicaOutroFiltro(Conta conta)
        {
            return (OutroFiltro == null ? false : OutroFiltro.Filtra(conta));
        }

        public IList<Conta> Aplica(IList<Conta> contas)
        {
            IList<Conta> novaLista = new List<Conta>();
            foreach (var conta in contas)
            {
                Console.Write($"Conta ({conta.ToString()}): ");
                if (Filtra(conta))
                {
                    novaLista.Add(conta);
                    Console.WriteLine("O");
                }
                else
                {
                    Console.WriteLine("X");
                }
            }
            return novaLista;
        }
    }
}
